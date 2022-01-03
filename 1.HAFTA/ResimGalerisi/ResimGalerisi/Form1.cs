using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ResimGalerisi
{
    public partial class Form1 : Form
    {
        string[] resimler;
        int hangiresim;
        int i;
        bool baslat = true;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            resimler = Directory.GetFiles("../../resimler" ,"*.jpg");
            foreach (string item in resimler)
            {
                Button btn =new Button();
                btn.Width = btn.Height = 68;
                btn.Padding = new Padding(0);//resimlerin yanına boşluk bırakmamak için kullanılır
                btn.BackgroundImage=Image.FromFile(item);   
                btn.BackgroundImageLayout = ImageLayout.Stretch;//resimleri kontrole göre sığdırmak
                btn.Tag = i++;
                flowLayoutPanel1.Controls.Add(btn);
                btn.Click += btn_click;

            }   
        }
        void btn_click(object sender,EventArgs e)
        {
            Button basılan =sender as Button;
            pictureBox1.Image = Image.FromFile(resimler[Convert.ToInt32(basılan.Tag)]);

        }

        private void btnilk_Click(object sender, EventArgs e)
        {
            hangiresim = 0;
            pictureBox1.Image = Image.FromFile(resimler[hangiresim]);

        }

        private void btnEnSonraki_Click(object sender, EventArgs e)
        {
            hangiresim = resimler.Length - 1;
            pictureBox1.ImageLocation=resimler[hangiresim];

        }

        private void btnSonraki_Click(object sender, EventArgs e)
        {
            hangiresim++;
            if (hangiresim>resimler.Length-1)
            {
                hangiresim = 0;//1.resme dön demek istiyor
                pictureBox1.ImageLocation= resimler[hangiresim];

            }
        }

        private void btnOnceki_Click(object sender, EventArgs e)
        {
            hangiresim--;   
            if (hangiresim<0)
            {
                hangiresim=resimler.Length-1;
                pictureBox1.ImageLocation = resimler[hangiresim];

            }
        }

        private void btnRastgele_Click(object sender, EventArgs e)
        {
            int rastgeleresim = 0;
            Random rnd = new Random();
            rastgeleresim=rnd.Next(0,resimler.Length-1);
            if (rastgeleresim==hangiresim)//aynı resim gelmişse
            {
                rastgeleresim=rnd.Next(0,resimler.Length-1);
            }
            hangiresim = rastgeleresim;

            pictureBox1.ImageLocation = resimler[hangiresim];
        }

        private void btnSlayt_Click(object sender, EventArgs e)
        {
            if (baslat)
            {
                btnSlayt.Text = "Slaytı Durdur";
                timer1.Interval = 700;
                timer1.Start();
                baslat=false;
            }
            else
            {
                timer1.Stop();
                btnSlayt.Text = "Slaytı Başlat";
                baslat = true;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            hangiresim++;
            if (hangiresim>resimler.Length-1)
           
                hangiresim = 0;
                pictureBox1.ImageLocation= resimler[hangiresim];
            
        }
    }
}
