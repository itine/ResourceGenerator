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
        public Form1()
        {
            InitializeComponent();
        }
        private int [,] GenerateCoordinates()
        {
            int[,] msv = new int[200, 200];
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
            foreach (DataGridViewColumn column in this.dataGridView1.Columns)
            {
                column.ValueType = typeof(System.Drawing.Bitmap);
            }
            DataGridViewCRUD.Create(GenerateCoordinates(), dataGridView1, imageList1);
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}