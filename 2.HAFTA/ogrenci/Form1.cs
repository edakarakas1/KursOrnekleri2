using DataUret;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ogrenci
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<ogrenci> olist = new List<ogrenci>();
            for(int i=1;i<100;i++)
            {
                ogrenci ogr=new ogrenci();
                DUret d = new DUret();

                ogr.Id = i;
                ogr.ad =d.Getname();
                ogr.soyad = d.GetSurname();
                ogr.DogumYeri = d.City();
                ogr.DogumTarihi = d.GetBackDate(28);
                ogr.KursBitisTarihi = d.ForwadDate(3);
                olist.Add(ogr);


            }
            dataGridView1.DataSource = olist;
        }
    }
}
