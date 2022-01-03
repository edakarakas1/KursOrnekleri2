using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sonsuzDöngü
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            int sayac=0;
            for (int i = 1; i <= 10; i++)
            {
                sayac++;
                if (sayac == 6)
                {
                    break;
                }
                MessageBox.Show(i+".mesaj");
               
                    
                
            }
        }
    }
}
