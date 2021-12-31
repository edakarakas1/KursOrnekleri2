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
using ToDoListUygulama.entities;

namespace ToDoListUygulama
{
    public partial class yenikayit : Form
    {
     

        public yenikayit()
        {
            InitializeComponent();
        }
        private void txtbaslik_Leave(object sender, EventArgs e)
        {
            ((TextBox)sender).BackColor = Color.White;
        }

        private void txtbaslik_Enter(object sender, EventArgs e)
        {
            ((TextBox)sender).BackColor = Color.Yellow;
        }

        private void btnYenikayit_Click(object sender, EventArgs e)
        {
            todoService todoServises = new todoService();
            int sonuc =todoServises.kayitYeni(new entities.todo()
            { 

                id = Guid.NewGuid(),
                baslik = txtbaslik.Text,
                kisaaciklama = txtkisaaciklama.Text,
                aciklama = txtaciklama.Text,
                durumAciklama = comboBoxDurum.SelectedItem.ToString(),
                onemderece = int.Parse(txtOnemDerece.Text),
                olusturmatarihi = DateTime.Now
                } );
            if (sonuc>0)
            {
                MessageBox.Show("Kayıt ekleme işlemi başarılı","Bilgilendirme",MessageBoxButtons.OK,MessageBoxIcon.Information);
                DialogResult result= MessageBox.Show("Kayıt ekleme işlemine devam etmek ister misiniz?", "Soru", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result==DialogResult.Yes)
                {
                    foreach (Control item in this.Controls)
                    {
                            if (item is TextBox)
                            {
                              ((TextBox) item).Text = string.Empty;
                            
                            }
                    }

                }
                else
                {
                    Form kayitliste = Application.OpenForms["kayitliste"];
                    if (kayitliste != null)
                    {
                        kayitliste = new kayitliste();
                        kayitliste.MdiParent = Application.OpenForms["Form1"];
                        kayitliste.Show();
                        this.Close();
                    }
                    else
                    {
                        GroupBox liste = (GroupBox)kayitliste.Controls["groupBoxListe"];
                        DataGridView grdliste = (DataGridView)liste.Controls["dataGridView1"];
                        List<todo> Guncelliste = todoServises.kayitListe();
                        grdliste.DataSource = null;
                        grdliste.DataSource = Guncelliste;
                        this.Close();
                        grdliste.Columns["id"].Visible=false;

                    }
                }
            }
            else
            {
                MessageBox.Show("Kayıt ekleme işleminde hata", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
