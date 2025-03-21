
namespace LojahAbc
{
    partial class frmSplash
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSplash));
            this.lblnumero = new System.Windows.Forms.Label();
            this.pgbspplash = new System.Windows.Forms.ProgressBar();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.trmsplash = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblnumero
            // 
            this.lblnumero.AutoSize = true;
            this.lblnumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnumero.Location = new System.Drawing.Point(382, 296);
            this.lblnumero.Name = "lblnumero";
            this.lblnumero.Size = new System.Drawing.Size(0, 29);
            this.lblnumero.TabIndex = 9;
            this.lblnumero.Click += new System.EventHandler(this.label1_Click);
            // 
            // pgbspplash
            // 
            this.pgbspplash.ForeColor = System.Drawing.SystemColors.Desktop;
            this.pgbspplash.Location = new System.Drawing.Point(315, 321);
            this.pgbspplash.Name = "pgbspplash";
            this.pgbspplash.Size = new System.Drawing.Size(195, 23);
            this.pgbspplash.TabIndex = 11;
            this.pgbspplash.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(124, -11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(576, 576);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // trmsplash
            // 
            this.trmsplash.Enabled = true;
            this.trmsplash.Interval = 300;
            this.trmsplash.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmSplash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(780, 557);
            this.Controls.Add(this.pgbspplash);
            this.Controls.Add(this.lblnumero);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmSplash";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LojahAbc -Splash";
            this.Load += new System.EventHandler(this.frmSplash_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblnumero;
        private System.Windows.Forms.ProgressBar pgbspplash;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer trmsplash;
    }
}