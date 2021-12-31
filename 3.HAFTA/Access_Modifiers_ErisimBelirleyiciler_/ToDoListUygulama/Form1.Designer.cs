namespace ToDoListUygulama
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonKapat = new System.Windows.Forms.Button();
            this.buttonKayitliste = new System.Windows.Forms.Button();
            this.buttonYenikayit = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelZaman = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 431);
            this.panel1.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonKapat);
            this.groupBox1.Controls.Add(this.buttonKayitliste);
            this.groupBox1.Controls.Add(this.buttonYenikayit);
            this.groupBox1.Location = new System.Drawing.Point(3, 143);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(183, 276);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "İşlem Listesi";
            // 
            // buttonKapat
            // 
            this.buttonKapat.Location = new System.Drawing.Point(9, 87);
            this.buttonKapat.Name = "buttonKapat";
            this.buttonKapat.Size = new System.Drawing.Size(168, 23);
            this.buttonKapat.TabIndex = 0;
            this.buttonKapat.Text = "Uygulama Kapat";
            this.buttonKapat.UseVisualStyleBackColor = true;
            this.buttonKapat.Click += new System.EventHandler(this.buttonKapat_Click);
            // 
            // buttonKayitliste
            // 
            this.buttonKayitliste.Location = new System.Drawing.Point(9, 58);
            this.buttonKayitliste.Name = "buttonKayitliste";
            this.buttonKayitliste.Size = new System.Drawing.Size(168, 23);
            this.buttonKayitliste.TabIndex = 0;
            this.buttonKayitliste.Text = "Kayıt Liste";
            this.buttonKayitliste.UseVisualStyleBackColor = true;
            this.buttonKayitliste.Click += new System.EventHandler(this.buttonKayitliste_Click);
            // 
            // buttonYenikayit
            // 
            this.buttonYenikayit.Location = new System.Drawing.Point(9, 29);
            this.buttonYenikayit.Name = "buttonYenikayit";
            this.buttonYenikayit.Size = new System.Drawing.Size(168, 23);
            this.buttonYenikayit.TabIndex = 0;
            this.buttonYenikayit.Text = "Yeni Kayıt";
            this.buttonYenikayit.UseVisualStyleBackColor = true;
            this.buttonYenikayit.Click += new System.EventHandler(this.buttonYenikayit_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.labelZaman);
            this.panel2.Location = new System.Drawing.Point(471, 357);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 74);
            this.panel2.TabIndex = 2;
            // 
            // labelZaman
            // 
            this.labelZaman.AutoSize = true;
            this.labelZaman.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelZaman.Location = new System.Drawing.Point(23, 19);
            this.labelZaman.Name = "labelZaman";
            this.labelZaman.Size = new System.Drawing.Size(167, 25);
            this.labelZaman.TabIndex = 3;
            this.labelZaman.Text = "28/12/2021 11:40";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ToDoListUygulama.Properties.Resources.OIP;
            this.pictureBox1.Location = new System.Drawing.Point(46, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 106);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 431);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.IsMdiContainer = true;
            this.Name = "Form1";
            this.Text = "Todo-Uygulaması";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonKapat;
        private System.Windows.Forms.Button buttonKayitliste;
        private System.Windows.Forms.Button buttonYenikayit;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelZaman;
        private System.Windows.Forms.Timer timer1;
    }
}

