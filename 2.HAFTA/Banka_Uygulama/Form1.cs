using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banka_Uygulama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }
      
        List<Musteri> mlist = new List<Musteri>();
        private void btnEkle_Click_1(object sender, EventArgs e)
        {
            Musteri m = new Musteri();
            m.id = Convert.ToInt32(txtId.Text);
            m.Ad = txtAd.Text;
            m.soyad = txtSoyad.Text;
            m.kredikart = txtKrediKarti.Text;
            mlist.Add(m);
            Temizle();
        }
        private void Temizle()
        {
            txtId.Clear();
            txtAd.Clear();
            txtSoyad.Clear();
            txtKrediKarti.Clear();
        }

        private void btnGöster_Click(object sender, EventArgs e)
        {
            List<Musteri> m = new List<Musteri>();
                foreach (var item in mlist)
            {
                Musteri mst=new Musteri();
                mst.id=item.id;
                mst.Ad=item.Ad;
                mst.soyad = item.soyad;
                mst.kredikart = item.kredikart;
                m.Add(mst);
                
            }
                dataGridView1.DataSource=m;

        }

        

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Musteri secilen = (Musteri)dataGridView1.CurrentRow.DataBoundItem;
            textBoxAd.Text = secilen.Ad;
            textBoxSoyad.Text = secilen.soyad;
            textBoxKredi.Text = secilen.kredikart;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
