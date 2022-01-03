namespace ResimGalerisi
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnilk = new System.Windows.Forms.Button();
            this.btnOnceki = new System.Windows.Forms.Button();
            this.btnRastgele = new System.Windows.Forms.Button();
            this.btnSlayt = new System.Windows.Forms.Button();
            this.btnSonraki = new System.Windows.Forms.Button();
            this.btnEnSonraki = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(218, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(358, 244);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(200, 244);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // btnilk
            // 
            this.btnilk.Location = new System.Drawing.Point(15, 271);
            this.btnilk.Name = "btnilk";
            this.btnilk.Size = new System.Drawing.Size(75, 37);
            this.btnilk.TabIndex = 2;
            this.btnilk.Text = "<<";
            this.btnilk.UseVisualStyleBackColor = true;
            this.btnilk.Click += new System.EventHandler(this.btnilk_Click);
            // 
            // btnOnceki
            // 
            this.btnOnceki.Location = new System.Drawing.Point(96, 271);
            this.btnOnceki.Name = "btnOnceki";
            this.btnOnceki.Size = new System.Drawing.Size(75, 37);
            this.btnOnceki.TabIndex = 2;
            this.btnOnceki.Text = "<";
            this.btnOnceki.UseVisualStyleBackColor = true;
            this.btnOnceki.Click += new System.EventHandler(this.btnOnceki_Click);
            // 
            // btnRastgele
            // 
            this.btnRastgele.Location = new System.Drawing.Point(177, 271);
            this.btnRastgele.Name = "btnRastgele";
            this.btnRastgele.Size = new System.Drawing.Size(113, 37);
            this.btnRastgele.TabIndex = 2;
            this.btnRastgele.Text = "Rastgele Resimler";
            this.btnRastgele.UseVisualStyleBackColor = true;
            this.btnRastgele.Click += new System.EventHandler(this.btnRastgele_Click);
            // 
            // btnSlayt
            // 
            this.btnSlayt.Location = new System.Drawing.Point(296, 271);
            this.btnSlayt.Name = "btnSlayt";
            this.btnSlayt.Size = new System.Drawing.Size(113, 37);
            this.btnSlayt.TabIndex = 2;
            this.btnSlayt.Text = "Slayt Gösterisi";
            this.btnSlayt.UseVisualStyleBackColor = true;
            this.btnSlayt.Click += new System.EventHandler(this.btnSlayt_Click);
            // 
            // btnSonraki
            // 
            this.btnSonraki.Location = new System.Drawing.Point(415, 271);
            this.btnSonraki.Name = "btnSonraki";
            this.btnSonraki.Size = new System.Drawing.Size(75, 37);
            this.btnSonraki.TabIndex = 2;
            this.btnSonraki.Text = ">";
            this.btnSonraki.UseVisualStyleBackColor = true;
            this.btnSonraki.Click += new System.EventHandler(this.btnSonraki_Click);
            // 
            // btnEnSonraki
            // 
            this.btnEnSonraki.Location = new System.Drawing.Point(496, 271);
            this.btnEnSonraki.Name = "btnEnSonraki";
            this.btnEnSonraki.Size = new System.Drawing.Size(75, 37);
            this.btnEnSonraki.TabIndex = 2;
            this.btnEnSonraki.Text = ">>";
            this.btnEnSonraki.UseVisualStyleBackColor = true;
            this.btnEnSonraki.Click += new System.EventHandler(this.btnEnSonraki_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(596, 333);
            this.Controls.Add(this.btnSlayt);
            this.Controls.Add(this.btnRastgele);
            this.Controls.Add(this.btnEnSonraki);
            this.Controls.Add(this.btnSonraki);
            this.Controls.Add(this.btnOnceki);
            this.Controls.Add(this.btnilk);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnilk;
        private System.Windows.Forms.Button btnOnceki;
        private System.Windows.Forms.Button btnRastgele;
        private System.Windows.Forms.Button btnSlayt;
        private System.Windows.Forms.Button btnSonraki;
        private System.Windows.Forms.Button btnEnSonraki;
    }
}

