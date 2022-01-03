namespace Hamburger
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1Menü = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.radioButton1Orta = new System.Windows.Forms.RadioButton();
            this.radioButton1Buyuk = new System.Windows.Forms.RadioButton();
            this.radioButton1King = new System.Windows.Forms.RadioButton();
            this.groupBox1Ekstra = new System.Windows.Forms.GroupBox();
            this.checkBox1sogan = new System.Windows.Forms.CheckBox();
            this.checkBox2peynir = new System.Windows.Forms.CheckBox();
            this.checkBox3ketcap = new System.Windows.Forms.CheckBox();
            this.checkBox4domates = new System.Windows.Forms.CheckBox();
            this.checkBox5tursu = new System.Windows.Forms.CheckBox();
            this.checkBox6mayonez = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnSiparis = new System.Windows.Forms.Button();
            this.btnHesap = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1Ekstra.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Hamburger.Properties.Resources.hamburger;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(292, 208);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 236);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Menü";
            // 
            // comboBox1Menü
            // 
            this.comboBox1Menü.FormattingEnabled = true;
            this.comboBox1Menü.Items.AddRange(new object[] {
            "Hamburger (20.00 TL)",
            "Cheese Burger (24.00 TL)",
            ""});
            this.comboBox1Menü.Location = new System.Drawing.Point(93, 233);
            this.comboBox1Menü.Name = "comboBox1Menü";
            this.comboBox1Menü.Size = new System.Drawing.Size(121, 21);
            this.comboBox1Menü.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 283);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Boyut";
            // 
            // radioButton1Orta
            // 
            this.radioButton1Orta.AutoSize = true;
            this.radioButton1Orta.Location = new System.Drawing.Point(93, 283);
            this.radioButton1Orta.Name = "radioButton1Orta";
            this.radioButton1Orta.Size = new System.Drawing.Size(45, 17);
            this.radioButton1Orta.TabIndex = 3;
            this.radioButton1Orta.TabStop = true;
            this.radioButton1Orta.Text = "Orta";
            this.radioButton1Orta.UseVisualStyleBackColor = true;
            // 
            // radioButton1Buyuk
            // 
            this.radioButton1Buyuk.AutoSize = true;
            this.radioButton1Buyuk.Location = new System.Drawing.Point(156, 283);
            this.radioButton1Buyuk.Name = "radioButton1Buyuk";
            this.radioButton1Buyuk.Size = new System.Drawing.Size(55, 17);
            this.radioButton1Buyuk.TabIndex = 3;
            this.radioButton1Buyuk.TabStop = true;
            this.radioButton1Buyuk.Text = "Büyük";
            this.radioButton1Buyuk.UseVisualStyleBackColor = true;
            // 
            // radioButton1King
            // 
            this.radioButton1King.AutoSize = true;
            this.radioButton1King.Location = new System.Drawing.Point(217, 283);
            this.radioButton1King.Name = "radioButton1King";
            this.radioButton1King.Size = new System.Drawing.Size(46, 17);
            this.radioButton1King.TabIndex = 3;
            this.radioButton1King.TabStop = true;
            this.radioButton1King.Text = "King";
            this.radioButton1King.UseVisualStyleBackColor = true;
            // 
            // groupBox1Ekstra
            // 
            this.groupBox1Ekstra.Controls.Add(this.checkBox4domates);
            this.groupBox1Ekstra.Controls.Add(this.checkBox5tursu);
            this.groupBox1Ekstra.Controls.Add(this.checkBox6mayonez);
            this.groupBox1Ekstra.Controls.Add(this.checkBox3ketcap);
            this.groupBox1Ekstra.Controls.Add(this.checkBox2peynir);
            this.groupBox1Ekstra.Controls.Add(this.checkBox1sogan);
            this.groupBox1Ekstra.Location = new System.Drawing.Point(23, 317);
            this.groupBox1Ekstra.Name = "groupBox1Ekstra";
            this.groupBox1Ekstra.Size = new System.Drawing.Size(281, 135);
            this.groupBox1Ekstra.TabIndex = 4;
            this.groupBox1Ekstra.TabStop = false;
            this.groupBox1Ekstra.Text = "Ekstralar";
            // 
            // checkBox1sogan
            // 
            this.checkBox1sogan.AutoSize = true;
            this.checkBox1sogan.Location = new System.Drawing.Point(11, 30);
            this.checkBox1sogan.Name = "checkBox1sogan";
            this.checkBox1sogan.Size = new System.Drawing.Size(57, 17);
            this.checkBox1sogan.TabIndex = 0;
            this.checkBox1sogan.Text = "Soğan";
            this.checkBox1sogan.UseVisualStyleBackColor = true;
            // 
            // checkBox2peynir
            // 
            this.checkBox2peynir.AutoSize = true;
            this.checkBox2peynir.Location = new System.Drawing.Point(133, 30);
            this.checkBox2peynir.Name = "checkBox2peynir";
            this.checkBox2peynir.Size = new System.Drawing.Size(55, 17);
            this.checkBox2peynir.TabIndex = 0;
            this.checkBox2peynir.Text = "Peynir";
            this.checkBox2peynir.UseVisualStyleBackColor = true;
            // 
            // checkBox3ketcap
            // 
            this.checkBox3ketcap.AutoSize = true;
            this.checkBox3ketcap.Location = new System.Drawing.Point(133, 68);
            this.checkBox3ketcap.Name = "checkBox3ketcap";
            this.checkBox3ketcap.Size = new System.Drawing.Size(60, 17);
            this.checkBox3ketcap.TabIndex = 0;
            this.checkBox3ketcap.Text = "Ketçap";
            this.checkBox3ketcap.UseVisualStyleBackColor = true;
            // 
            // checkBox4domates
            // 
            this.checkBox4domates.AutoSize = true;
            this.checkBox4domates.Location = new System.Drawing.Point(11, 68);
            this.checkBox4domates.Name = "checkBox4domates";
            this.checkBox4domates.Size = new System.Drawing.Size(68, 17);
            this.checkBox4domates.TabIndex = 0;
            this.checkBox4domates.Text = "Domates";
            this.checkBox4domates.UseVisualStyleBackColor = true;
            // 
            // checkBox5tursu
            // 
            this.checkBox5tursu.AutoSize = true;
            this.checkBox5tursu.Location = new System.Drawing.Point(11, 104);
            this.checkBox5tursu.Name = "checkBox5tursu";
            this.checkBox5tursu.Size = new System.Drawing.Size(53, 17);
            this.checkBox5tursu.TabIndex = 0;
            this.checkBox5tursu.Text = "Turşu";
            this.checkBox5tursu.UseVisualStyleBackColor = true;
            // 
            // checkBox6mayonez
            // 
            this.checkBox6mayonez.AutoSize = true;
            this.checkBox6mayonez.Location = new System.Drawing.Point(133, 104);
            this.checkBox6mayonez.Name = "checkBox6mayonez";
            this.checkBox6mayonez.Size = new System.Drawing.Size(69, 17);
            this.checkBox6mayonez.TabIndex = 0;
            this.checkBox6mayonez.Text = "Mayonez";
            this.checkBox6mayonez.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 474);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Adet";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(57, 472);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 5;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 512);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(315, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Büyük Menü Farkı 2 TL. King Menü Farkı 4 TL. Ekstralar 0.50 Krş";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(329, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(403, 342);
            this.listBox1.TabIndex = 6;
            // 
            // btnSiparis
            // 
            this.btnSiparis.Location = new System.Drawing.Point(380, 385);
            this.btnSiparis.Name = "btnSiparis";
            this.btnSiparis.Size = new System.Drawing.Size(115, 53);
            this.btnSiparis.TabIndex = 7;
            this.btnSiparis.Text = "Sipariş Al";
            this.btnSiparis.UseVisualStyleBackColor = true;
            this.btnSiparis.Click += new System.EventHandler(this.btnSiparis_Click);
            // 
            // btnHesap
            // 
            this.btnHesap.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnHesap.Location = new System.Drawing.Point(553, 385);
            this.btnHesap.Name = "btnHesap";
            this.btnHesap.Size = new System.Drawing.Size(115, 53);
            this.btnHesap.TabIndex = 7;
            this.btnHesap.Text = "Hesap";
            this.btnHesap.UseVisualStyleBackColor = true;
            this.btnHesap.Click += new System.EventHandler(this.btnHesap_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(761, 549);
            this.Controls.Add(this.btnHesap);
            this.Controls.Add(this.btnSiparis);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.groupBox1Ekstra);
            this.Controls.Add(this.radioButton1King);
            this.Controls.Add(this.radioButton1Buyuk);
            this.Controls.Add(this.radioButton1Orta);
            this.Controls.Add(this.comboBox1Menü);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1Ekstra.ResumeLayout(false);
            this.groupBox1Ekstra.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1Menü;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton radioButton1Orta;
        private System.Windows.Forms.RadioButton radioButton1Buyuk;
        private System.Windows.Forms.RadioButton radioButton1King;
        private System.Windows.Forms.GroupBox groupBox1Ekstra;
        private System.Windows.Forms.CheckBox checkBox4domates;
        private System.Windows.Forms.CheckBox checkBox5tursu;
        private System.Windows.Forms.CheckBox checkBox6mayonez;
        private System.Windows.Forms.CheckBox checkBox3ketcap;
        private System.Windows.Forms.CheckBox checkBox2peynir;
        private System.Windows.Forms.CheckBox checkBox1sogan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnSiparis;
        private System.Windows.Forms.Button btnHesap;
    }
}

