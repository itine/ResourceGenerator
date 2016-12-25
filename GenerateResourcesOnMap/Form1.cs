using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GenerateResourcesOnMap
{
    public partial class Form1 : Form
    {
        List<Image> AllMonsters = new List<Image>();
        Button[] ImageButtons = new Button[2];
        public Form1()
        {
            InitializeComponent();
        }
        private int[,] GenerateMassive()
        {
            int[,] msv = new int[202, 202];
            int i = msv.GetLength(0) / 2;
            int j = msv.GetLength(1) / 2;
            int value = 0;
            int step = 0;
            int side = 0;
            msv[i, j] = value++;
            while (i <= msv.GetLength(0) || j <= msv.GetLength(1))
            {
                int temp;
                switch (side)
                {
                    case 0:
                        step++;
                        temp = j;
                        for (int t = 0; t < step; t++)
                            try { msv[i, j--] = value++; }
                            catch { value--; }
                        side = 1;
                        break;
                    case 1:
                        temp = i;
                        for (int t = 0; t < step; t++)
                            try { msv[i++, j] = value++; }
                            catch { value--; }
                        side = 2;
                        break;
                    case 2:
                        step++;
                        temp = j;
                        for (int t = 0; t < step; t++)
                            try { msv[i, j++] = value++; }
                            catch { value--; }
                        side = 3;
                        break;
                    case 3:
                        temp = i;
                        for (int t = 0; t < step; t++)
                            try { msv[i--, j] = value++; }
                            catch { value--; }
                        side = 0;
                        break;
                }
            }
            return msv;

        }
        private void showButton_Click(object sender, EventArgs e)
        {
            //Чистка DGView.
            if (dataGridView1.ColumnCount != 0)
                for (int i = 0; i < dataGridView1.ColumnCount; i++)
                    dataGridView1.Columns.RemoveAt(0);
            dataGridView1.Columns.Clear();
            DataGridViewCRUD.Create(GenerateMassive(), dataGridView1, imageList1, progressBar1);
            checkBox1.Enabled = true;
        }
        

        //sizeOfDatagrid++
        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i <= dataGridView1.Columns.Count - 1; i++)
            {
                dataGridView1.Columns[i].Width = dataGridView1.Columns[i].Width + 5;
                dataGridView1.Rows[i].Height = dataGridView1.Rows[i].Height + 5;

            }
        }
        //sizeOfDatagrid--
        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i <= dataGridView1.Columns.Count - 1; i++)
            {
                dataGridView1.Columns[i].Width = dataGridView1.Columns[i].Width - 5;
                dataGridView1.Rows[i].Height = dataGridView1.Rows[i].Height - 5;

            }
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            dataGridView1.Bounds = new Rectangle(95, 15, this.Width - 150, this.Height - 50);

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        

        private static bool CompareImages(Bitmap image1, Bitmap image2)
        {
            if (image1.Width == image2.Width && image1.Height == image2.Height)
            {
                for (int i = 0; i < image1.Width; i++)
                {
                    for (int j = 0; j < image1.Height; j++)
                    {
                        if (image1.GetPixel(i, j) != image2.GetPixel(i, j))
                        {
                            return false;
                        }
                    }
                }
                return true;
            }
            else
            {
                return false;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                panel1.Visible = true;
                dataGridView2.RowCount = imageList1.Images.Count;
                dataGridView2.ColumnCount = 2;
                progressBar1.Maximum = imageList1.Images.Count-1;
                for (int i = 0; i <= imageList1.Images.Count - 1; i++)
                {
                    progressBar1.Value = i;
                    Bitmap monsterImg = (Bitmap)imageList1.Images[i];
                    DataGridViewImageCell MonsterImageCell = new DataGridViewImageCell();
                    dataGridView2.Rows[i].Cells[0] = MonsterImageCell;
                    dataGridView2.Rows[i].Cells[0].Value = monsterImg;
                    int localCount = 0;
                    for (int j = 0; j < dataGridView1.RowCount; j++)
                    {
                        for (int k = 0; k < dataGridView1.Columns.Count; k++)
                        {
                            if (dataGridView1.Rows[j].Cells[k].Value != null && (CompareImages((Bitmap)dataGridView1.Rows[j].Cells[k].Value, monsterImg)))
                            {
                                localCount++;
                            }
                        }
                    }
                    dataGridView2.Rows[i].Cells[1].Value = localCount;
                }
                progressBar1.Value = 0;
            }
            else
            {
                panel1.Visible = false;
            }
        }
    }
}