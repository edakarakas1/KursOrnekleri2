using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kupdikdörtgenInterface
{
    public partial class Form1 : Form
    {
        public Form1()
        {/*
       
       from da datagridview yer alıcak
      Iurun isminde bir interface içerisinde id,ad,yukseklik propertyleri yer alıcak,
      hacim isminde geri dönüşü int olan bir method olacak
      Kapkutu ve Dıkdortgen kutu isiminde iki class olucak bunlar Iurunden kalıtım alıcak
      dıkdörtgen için hacim formulu=yukseklik*kısakenar*uzunkenar,
      kupkutu için hacim=yukseklik*yukseklik*yukseklik
       */
            InitializeComponent();
        }

       
        List<Kupkutu> klist=new List<Kupkutu>();  
        private void btnKup_Click(object sender, EventArgs e)
        {
            Kupkutu k=new Kupkutu();
            k.id = 1;
            k.ad = "Mukavva Kutu";
            k.yukseklik = 15;
            klist.Add(k);

            Kupkutu k2 = new Kupkutu();
            k2.id = 2;
            k2.ad = "Karton Kutu";
            k2.yukseklik = 10;
            klist.Add(k2);

            Kupkutu k3 = new Kupkutu();
            k3.id = 3;
            k3.ad = "Tahta Kutu";
            k3.yukseklik = 15;
            klist.Add(k3);
            dataGridView1.DataSource = klist;



        }
        List<Dıkdörtgen> dlist = new List<Dıkdörtgen>();
        private void btnDikdortgen_Click(object sender, EventArgs e)
        {
            Dıkdörtgen d = new Dıkdörtgen();
            d.id = 1;
            d.ad = "Kutu";
            d.uzunkenar = 12;
            d.kısakenar = 5;
            d.yukseklik = 7;
            dlist.Add(d);

            Dıkdörtgen d2 = new Dıkdörtgen();
            d2.id = 2;
            d2.ad = "metal Kutu";
            d2.uzunkenar = 5;
            d2.kısakenar = 4;
            d2.yukseklik = 3;
            dlist.Add(d2);
            dataGridView1.DataSource = null;
            dataGridView1.DataSource= dlist;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentRow.DataBoundItem is Kupkutu)
            {
                Kupkutu k =(Kupkutu) dataGridView1.CurrentRow.DataBoundItem;
                int hacim = k.hacim();
                MessageBox.Show(hacim.ToString());
            }
            else
            {
                Dıkdörtgen d = (Dıkdörtgen)dataGridView1.CurrentRow.DataBoundItem;
                int hacim=d.hacim();
                MessageBox.Show(hacim.ToString());
            
            }
        }
    }
}
