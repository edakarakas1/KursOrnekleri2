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
    public partial class AnaForm : Form
    {
        public AnaForm()
        {
            InitializeComponent();
            
             //Öğrencinin 3notunu al.Ortamayı hesapla ama ekrana diğer form sayfasında data grid içerisinde listele ve yanında geçti kaldı yazsın.
             
        }
        HedefForm frm = new HedefForm();
        private void btnHesapla_Click(object sender, EventArgs e)
        {
            VeriGonder();
        }


        public void VeriGonder()
        {
            string ad = textBox1.Text;
            double sinav1 = Convert.ToDouble(txtSinav1.Text);
            double sinav2 = Convert.ToDouble(txtSinav2.Text);
            double sinav3 = Convert.ToDouble(txtSinav3.Text);
            double ort = (sinav1 + sinav2 + sinav3) / 3;
           
            frm.AnaFormdanVeriAl(ad,sinav1, sinav2, sinav3,ort);
            frm.Show();
        }
    }
}
