namespace ToDoListUygulama
{
    partial class kayitliste
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1İslemListe = new System.Windows.Forms.GroupBox();
            this.btnİptal = new System.Windows.Forms.Button();
            this.btnTamamlanamadi = new System.Windows.Forms.Button();
            this.btnTamamlandi = new System.Windows.Forms.Button();
            this.btnTumListe = new System.Windows.Forms.Button();
            this.groupBox2Liste = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1İslemListe.SuspendLayout();
            this.groupBox2Liste.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1İslemListe
            // 
            this.groupBox1İslemListe.Controls.Add(this.btnİptal);
            this.groupBox1İslemListe.Controls.Add(this.btnTamamlanamadi);
            this.groupBox1İslemListe.Controls.Add(this.btnTamamlandi);
            this.groupBox1İslemListe.Controls.Add(this.btnTumListe);
            this.groupBox1İslemListe.Location = new System.Drawing.Point(12, 12);
            this.groupBox1İslemListe.Name = "groupBox1İslemListe";
            this.groupBox1İslemListe.Size = new System.Drawing.Size(125, 299);
            this.groupBox1İslemListe.TabIndex = 0;
            this.groupBox1İslemListe.TabStop = false;
            this.groupBox1İslemListe.Text = "İşlem Listesi";
            // 
            // btnİptal
            // 
            this.btnİptal.Location = new System.Drawing.Point(6, 116);
            this.btnİptal.Name = "btnİptal";
            this.btnİptal.Size = new System.Drawing.Size(102, 23);
            this.btnİptal.TabIndex = 0;
            this.btnİptal.Text = "İptal";
            this.btnİptal.UseVisualStyleBackColor = true;
            this.btnİptal.Click += new System.EventHandler(this.btnİptal_Click);
            // 
            // btnTamamlanamadi
            // 
            this.btnTamamlanamadi.Location = new System.Drawing.Point(6, 87);
            this.btnTamamlanamadi.Name = "btnTamamlanamadi";
            this.btnTamamlanamadi.Size = new System.Drawing.Size(102, 23);
            this.btnTamamlanamadi.TabIndex = 0;
            this.btnTamamlanamadi.Text = "Tamamlanamadı";
            this.btnTamamlanamadi.UseVisualStyleBackColor = true;
            this.btnTamamlanamadi.Click += new System.EventHandler(this.btnTamamlanamadi_Click);
            // 
            // btnTamamlandi
            // 
            this.btnTamamlandi.Location = new System.Drawing.Point(6, 58);
            this.btnTamamlandi.Name = "btnTamamlandi";
            this.btnTamamlandi.Size = new System.Drawing.Size(102, 23);
            this.btnTamamlandi.TabIndex = 0;
            this.btnTamamlandi.Text = "Tamamlandı";
            this.btnTamamlandi.UseVisualStyleBackColor = true;
            this.btnTamamlandi.Click += new System.EventHandler(this.btnTamamlandi_Click);
            // 
            // btnTumListe
            // 
            this.btnTumListe.Location = new System.Drawing.Point(6, 29);
            this.btnTumListe.Name = "btnTumListe";
            this.btnTumListe.Size = new System.Drawing.Size(102, 23);
            this.btnTumListe.TabIndex = 0;
            this.btnTumListe.Text = "Tüm Liste";
            this.btnTumListe.UseVisualStyleBackColor = true;
            this.btnTumListe.Click += new System.EventHandler(this.btnTumListe_Click);
            // 
            // groupBox2Liste
            // 
            this.groupBox2Liste.Controls.Add(this.dataGridView1);
            this.groupBox2Liste.Location = new System.Drawing.Point(143, 12);
            this.groupBox2Liste.Name = "groupBox2Liste";
            this.groupBox2Liste.Size = new System.Drawing.Size(400, 299);
            this.groupBox2Liste.TabIndex = 1;
            this.groupBox2Liste.TabStop = false;
            this.groupBox2Liste.Text = "Liste";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(388, 274);
            this.dataGridView1.TabIndex = 0;
            // 
            // kayitliste
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 324);
            this.Controls.Add(this.groupBox2Liste);
            this.Controls.Add(this.groupBox1İslemListe);
            this.Name = "kayitliste";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "kayitliste";
            this.Load += new System.EventHandler(this.kayitliste_Load);
            this.groupBox1İslemListe.ResumeLayout(false);
            this.groupBox2Liste.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1İslemListe;
        private System.Windows.Forms.GroupBox groupBox2Liste;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnİptal;
        private System.Windows.Forms.Button btnTamamlanamadi;
        private System.Windows.Forms.Button btnTamamlandi;
        private System.Windows.Forms.Button btnTumListe;
    }
}