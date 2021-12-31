using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BisikletMontaji
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBoxFren.Items.AddRange(Enum.GetNames(typeof(FrenTipi)));
            comboBoxFren.SelectedIndex = 0;
            comboBoxkadro.Items.AddRange(Enum.GetNames(typeof(KadroTipi)));
            comboBoxkadro.SelectedIndex = 0;

        }

        private void buttonClassGndr_Click(object sender, EventArgs e)
        {
            Bisiklet b = new Bisiklet()
            { Fren = (FrenTipi)comboBoxFren.SelectedIndex,
                Kadro =(KadroTipi) comboBoxkadro.SelectedIndex,
                Modelyil=dateTimePickerModelyil.Value.Year

            };
            textBox1.Text= b.yasi.ToString();
            MessageBox.Show(b.ToString());
        }
    }
}
