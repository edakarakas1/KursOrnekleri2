using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormlarArasıKdvOrnek
{
    public partial class AnaForm : Form
    {
        public AnaForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            VeriGonder();
        }
         private void VeriGonder()
        {
            string urunAd = txtAdi.Text;
            decimal fiyat = Convert.ToDecimal(txtFiyat.Text);
            decimal kdvOrani = Convert.ToDecimal(txtOran.Text);
            decimal kdvliFiyat = fiyat * (1 + kdvOrani / 100);
            HedefForm frm =new HedefForm();
            frm.AnaFormdanVeriAl(urunAd,fiyat,kdvOrani,kdvliFiyat);
            frm.Show();
        }
    }
}
