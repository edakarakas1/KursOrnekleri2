using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataGrid
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int satir = dataGridView1.Rows.Add();
            dataGridView1.Rows[satir].Cells[0].Value = textBox1Id.Text;
            dataGridView1.Rows[satir].Cells[1].Value = textBox2Ad.Text;
            dataGridView1.Rows[satir].Cells[2].Value = textBox3Soyad.Text;

        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            textBox1Id.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox2Ad.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox3Soyad.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();

        }
    }
}
