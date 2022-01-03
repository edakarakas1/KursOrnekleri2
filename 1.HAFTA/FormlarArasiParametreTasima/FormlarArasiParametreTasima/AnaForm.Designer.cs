namespace FormlarArasiParametreTasima
{
    partial class AnaForm
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
            this.txt = new System.Windows.Forms.TextBox();
            this.button1Gonder = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt
            // 
            this.txt.Location = new System.Drawing.Point(45, 85);
            this.txt.Name = "txt";
            this.txt.Size = new System.Drawing.Size(100, 20);
            this.txt.TabIndex = 0;
            // 
            // button1Gonder
            // 
            this.button1Gonder.Location = new System.Drawing.Point(192, 85);
            this.button1Gonder.Name = "button1Gonder";
            this.button1Gonder.Size = new System.Drawing.Size(75, 23);
            this.button1Gonder.TabIndex = 1;
            this.button1Gonder.Text = "Gönder";
            this.button1Gonder.UseVisualStyleBackColor = true;
            this.button1Gonder.Click += new System.EventHandler(this.button1Gonder_Click);
            // 
            // AnaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 230);
            this.Controls.Add(this.button1Gonder);
            this.Controls.Add(this.txt);
            this.Name = "AnaForm";
            this.Text = "AnaForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt;
        private System.Windows.Forms.Button button1Gonder;
    }
}

