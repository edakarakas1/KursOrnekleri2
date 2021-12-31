using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ToDoListUygulama.businessServices;

namespace ToDoListUygulama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Interval = 15000;
            timer1.Tick += Tm_zaman_Tick;
            timer1.Start();
            ButtonAcKapa(false);
            sistemgiris kullanicikontrol =new sistemgiris();
            kullanicikontrol.MdiParent = this;
            kullanicikontrol.StartPosition= FormStartPosition.CenterScreen;
            kullanicikontrol.Show();

        }
        private void ButtonAcKapa(bool kontrol)
        {
            foreach (Control item in groupBox1.Controls)
            {
                if(item is Button)
                {
                   ((Button) item).Enabled = kontrol;
                }
            }
        }

        private void Tm_zaman_Tick(object sender, EventArgs e)
        {
            labelZaman.Text = DateTime.Now.ToString("dd.MM.yyyy HH:mm");
        }

        private void buttonKapat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        Form T;
        private object todoServise;

        private void buttonYenikayit_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["yenikayit"]!=null)
            {//sürekli aynı pencere açılmasın diye yazılan kod kısmı yani herhangi pencere açma oraya odaklan demek
                T = Application.OpenForms["yenikayit"];
                T.Focus();//bu form açıksa git focus et
            }
            else
            {
                T = new yenikayit();
                T.MdiParent = this;
                T.Show();
            }
           

        }

        private void buttonKayitliste_Click(object sender, EventArgs e)
        {
            todoService todoServises = new todoService();
            if (todoServises.kayitKontrol()>0)
            {
                kayitliste kayitlistesi = new kayitliste();
                kayitlistesi.MdiParent = this;
                kayitlistesi.Show();
            }
            else
            {
                MessageBox.Show("Listelenecek kayıt bulunamadı","Bilgilendirme",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
           
        }
    }
}
