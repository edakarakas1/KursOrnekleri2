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
    public partial class FormKup : Form
    {
        public FormKup()
        {
            InitializeComponent();
        }
        List<ProfilKup> plist = new List<ProfilKup>();
        private void buttonEkle_Click(object sender, EventArgs e)
        {
            ProfilKup p = new ProfilKup();
            p.ID = Convert.ToInt32(textBoxId.Text);
            p.UrunAd = textBoxAd.Text;
            p.Yukseklik = Convert.ToDecimal(textBoxYukseklik.Text);
            plist.Add(p);
            temizle();
            listele();
        }
       
        private void listele()
        {
           listBoxUrun.Items.Clear();
            foreach (var item in plist)
            {
                listBoxUrun.Items.Add(item);
            }
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = plist;
        }
        private void temizle()
        {
           textBoxId.Clear();   
            textBoxAd.Clear();
            textBoxYukseklik.Clear();
            textBoxHacim.Clear();
            textBoxFire.Clear();
        }
        ProfilKup sec;
        private void listBoxUrun_SelectedIndexChanged(object sender, EventArgs e)
        {
            sec = (ProfilKup)listBoxUrun.SelectedItem;
            textBoxId.Text = sec.ID.ToString();  
            textBoxAd.Text= sec.UrunAd.ToString();
            textBoxYukseklik.Text=sec.Yukseklik.ToString();
            textBoxHacim.Text=sec.GetHacim().ToString();
            textBoxFire.Text=sec.Fire().ToString();
        }

        private void buttonGüncelle_Click(object sender, EventArgs e)
        {
            sec.ID=Convert.ToInt32(textBoxId.Text);
            sec.UrunAd = textBoxAd.Text;
            sec.Yukseklik =Convert.ToDecimal( textBoxYukseklik.Text);
            textBoxHacim.Text = sec.GetHacim().ToString();
            textBoxFire.Text= sec.Fire().ToString();
            listele();
            temizle();
        }

        private void buttonSil_Click(object sender, EventArgs e)
        {
            plist.Remove(sec);
            listele();
            temizle();
        }

        private void buttonListele_Click(object sender, EventArgs e)
        {
            listele();
        }

        
    }
}
