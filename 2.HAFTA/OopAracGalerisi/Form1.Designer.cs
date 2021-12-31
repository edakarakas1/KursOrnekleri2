namespace OopAracGalerisi
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
            this.groupBoxArac = new System.Windows.Forms.GroupBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.buttonResim = new System.Windows.Forms.Button();
            this.buttonolustur = new System.Windows.Forms.Button();
            this.buttonResmi = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.numericUpDownMgücü = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.numericUpDownModel = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.labelrenk = new System.Windows.Forms.Label();
            this.buttonAracRengi = new System.Windows.Forms.Button();
            this.comboBoxKasa = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBoxYakit = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxSanzıman = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxamodel = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxamarka = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxatur = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listArac = new System.Windows.Forms.ListBox();
            this.label10 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBoxArac.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMgücü)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownModel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxArac
            // 
            this.groupBoxArac.Controls.Add(this.checkBox1);
            this.groupBoxArac.Controls.Add(this.buttonResim);
            this.groupBoxArac.Controls.Add(this.buttonolustur);
            this.groupBoxArac.Controls.Add(this.buttonResmi);
            this.groupBoxArac.Controls.Add(this.label9);
            this.groupBoxArac.Controls.Add(this.numericUpDownMgücü);
            this.groupBoxArac.Controls.Add(this.label8);
            this.groupBoxArac.Controls.Add(this.numericUpDownModel);
            this.groupBoxArac.Controls.Add(this.label7);
            this.groupBoxArac.Controls.Add(this.labelrenk);
            this.groupBoxArac.Controls.Add(this.buttonAracRengi);
            this.groupBoxArac.Controls.Add(this.comboBoxKasa);
            this.groupBoxArac.Controls.Add(this.label6);
            this.groupBoxArac.Controls.Add(this.comboBoxYakit);
            this.groupBoxArac.Controls.Add(this.label5);
            this.groupBoxArac.Controls.Add(this.comboBoxSanzıman);
            this.groupBoxArac.Controls.Add(this.label4);
            this.groupBoxArac.Controls.Add(this.comboBoxamodel);
            this.groupBoxArac.Controls.Add(this.label3);
            this.groupBoxArac.Controls.Add(this.comboBoxamarka);
            this.groupBoxArac.Controls.Add(this.label2);
            this.groupBoxArac.Controls.Add(this.comboBoxatur);
            this.groupBoxArac.Controls.Add(this.label1);
            this.groupBoxArac.Location = new System.Drawing.Point(12, 12);
            this.groupBoxArac.Name = "groupBoxArac";
            this.groupBoxArac.Size = new System.Drawing.Size(296, 592);
            this.groupBoxArac.TabIndex = 0;
            this.groupBoxArac.TabStop = false;
            this.groupBoxArac.Text = "Araçlar";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(143, 351);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(86, 17);
            this.checkBox1.TabIndex = 22;
            this.checkBox1.Text = "Garantisi Var";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // buttonResim
            // 
            this.buttonResim.AllowDrop = true;
            this.buttonResim.Location = new System.Drawing.Point(18, 418);
            this.buttonResim.Name = "buttonResim";
            this.buttonResim.Size = new System.Drawing.Size(259, 168);
            this.buttonResim.TabIndex = 21;
            this.buttonResim.UseVisualStyleBackColor = true;
            this.buttonResim.DragEnter += new System.Windows.Forms.DragEventHandler(this.buttonResim_DragEnter);
            // 
            // buttonolustur
            // 
            this.buttonolustur.Location = new System.Drawing.Point(180, 379);
            this.buttonolustur.Name = "buttonolustur";
            this.buttonolustur.Size = new System.Drawing.Size(97, 23);
            this.buttonolustur.TabIndex = 20;
            this.buttonolustur.Text = "Oluştur";
            this.buttonolustur.UseVisualStyleBackColor = true;
            this.buttonolustur.Click += new System.EventHandler(this.buttonolustur_Click);
            // 
            // buttonResmi
            // 
            this.buttonResmi.Location = new System.Drawing.Point(18, 379);
            this.buttonResmi.Name = "buttonResmi";
            this.buttonResmi.Size = new System.Drawing.Size(97, 23);
            this.buttonResmi.TabIndex = 19;
            this.buttonResmi.Text = "Aracın Resmi";
            this.buttonResmi.UseVisualStyleBackColor = true;
            this.buttonResmi.Click += new System.EventHandler(this.buttonResmi_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(15, 352);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Garanti Durumu";
            // 
            // numericUpDownMgücü
            // 
            this.numericUpDownMgücü.Location = new System.Drawing.Point(220, 311);
            this.numericUpDownMgücü.Name = "numericUpDownMgücü";
            this.numericUpDownMgücü.Size = new System.Drawing.Size(57, 20);
            this.numericUpDownMgücü.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(160, 313);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Motor Gücü";
            // 
            // numericUpDownModel
            // 
            this.numericUpDownModel.Location = new System.Drawing.Point(58, 311);
            this.numericUpDownModel.Name = "numericUpDownModel";
            this.numericUpDownModel.Size = new System.Drawing.Size(57, 20);
            this.numericUpDownModel.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 313);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Model";
            // 
            // labelrenk
            // 
            this.labelrenk.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelrenk.Location = new System.Drawing.Point(129, 266);
            this.labelrenk.Name = "labelrenk";
            this.labelrenk.Size = new System.Drawing.Size(148, 21);
            this.labelrenk.TabIndex = 13;
            // 
            // buttonAracRengi
            // 
            this.buttonAracRengi.Location = new System.Drawing.Point(18, 266);
            this.buttonAracRengi.Name = "buttonAracRengi";
            this.buttonAracRengi.Size = new System.Drawing.Size(97, 23);
            this.buttonAracRengi.TabIndex = 12;
            this.buttonAracRengi.Text = "Aracın Rengi";
            this.buttonAracRengi.UseVisualStyleBackColor = true;
            this.buttonAracRengi.Click += new System.EventHandler(this.buttonAracRengi_Click);
            // 
            // comboBoxKasa
            // 
            this.comboBoxKasa.FormattingEnabled = true;
            this.comboBoxKasa.Location = new System.Drawing.Point(94, 227);
            this.comboBoxKasa.Name = "comboBoxKasa";
            this.comboBoxKasa.Size = new System.Drawing.Size(183, 21);
            this.comboBoxKasa.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 227);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Kasa Tipi";
            // 
            // comboBoxYakit
            // 
            this.comboBoxYakit.FormattingEnabled = true;
            this.comboBoxYakit.Location = new System.Drawing.Point(94, 191);
            this.comboBoxYakit.Name = "comboBoxYakit";
            this.comboBoxYakit.Size = new System.Drawing.Size(183, 21);
            this.comboBoxYakit.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 191);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Yakıt Türü";
            // 
            // comboBoxSanzıman
            // 
            this.comboBoxSanzıman.FormattingEnabled = true;
            this.comboBoxSanzıman.Location = new System.Drawing.Point(94, 154);
            this.comboBoxSanzıman.Name = "comboBoxSanzıman";
            this.comboBoxSanzıman.Size = new System.Drawing.Size(183, 21);
            this.comboBoxSanzıman.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Şanzıman Türü";
            // 
            // comboBoxamodel
            // 
            this.comboBoxamodel.FormattingEnabled = true;
            this.comboBoxamodel.Location = new System.Drawing.Point(94, 113);
            this.comboBoxamodel.Name = "comboBoxamodel";
            this.comboBoxamodel.Size = new System.Drawing.Size(183, 21);
            this.comboBoxamodel.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Aracın Modeli";
            // 
            // comboBoxamarka
            // 
            this.comboBoxamarka.FormattingEnabled = true;
            this.comboBoxamarka.Location = new System.Drawing.Point(94, 76);
            this.comboBoxamarka.Name = "comboBoxamarka";
            this.comboBoxamarka.Size = new System.Drawing.Size(183, 21);
            this.comboBoxamarka.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Aracın Markası";
            // 
            // comboBoxatur
            // 
            this.comboBoxatur.FormattingEnabled = true;
            this.comboBoxatur.Location = new System.Drawing.Point(94, 38);
            this.comboBoxatur.Name = "comboBoxatur";
            this.comboBoxatur.Size = new System.Drawing.Size(183, 21);
            this.comboBoxatur.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Araç Türü";
            // 
            // listArac
            // 
            this.listArac.FormattingEnabled = true;
            this.listArac.Location = new System.Drawing.Point(314, 36);
            this.listArac.Name = "listArac";
            this.listArac.Size = new System.Drawing.Size(177, 446);
            this.listArac.TabIndex = 1;
            this.listArac.SelectedIndexChanged += new System.EventHandler(this.listArac_SelectedIndexChanged);
            this.listArac.KeyDown += new System.Windows.Forms.KeyEventHandler(this.listArac_KeyDown);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(322, 22);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 13);
            this.label10.TabIndex = 23;
            this.label10.Text = "Arac İncele";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(506, 36);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(459, 446);
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(977, 611);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.listArac);
            this.Controls.Add(this.groupBoxArac);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxArac.ResumeLayout(false);
            this.groupBoxArac.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMgücü)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownModel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxArac;
        private System.Windows.Forms.Label labelrenk;
        private System.Windows.Forms.Button buttonAracRengi;
        private System.Windows.Forms.ComboBox comboBoxKasa;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBoxYakit;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxSanzıman;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxamodel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxamarka;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxatur;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button buttonResim;
        private System.Windows.Forms.Button buttonolustur;
        private System.Windows.Forms.Button buttonResmi;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown numericUpDownMgücü;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown numericUpDownModel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox listArac;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

