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
    public partial class FrmSilindir : Form
    {
        public FrmSilindir()
        {
            InitializeComponent();
        }
        List<ProfilSilindir> slist = new List<ProfilSilindir>();
        private void buttonEkle_Click(object sender, EventArgs e)
        {
            ProfilSilindir pk = new ProfilSilindir();
            pk.ID = Convert.ToInt32(textBoxId.Text);
            pk.UrunAd=textBoxAd.Text;
            pk.Yukseklik = Convert.ToDecimal(textBoxYükseklik.Text);
            pk.Yaricap = Convert.ToDecimal(textBoxYaricap.Text);
            slist.Add(pk);
            temizle();
            listele();
        }

        private void listele()
        {
            listBoxUrun.Items.Clear();
            foreach (var item in slist)
            {
                listBoxUrun.Items.Add(item);
            }
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = slist;
        }

        private void temizle()
        {
            textBoxId.Clear();
            textBoxAd.Clear();
            textBoxYükseklik.Clear();
            textBoxYaricap.Clear();
            textBoxFire.Clear();
            textBoxHacim.Clear();
        }
        ProfilSilindir secilenurun;
        
        private void listBoxUrun_SelectedIndexChanged(object sender, EventArgs e)
        {
            secilenurun = (ProfilSilindir)listBoxUrun.SelectedItem;
            textBoxId.Text=secilenurun.ID.ToString();
            textBoxAd.Text = secilenurun.UrunAd;
            textBoxYükseklik.Text=secilenurun.Yukseklik.ToString();
            textBoxYaricap.Text=secilenurun.Yaricap.ToString();
            textBoxHacim.Text=secilenurun.GetHacim().ToString();
            textBoxFire.Text = secilenurun.Fire().ToString();
        }
        private void buttonGüncelle_Click(object sender, EventArgs e)
        {
            secilenurun.UrunAd = textBoxAd.Text;
            secilenurun.ID =Convert.ToInt32 (textBoxId.Text);
            secilenurun.Yaricap = Convert.ToDecimal(textBoxYaricap.Text);
            secilenurun.Yukseklik =Convert.ToDecimal (textBoxYükseklik.Text);
            textBoxHacim.Text = secilenurun.GetHacim().ToString();
            textBoxFire.Text=secilenurun.Fire().ToString();
            listele();
            temizle();
        }

        private void buttonListele_Click(object sender, EventArgs e)
        {
            listele();
        }

        private void buttonSil_Click(object sender, EventArgs e)
        {
            slist.Remove(secilenurun);
            listele();
            temizle();
        }

        private void FrmSilindir_Load(object sender, EventArgs e)
        {

        }
    }
}
