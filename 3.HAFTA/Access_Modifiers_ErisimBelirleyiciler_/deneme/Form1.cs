using Access_Modifiers_ErisimBelirleyiciler_;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace deneme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Public:Uygulamamızın içinde veya dışarısında ulaşılabilir
            //private:Sadece tanımlandığı class içerisinden erişilebilir
            //protected:Normal kullanımda private gibi çalışır.Kalıtım alınırsa public olarak işlem görür
            //İNTERNAL :Bu namespace in içerisinde ulaşılabilir.Clasların varsayılan erişin belirleyicisidir.

            Kisi k =new Kisi();
            Ogrenci o =new Ogrenci();
           
        }
    }
}
