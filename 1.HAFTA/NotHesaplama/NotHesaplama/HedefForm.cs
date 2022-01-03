using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NotHesaplama
{
    public partial class HedefForm : Form
    {
        public HedefForm()
        {
            InitializeComponent();
        }
        public void AnaFormdanVeriAl(string ad, double sinav1,double sinav2,double sinav3,double ort)
        {
            int satir = dataGridView2.Rows.Add();
            dataGridView2.Rows[satir].Cells[0].Value =ad;
            dataGridView2.Rows[satir].Cells[1].Value = sinav1;
            dataGridView2.Rows[satir].Cells[2].Value = sinav2;
            dataGridView2.Rows[satir].Cells[3].Value = sinav3;
            dataGridView2.Rows[satir].Cells[4].Value = ort;

            if (ort>50)
            {
                dataGridView2.Rows[satir].Cells[5].Value = "Geçti";
            }
            else 
            {
                dataGridView2.Rows[satir].Cells[5].Value = "Kaldı";
            }
        }
    }
}
