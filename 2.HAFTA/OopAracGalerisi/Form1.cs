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

namespace OopAracGalerisi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       
        private void Form1_Load(object sender, EventArgs e)
        {
            string resimYol = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName;
            resimYol += "/Image";
            if (!Directory.Exists(resimYol))
            {
                Directory.CreateDirectory(resimYol);
            }//proje .alışınca proje klasörüne image klasörü oluştur.
            foreach (var item in groupBoxArac.Controls)
            {
                if (item is ComboBox)
                {
                    (item as ComboBox).DropDownStyle = ComboBoxStyle.DropDownList;
                    //Dropdowmn özelliğini kullanmak için as ile tip dönüşümü yapmak zorundayım.
                }
            }
            openFileDialog1.InitialDirectory = Application.ExecutablePath;
            pictureBox1.SizeMode=PictureBoxSizeMode.StretchImage;
            buttonAracRengi.TextAlign = ContentAlignment.BottomLeft;//butonların metni alt ve sola yaslı olsun.
            colorDialog1.FullOpen = true;
            numericUpDownModel.Minimum = 2005;
            numericUpDownModel.Maximum =DateTime.Now.Year;
            numericUpDownMgücü.Minimum = 1000;
            numericUpDownMgücü.Maximum = 5000;
            numericUpDownMgücü.Increment = 100;//değeri 100 100 arttırsın
            EnumYukle(Enum.GetNames(typeof(AracTuru)),comboBoxatur);
            EnumYukle(Enum.GetNames(typeof(Marka)), comboBoxamarka);
            EnumYukle(Enum.GetNames(typeof(Model)), comboBoxamodel);
            EnumYukle(Enum.GetNames(typeof(SanzimanTuru)), comboBoxSanzıman);
            EnumYukle(Enum.GetNames(typeof(YakitTuru)), comboBoxYakit);
            EnumYukle(Enum.GetNames(typeof(KasaTipi)), comboBoxKasa);

        }

        private void EnumYukle(string[] Enums,ComboBox c)
        {
            c.Items.AddRange(Enums);
            c.SelectedIndex = 0;
        }

        private void buttonAracRengi_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            labelrenk.BackColor = colorDialog1.Color;
        }

        private void buttonResmi_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void buttonolustur_Click(object sender, EventArgs e)
        {
            AracGalerisi arac = new AracGalerisi()
            {
                AracinTuru = (AracTuru)comboBoxatur.SelectedIndex,
                isGaranti = checkBox1.Checked,
                KasaTip = (KasaTipi)comboBoxKasa.SelectedIndex,
                Markasi = (Marka)comboBoxamarka.SelectedIndex,
                Modeli = (Model)comboBoxamodel.SelectedIndex,
                ModelYili = (int)numericUpDownModel.Value,
                MotorGucu = (int)numericUpDownMgücü.Value,
                Renk = labelrenk.BackColor,
            Sanzimani=(SanzimanTuru)comboBoxSanzıman.SelectedIndex,
            YakitTipi=(YakitTuru)comboBoxYakit.SelectedIndex,
            AracResmi=pictureBox1.Image
                
            };
            listArac.Items.Add(arac);
           
        }
        private void Temizle()
        {
            comboBoxatur.SelectedIndex = 0;
            comboBoxamarka.SelectedIndex = 0;
            comboBoxamodel.SelectedIndex = 0;
            comboBoxSanzıman.SelectedIndex = 0;
            comboBoxYakit.SelectedIndex = 0;
            comboBoxKasa.SelectedIndex = 0;
            numericUpDownModel.Value = 2005;
            numericUpDownMgücü.Value = 1000;
            buttonResim.BackgroundImage = null;
            labelrenk.BackColor= Color.White;
            pictureBox1.Image = null;


        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            checkBox1.Text = checkBox1.Checked ? "Garantisi var" : "Garantisi Yok";
        }

        private void listArac_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listArac.SelectedIndex!=-1)
            {
                AracDoldur();
            }
        }

        private void AracDoldur()
        {
            AracGalerisi secilen = (AracGalerisi)listArac.SelectedItem;

            comboBoxatur.SelectedIndex =(int) secilen.AracinTuru;
            checkBox1.Checked = secilen.isGaranti;
            comboBoxKasa.SelectedIndex = (int)secilen.KasaTip;
            comboBoxamarka.SelectedIndex = (int)secilen.Markasi;
            comboBoxamodel.SelectedIndex = (int)secilen.Modeli;
            numericUpDownModel.Value = secilen.ModelYili;
            numericUpDownMgücü.Value = secilen.MotorGucu;
            labelrenk.BackColor = secilen.Renk;
            comboBoxSanzıman.SelectedIndex = (int)secilen.Sanzimani;
            comboBoxYakit.SelectedIndex = (int)secilen.YakitTipi;
            pictureBox1.Image = buttonResmi.BackgroundImage = secilen.AracResmi;

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            Image resim=Image.FromFile(openFileDialog1.FileName);
            pictureBox1.Image=buttonResim.BackgroundImage=resim;
        }

        private void listArac_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Delete)
            { listArac.Items.Remove(listArac.SelectedItem); }
           
            Temizle();

        }

        private void buttonResim_DragEnter(object sender, DragEventArgs e)
        {
            object suruklenen = e.Data.GetData(DataFormats.FileDrop);
            //Allow drop kısmını true yapmamız lazım yoksa sürükleyince gelmez
            try
            {
                Image resim = Image.FromFile(((string[])suruklenen)[0]);//sürüklenen resmin adres bilgisi aldım
                pictureBox1.Image = buttonResim.BackgroundImage = resim;

            }
            catch (Exception)
            {

                MessageBox.Show("sadece resim yükleyiniz");
            }
            
        }

       
    }
}
