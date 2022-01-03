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
    public partial class HedefForm : Form
    {
        public HedefForm()
        {
            InitializeComponent();
        }
        public void AnaFormdanVeriAl(string uAdi, decimal fiyat, decimal kdvOrani,decimal kdvliFiyat)
        {
            labelAd.Text = uAdi;
            labelFiyat.Text = fiyat.ToString();
            labelKdvOran.Text = kdvOrani.ToString();
            labelKdvliFiyat.Text=kdvliFiyat.ToString();    
        }
    }
}
