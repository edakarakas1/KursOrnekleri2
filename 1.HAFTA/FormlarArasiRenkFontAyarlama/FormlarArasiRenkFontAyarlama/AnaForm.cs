using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormlarArasiRenkFontAyarlama
{
    public partial class AnaForm : Form
    {
        public AnaForm()
        {
            InitializeComponent();
        }
        HedefForm frm = new HedefForm();
        private void button1_Click(object sender, EventArgs e)
        {
           FontAl();
        }
        public void FontAl()
        {
            FontDialog fontlar =new FontDialog();//Fon Dialoğu çağır
            fontlar.ShowDialog();
            txtAdi.Font = fontlar.Font;
            txtSoyad.Font = fontlar.Font;
            txtAciklama.Font = fontlar.Font;    


        }

        private void button2_Click(object sender, EventArgs e)
        {
            RenkAl();
        }
        public void RenkAl()
        {
            ColorDialog renk = new ColorDialog();
            renk.ShowDialog();
            txtAdi.ForeColor = renk.Color;
            txtSoyad.ForeColor = renk.Color;
            txtAciklama.ForeColor= renk.Color;


        }

        private void button4_Click(object sender, EventArgs e)
        {
            GonderilecekVeriler();
        }
        public void GonderilecekVeriler()
        {
            //Adı
            frm.labelAd.Text = txtAdi.Text;
            frm.labelAd.Font=txtAdi.Font;
            frm.labelAd.ForeColor=txtAdi.ForeColor;
            //Soyadı
            frm.labelSoyad.Text = txtSoyad.Text.ToUpper();
            frm.labelSoyad.Font=txtSoyad.Font;
            frm.labelSoyad.ForeColor=txtSoyad.ForeColor;
            //Açıklama
            frm.labelAciklama.Text = txtAciklama.Text;
            frm.labelAciklama.Font=txtAciklama.Font;
            frm.labelAciklama.ForeColor= txtAciklama.ForeColor;

            frm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtAdi.Clear();
            txtSoyad.Clear();
            txtAciklama.Clear();
            frm.Close();
        }
    }
}
