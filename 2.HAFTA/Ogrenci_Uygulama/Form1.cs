using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ogrenci_Uygulama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            

        }
        List<Ogrenci> o = new List<Ogrenci>();
        private void btnEkle_Click(object sender, EventArgs e)
        {
            Ogrenci ogr = new Ogrenci();
            ogr.Adı = txtAd.Text;
            ogr.Soyadı = txtSoyad.Text;
            ogr.Bölümü=txtBölüm.Text;
            ogr.Sinif= txtSinif.Text;
            o.Add(ogr);
            Temizle();
        }
        private void Temizle()
        {
           
            txtAd.Clear();
            txtSoyad.Clear();
            txtSinif.Clear();
            txtBölüm.Clear();        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<Ogrenci> olist = new List<Ogrenci>();
            foreach (var item in o)
            {
                Ogrenci ogr = new Ogrenci();
                ogr.Adı = item.Adı;
                ogr.Soyadı = item.Soyadı;
                ogr.Sinif = item.Sinif;
                ogr.Bölümü = item.Bölümü;
                ogr.ogrencino = item.ogrencino;
                olist.Add(ogr);
               
             

            }
            dataGridView1.DataSource = olist;

        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Ogrenci secilen = (Ogrenci)dataGridView1.CurrentRow.DataBoundItem;
            textBoxAd.Text = secilen.Adı;
            textBoxSoyad.Text = secilen.Soyadı;
            textBoxBölüm.Text = secilen.Bölümü;
        }
    }
}
