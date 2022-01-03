using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hamburger
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double[] fiyat = { 20,24,18 };
        double siparisFiyatBiriktir = 0;
        StringBuilder siparisnotlarim =new StringBuilder();//Sipariş notlarım biriktirmek için
        double ekstra, toplamhesap;

        private void btnSiparis_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            siparisnotlarim.Clear();
            siparisFiyatBiriktir = 0;
            ekstra = 0;
            if (comboBox1Menü.SelectedIndex!=-1)
            {
                siparisFiyatBiriktir = fiyat[comboBox1Menü.SelectedIndex];
                siparisnotlarim.Append(comboBox1Menü.SelectedItem.ToString());

                if (radioButton1Orta.Checked)
                {
                    siparisnotlarim.Append(" Orta Menü ");
                }
                else if (radioButton1Buyuk.Checked)  
                {
                    siparisFiyatBiriktir += 2;
                    siparisnotlarim.Append(" Büyük Menü (Farkı + 2 TL) ");
                }
                else if (radioButton1King.Checked)
                {
                    siparisFiyatBiriktir += 4;
                    siparisnotlarim.Append(" King Menü (Farkı + 4 TL )");
                }
                //Ekstralar groupbox kontrölünde kontrollerinde dönerek işaretli var mı bak
                foreach (Control checkekstra  in groupBox1Ekstra.Controls)
                {
                    if (checkekstra is CheckBox&&(checkekstra as CheckBox).Checked)
                    {
                        ekstra += 0.50;

                    }
                }
                if (ekstra>0)
                {
                    siparisnotlarim.Append(" Ekstralar :  ");
                    siparisnotlarim.Append(ekstra.ToString("C2"));
                    siparisFiyatBiriktir += ekstra;

                }
                int adet = Convert.ToInt32(numericUpDown1.Value);
                siparisFiyatBiriktir *= adet;
                siparisnotlarim.Append( " " + adet.ToString() );
                siparisnotlarim.Append(" Adet : " );
                siparisnotlarim.Append(" Toplam : ");
                listBox1.Items.Add(siparisnotlarim.ToString()+siparisFiyatBiriktir.ToString("C2"));
                toplamhesap += siparisFiyatBiriktir;
                
            }
        }

        private void btnHesap_Click(object sender, EventArgs e)
        {
            MessageBox.Show(toplamhesap.ToString("C2"));
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            radioButton1Orta.Checked = true;
            comboBox1Menü.SelectedIndex = 0;

        }
    }
}
