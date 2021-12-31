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
    public partial class kayitliste : Form
    {
        todoService todoService;
        public kayitliste()
        {
            InitializeComponent();
            todoService=new todoService();
        }

        private void kayitliste_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = TümListe();
             dataGridView1.Columns["id"].Visible=false;
        }

        private List<todo> TümListe()
        {
            return todoService.kayitListe();
        }

        private void btnTumListe_Click(object sender, EventArgs e)
        {

        }

        private void btnTamamlandi_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = TümListe().Where(x => x.durumAciklama == "Tamamlandı").ToList();
            dataGridView1.Columns["id"].Visible = false;
        }

        private void btnTamamlanamadi_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = TümListe().Where(x => x.durumAciklama == "Tamamlanmadı").ToList();
            dataGridView1.Columns["id"].Visible = false;
        }

        private void btnİptal_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = TümListe().Where(x => x.durumAciklama == "İptal Edildi").ToList();
            dataGridView1.Columns["id"].Visible = false;
        }
    }
}
