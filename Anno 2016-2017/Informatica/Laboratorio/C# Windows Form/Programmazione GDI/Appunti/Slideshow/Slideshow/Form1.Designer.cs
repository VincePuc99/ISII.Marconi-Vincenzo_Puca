namespace Slideshow
{
    partial class frmMain
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
            this.pctFiori = new System.Windows.Forms.PictureBox();
            this.btnIndietro = new System.Windows.Forms.Button();
            this.btnAvanti = new System.Windows.Forms.Button();
            this.btnAutoRiproduzione = new System.Windows.Forms.Button();
            this.tmr = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pctFiori)).BeginInit();
            this.SuspendLayout();
            // 
            // pctFiori
            // 
            this.pctFiori.Location = new System.Drawing.Point(39, 12);
            this.pctFiori.Name = "pctFiori";
            this.pctFiori.Size = new System.Drawing.Size(676, 459);
            this.pctFiori.TabIndex = 0;
            this.pctFiori.TabStop = false;
            this.pctFiori.Click += new System.EventHandler(this.pcbFiori_Click);
            this.pctFiori.MouseLeave += new System.EventHandler(this.pctFiori_MouseLeave);
            this.pctFiori.MouseHover += new System.EventHandler(this.pctFiori_MouseHover);
            // 
            // btnIndietro
            // 
            this.btnIndietro.Location = new System.Drawing.Point(13, 12);
            this.btnIndietro.Name = "btnIndietro";
            this.btnIndietro.Size = new System.Drawing.Size(20, 459);
            this.btnIndietro.TabIndex = 1;
            this.btnIndietro.Text = "<";
            this.btnIndietro.UseVisualStyleBackColor = true;
            this.btnIndietro.Click += new System.EventHandler(this.btnIndietro_Click);
            // 
            // btnAvanti
            // 
            this.btnAvanti.Location = new System.Drawing.Point(721, 12);
            this.btnAvanti.Name = "btnAvanti";
            this.btnAvanti.Size = new System.Drawing.Size(20, 459);
            this.btnAvanti.TabIndex = 2;
            this.btnAvanti.Text = ">";
            this.btnAvanti.UseVisualStyleBackColor = true;
            this.btnAvanti.Click += new System.EventHandler(this.btnAvanti_Click);
            // 
            // btnAutoRiproduzione
            // 
            this.btnAutoRiproduzione.Location = new System.Drawing.Point(12, 476);
            this.btnAutoRiproduzione.Name = "btnAutoRiproduzione";
            this.btnAutoRiproduzione.Size = new System.Drawing.Size(729, 23);
            this.btnAutoRiproduzione.TabIndex = 3;
            this.btnAutoRiproduzione.Text = "AUTO RIPRODUZIONE";
            this.btnAutoRiproduzione.UseVisualStyleBackColor = true;
            this.btnAutoRiproduzione.Click += new System.EventHandler(this.btnAutoRiproduzione_Click);
            // 
            // tmr
            // 
            this.tmr.Interval = 500;
            this.tmr.Tick += new System.EventHandler(this.tmr_Tick);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 508);
            this.Controls.Add(this.btnAutoRiproduzione);
            this.Controls.Add(this.btnAvanti);
            this.Controls.Add(this.btnIndietro);
            this.Controls.Add(this.pctFiori);
            this.Name = "frmMain";
            this.Text = "Pictures";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pctFiori)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pctFiori;
        private System.Windows.Forms.Button btnIndietro;
        private System.Windows.Forms.Button btnAvanti;
        private System.Windows.Forms.Button btnAutoRiproduzione;
        private System.Windows.Forms.Timer tmr;
    }
}

