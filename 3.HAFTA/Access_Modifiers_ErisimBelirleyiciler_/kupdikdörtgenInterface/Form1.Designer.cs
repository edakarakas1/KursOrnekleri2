namespace kupdikdörtgenInterface
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnKup = new System.Windows.Forms.Button();
            this.btnDikdortgen = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(7, 10);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(391, 177);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnKup
            // 
            this.btnKup.Location = new System.Drawing.Point(71, 219);
            this.btnKup.Name = "btnKup";
            this.btnKup.Size = new System.Drawing.Size(102, 38);
            this.btnKup.TabIndex = 1;
            this.btnKup.Text = "Küp Liste";
            this.btnKup.UseVisualStyleBackColor = true;
            this.btnKup.Click += new System.EventHandler(this.btnKup_Click);
            // 
            // btnDikdortgen
            // 
            this.btnDikdortgen.Location = new System.Drawing.Point(211, 219);
            this.btnDikdortgen.Name = "btnDikdortgen";
            this.btnDikdortgen.Size = new System.Drawing.Size(102, 38);
            this.btnDikdortgen.TabIndex = 2;
            this.btnDikdortgen.Text = "Dikdörtgen Liste";
            this.btnDikdortgen.UseVisualStyleBackColor = true;
            this.btnDikdortgen.Click += new System.EventHandler(this.btnDikdortgen_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 307);
            this.Controls.Add(this.btnDikdortgen);
            this.Controls.Add(this.btnKup);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnKup;
        private System.Windows.Forms.Button btnDikdortgen;
    }
}

