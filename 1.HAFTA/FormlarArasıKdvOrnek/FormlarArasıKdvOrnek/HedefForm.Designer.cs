namespace FormlarArasıKdvOrnek
{
    partial class HedefForm
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
            this.labelAd = new System.Windows.Forms.Label();
            this.labelFiyat = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelKdvOran = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.labelKdvliFiyat = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ürün Adı";
            // 
            // labelAd
            // 
            this.labelAd.AutoSize = true;
            this.labelAd.Location = new System.Drawing.Point(126, 57);
            this.labelAd.Name = "labelAd";
            this.labelAd.Size = new System.Drawing.Size(13, 13);
            this.labelAd.TabIndex = 1;
            this.labelAd.Text = "0";
            // 
            // labelFiyat
            // 
            this.labelFiyat.AutoSize = true;
            this.labelFiyat.Location = new System.Drawing.Point(126, 103);
            this.labelFiyat.Name = "labelFiyat";
            this.labelFiyat.Size = new System.Drawing.Size(13, 13);
            this.labelFiyat.TabIndex = 3;
            this.labelFiyat.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(49, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Fiyatı";
            // 
            // labelKdvOran
            // 
            this.labelKdvOran.AutoSize = true;
            this.labelKdvOran.Location = new System.Drawing.Point(126, 143);
            this.labelKdvOran.Name = "labelKdvOran";
            this.labelKdvOran.Size = new System.Drawing.Size(13, 13);
            this.labelKdvOran.TabIndex = 5;
            this.labelKdvOran.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(49, 143);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Kdv Oran";
            // 
            // labelKdvliFiyat
            // 
            this.labelKdvliFiyat.AutoSize = true;
            this.labelKdvliFiyat.Location = new System.Drawing.Point(126, 183);
            this.labelKdvliFiyat.Name = "labelKdvliFiyat";
            this.labelKdvliFiyat.Size = new System.Drawing.Size(13, 13);
            this.labelKdvliFiyat.TabIndex = 7;
            this.labelKdvliFiyat.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(49, 183);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Kdvli Fiyat";
            // 
            // HedefForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(316, 327);
            this.Controls.Add(this.labelKdvliFiyat);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.labelKdvOran);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.labelFiyat);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelAd);
            this.Controls.Add(this.label1);
            this.Name = "HedefForm";
            this.Text = "HedefForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelAd;
        private System.Windows.Forms.Label labelFiyat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelKdvOran;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelKdvliFiyat;
        private System.Windows.Forms.Label label8;
    }
}