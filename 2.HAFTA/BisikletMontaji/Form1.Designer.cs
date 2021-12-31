namespace BisikletMontaji
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
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxFren = new System.Windows.Forms.ComboBox();
            this.comboBoxkadro = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePickerModelyil = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonClassGndr = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fren Tipi";
            // 
            // comboBoxFren
            // 
            this.comboBoxFren.FormattingEnabled = true;
            this.comboBoxFren.Location = new System.Drawing.Point(110, 71);
            this.comboBoxFren.Name = "comboBoxFren";
            this.comboBoxFren.Size = new System.Drawing.Size(121, 21);
            this.comboBoxFren.TabIndex = 1;
            // 
            // comboBoxkadro
            // 
            this.comboBoxkadro.FormattingEnabled = true;
            this.comboBoxkadro.Location = new System.Drawing.Point(110, 124);
            this.comboBoxkadro.Name = "comboBoxkadro";
            this.comboBoxkadro.Size = new System.Drawing.Size(121, 21);
            this.comboBoxkadro.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Kadro Tipi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Model Yılı";
            // 
            // dateTimePickerModelyil
            // 
            this.dateTimePickerModelyil.Location = new System.Drawing.Point(110, 167);
            this.dateTimePickerModelyil.MaxDate = new System.DateTime(2021, 12, 23, 0, 0, 0, 0);
            this.dateTimePickerModelyil.Name = "dateTimePickerModelyil";
            this.dateTimePickerModelyil.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerModelyil.TabIndex = 4;
            this.dateTimePickerModelyil.Value = new System.DateTime(2021, 12, 23, 0, 0, 0, 0);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 215);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Yaşı";
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(110, 207);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(121, 20);
            this.textBox1.TabIndex = 5;
            // 
            // buttonClassGndr
            // 
            this.buttonClassGndr.Location = new System.Drawing.Point(190, 272);
            this.buttonClassGndr.Name = "buttonClassGndr";
            this.buttonClassGndr.Size = new System.Drawing.Size(90, 36);
            this.buttonClassGndr.TabIndex = 6;
            this.buttonClassGndr.Text = "Classa Gönder";
            this.buttonClassGndr.UseVisualStyleBackColor = true;
            this.buttonClassGndr.Click += new System.EventHandler(this.buttonClassGndr_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 354);
            this.Controls.Add(this.buttonClassGndr);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dateTimePickerModelyil);
            this.Controls.Add(this.comboBoxkadro);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxFren);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxFren;
        private System.Windows.Forms.ComboBox comboBoxkadro;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePickerModelyil;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonClassGndr;
    }
}

