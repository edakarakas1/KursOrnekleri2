using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ogrencifakedata
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<Ogrenci> olist = new List<Ogrenci>(); 
            for (int i = 1;i<100;i++)
            {
                Ogrenci ogr = new Ogrenci();

                ogr.Id = i;
                ogr.Ad = FakeData.NameData.GetFirstName();
                ogr.Soyad = FakeData.NameData.GetSurname();
                ogr.telefon = FakeData.PhoneNumberData.GetPhoneNumber();
                olist.Add(ogr);
            }
            dataGridView1.DataSource = olist;   
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
