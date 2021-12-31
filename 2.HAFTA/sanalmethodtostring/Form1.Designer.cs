namespace sanalmethodtostring
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.TextboxId = new System.Windows.Forms.TextBox();
            this.textboxAd = new System.Windows.Forms.TextBox();
            this.textboxSoyad = new System.Windows.Forms.TextBox();
            this.Tostring = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(144, 225);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(45, 256);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Oluştur";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TextboxId
            // 
            this.TextboxId.Location = new System.Drawing.Point(192, 44);
            this.TextboxId.Name = "TextboxId";
            this.TextboxId.Size = new System.Drawing.Size(100, 20);
            this.TextboxId.TabIndex = 2;
            // 
            // textboxAd
            // 
            this.textboxAd.Location = new System.Drawing.Point(192, 70);
            this.textboxAd.Name = "textboxAd";
            this.textboxAd.Size = new System.Drawing.Size(100, 20);
            this.textboxAd.TabIndex = 2;
            // 
            // textboxSoyad
            // 
            this.textboxSoyad.Location = new System.Drawing.Point(192, 96);
            this.textboxSoyad.Name = "textboxSoyad";
            this.textboxSoyad.Size = new System.Drawing.Size(100, 20);
            this.textboxSoyad.TabIndex = 2;
            // 
            // Tostring
            // 
            this.Tostring.Location = new System.Drawing.Point(192, 122);
            this.Tostring.Name = "Tostring";
            this.Tostring.Size = new System.Drawing.Size(100, 20);
            this.Tostring.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(352, 326);
            this.Controls.Add(this.Tostring);
            this.Controls.Add(this.textboxSoyad);
            this.Controls.Add(this.textboxAd);
            this.Controls.Add(this.TextboxId);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox TextboxId;
        private System.Windows.Forms.TextBox textboxAd;
        private System.Windows.Forms.TextBox textboxSoyad;
        private System.Windows.Forms.TextBox Tostring;
    }
}

