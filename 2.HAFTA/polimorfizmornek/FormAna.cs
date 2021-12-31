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
    public partial class FormAna : Form
    {
        public FormAna()
        {
            InitializeComponent();
        }

        private void silindirProfilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSilindir f=new FrmSilindir();
            f.Show();
        }

        private void dörtgenProfilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormDortgen frm=new FormDortgen();
            frm.Show();
        }

        private void küpProfilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormKup frm=new FormKup();
            frm.Show();
        }

        
    }
}
