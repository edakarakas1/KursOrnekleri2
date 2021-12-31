using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace polimorfizmornek
{
    public partial class FormDortgen : Form
    {
        public FormDortgen()
        {
            InitializeComponent();
        }
        List<ProfilDortgen> dlist=new List<ProfilDortgen>();    
        private void buttonEkle_Click(object sender, EventArgs e)
        {ProfilDortgen d=new ProfilDortgen();
            d.ID = Convert.ToInt32(textBoxId.Text);
            d.UrunAd=textBoxAd.Text;
            d.Yukseklik=Convert.ToDecimal(textBoxYukseklik.Text);
            d.uzunkenar = Convert.ToDecimal(textBoxUzun.Text);
            d.kisakenar = Convert.ToDecimal(textBoxKisa.Text);
            dlist.Add(d);
            temizle();
            listele();


        }

        private void listele()
        {
          listBoxUrun.Items.Clear();
            foreach (var item in dlist)
            {
                listBoxUrun.Items.Add(item);
            }
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = dlist;
        }

        private void temizle()
        {
            textBoxId.Clear();
            textBoxAd.Clear();
            textBoxYukseklik.Clear();
            textBoxKisa.Clear();
            textBoxUzun.Clear();
            textBoxHacim.Clear();
            textBoxFire.Clear();
            textBoxTalanı.Clear();

        }
        ProfilDortgen secilenurun;
        private void listBoxUrun_SelectedIndexChanged(object sender, EventArgs e)
        {
            secilenurun= (ProfilDortgen)listBoxUrun.SelectedItem;
            textBoxId.Text= secilenurun.ID.ToString();
            textBoxAd.Text =secilenurun.UrunAd;
            textBoxYukseklik.Text = secilenurun.Yukseklik.ToString();
            textBoxTalanı.Text=secilenurun.GetTabanAlani().ToString();
            textBoxKisa.Text=secilenurun.kisakenar.ToString();
            textBoxUzun.Text=secilenurun.uzunkenar.ToString();


        }

        private void buttonGüncelle_Click(object sender, EventArgs e)
        {
            secilenurun.ID = Convert.ToInt32( textBoxId.Text);
            secilenurun.UrunAd = textBoxAd.Text;
            secilenurun.Yukseklik =Convert.ToDecimal( textBoxYukseklik.Text);
            secilenurun.kisakenar = Convert.ToDecimal(textBoxKisa.Text);
            secilenurun.uzunkenar = Convert.ToDecimal(textBoxUzun.Text);
            textBoxHacim.Text=secilenurun.GetHacim().ToString();
            textBoxFire.Text=secilenurun.Fire().ToString();
            textBoxTalanı.Text=secilenurun.GetTabanAlani().ToString();
            listele();
            temizle();
                
                }

        private void buttonListele_Click(object sender, EventArgs e)
        {
            listele();
        }

        private void buttonSil_Click(object sender, EventArgs e)
        {
            dlist.Remove(secilenurun);
            listele();
            temizle();

        }
    }
}