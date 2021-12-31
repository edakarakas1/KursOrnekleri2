using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SumProjeMaaaTopla
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<Ogrenci> olist = new List<Ogrenci>();
        List<Sehir> slist = new List<Sehir>();
        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 1; i <= 100; i++)
            {
                Ogrenci o = new Ogrenci();
                o.id = i;
                o.Ad = FakeData.NameData.GetFirstName();
                o.Maas = FakeData.NumberData.GetNumber(1000,5000);
                o.Sehirid = FakeData.NumberData.GetNumber(1, 81);             
                olist.Add(o);
            }
            for (int i = 0; i <=81; i++)
            {
                Sehir s = new Sehir();
                s.Sehirid = FakeData.NumberData.GetNumber(0, 81);
                s.SehirAd= FakeData.PlaceData.GetCity();
                slist.Add(s);
            }
            
        }    
        Ogrenci secilenogr;
        Sehir secsehir;
        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            secilenogr = (Ogrenci)dataGridView1.CurrentRow.DataBoundItem;
            txtId.Text = secilenogr.id.ToString();
            txtAd.Text = secilenogr.Ad;
            txtMaas.Text = secilenogr.Maas.ToString();
            secsehir = slist.Find(x => x.Sehirid == secilenogr.Sehirid);
            txtSehir.Text = secsehir.SehirAd;

        }

        private void btnGonder_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = olist;
            dataGridView2.DataSource = null;
            dataGridView2.DataSource = slist;
            txtOgrSayi.Text =olist.Count().ToString();
            txtMaas.Text=olist.Count().ToString();
        }
       
        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }
    }
}
