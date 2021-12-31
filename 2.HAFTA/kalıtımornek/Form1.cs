using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kalıtımornek
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           // Egitmen egt = new Egitmen();
           //Adres a=new Adres();
           // a.Cadde = "cadde";
          
            dataGridView1.DataSource = olist;
        }
        List<Ogrenci> olist = new List<Ogrenci>();
        Random rnd=new Random();
        private void Form1_Load(object sender, EventArgs e)
        {
            //bölüm =fkdata.texdata.getalpha
            for (int i = 1; i <= 100; i++)
            {
                Ogrenci ogr = new Ogrenci();
                ogr.Bolum = FakeData.TextData.GetAlphabetical(8);
                // ogr.id = FakeData.NumberData.GetNumber(); 
                ogr.id=i;
                ogr.Ad = FakeData.NameData.GetFirstName();
                ogr.Soyad = FakeData.NameData.GetSurname();
               ogr.TC= FakeData.NumberData.GetNumber(0,1233333333);
                int sayi = rnd.Next(2);
                if (sayi ==1 )
                {
                    ogr.Cinsiyet = "E";
                }
                else
                {
                    ogr.Cinsiyet = "K";
                }

                olist.Add(ogr);
            }
            
        }
    } 
}


