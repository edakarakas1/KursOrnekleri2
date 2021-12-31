using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace nothesaplama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<Ogrenci> olist = new List<Ogrenci>();
        private void Form1_Load(object sender, EventArgs e)
        {
           
            for (int i = 1; i <= 100; i++)
            {
                Ogrenci o = new Ogrenci();
                o.Ad = FakeData.NameData.GetFirstName();
                o.Soyad = FakeData.NameData.GetSurname();
                o.Sınav1 = FakeData.NumberData.GetNumber(0, 100);
                o.Sınav2 = FakeData.NumberData.GetNumber(0, 100);
                o.ogrenciNo = FakeData.NumberData.GetNumber(100, 9000);
                o.ortalama = o.Ortalama();
                olist.Add(o);
            }
        }

        int secilenid;
        Ogrenci secogr;
        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            secilenid=(int)dataGridView1.CurrentRow.Cells[0].Value;
            secogr = olist.Find(x=>x.ogrenciNo==secilenid);

            txtAd.Text = secogr.Ad;
            txtSoyad.Text= secogr.Soyad;
            txtOgrenciNo.Text=secogr.ogrenciNo.ToString();
            txtSinav1.Text = secogr.Sınav1.ToString();
            txtSinav2.Text = secogr.Sınav2.ToString();
            txtOrt.Text = secogr.ortalama.ToString();
        }
        Ogrenci k;
        private void btnTüm_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = olist;
        }
        private void btnKalan_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = olist.Where(x => x.ortalama < 50).ToList();
        }

        private void btnBasarili_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = olist.Where(x => x.ortalama > 50).ToList();
        }
    }
}
