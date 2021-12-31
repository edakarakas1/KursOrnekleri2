using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sanalmethodtostring
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<Ogrenci> olist = new List<Ogrenci>();
        private void button1_Click(object sender, EventArgs e)
        {
            Ogrenci o1 =new Ogrenci();
            o1.id = 1;
            o1.Ad = "eda";
            o1.Soyad = "karakas";
            olist.Add(o1);

            Ogrenci o2 = new Ogrenci();
            o2.id = 2;
            o2.Ad = "gül";
            o2.Soyad = "yılmaz";
            olist.Add(o2);

            Ogrenci o3 = new Ogrenci();
            o3.id = 3;
            o3.Ad = "can";
            o3.Soyad = "mutlu";
            olist.Add(o3);
            listBox1.DataSource = olist;

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Ogrenci secilen = (Ogrenci)listBox1.SelectedItem;
            textboxAd.Text = secilen.Ad;
            textboxSoyad.Text= secilen.Soyad;
            TextboxId.Text = Convert.ToString(secilen.id);
            ToString();


        }
    }
}
