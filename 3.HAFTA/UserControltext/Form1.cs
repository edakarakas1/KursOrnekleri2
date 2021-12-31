using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UserControl;


namespace UserControltext
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            
            InitializeComponent();
            UserControl.MineTextBox minetxt = new MineTextBox();
            minetxt._Bosolabilirmi = false;
            minetxt._FocusRengi = Color.Bisque;
            minetxt._Verituru = MineTextBox.TextTuru.buyukHarf;
            this.Controls.Add(minetxt);

            TextBox txt = new TextBox();
            txt.Left = 120;
            this.Controls.Add(txt);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
