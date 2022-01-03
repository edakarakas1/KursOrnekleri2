using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Foreach_Gunler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            string[] gunler = {"Pazartesi","Salı","Çarşamba","Perşembe","Cuma","Cumartesi","Pazar" };
            string[] Aylar = { "Ocak","Şubat", "Mart","Nisan","Mayıs","Haziran","Temmuz","Ağustos","Eylül","Ekim","Kasım","Aralık" };

            foreach (string item in gunler)
            {
                comboBox1.Items.Add(item);  

            }
            Aylar.Items.AddRange(Aylar);
            foreach (Control ctr in Controls)
            {
                ctr.BackColor = Color.Coral;
                ctr.ForeColor = Color.Bisque;
            }
        }
    }
}
