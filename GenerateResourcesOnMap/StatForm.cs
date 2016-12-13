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
    public partial class StatForm : Form
    {
        private DataGridView dataGridView1;

        public StatForm()
        {
            InitializeComponent();
        }

        public StatForm(DataGridView dataGridView1)
        {
            this.dataGridView1 = dataGridView1;
        }

      

     
        private void StatForm_Activated(object sender, EventArgs e)
        {
            label1.Text = dataGridView1.Columns.Count.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = dataGridView1.Columns.Count.ToString();
        }

        private void StatForm_Load(object sender, EventArgs e)
        {
            label1.Text = dataGridView1.Columns.Count.ToString();
        }
    }
}
