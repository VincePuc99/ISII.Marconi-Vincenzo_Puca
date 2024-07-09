namespace CarRace
{
    partial class frmMain
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Liberare le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.bttcrea = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bttcrea
            // 
            this.bttcrea.Location = new System.Drawing.Point(441, 0);
            this.bttcrea.Name = "bttcrea";
            this.bttcrea.Size = new System.Drawing.Size(41, 23);
            this.bttcrea.TabIndex = 0;
            this.bttcrea.Text = "Crea";
            this.bttcrea.UseVisualStyleBackColor = true;
            this.bttcrea.Click += new System.EventHandler(this.bttcrea_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 462);
            this.Controls.Add(this.bttcrea);
            this.Name = "frmMain";
            this.Text = "CarRace";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmMain_MouseMove);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bttcrea;
    }
}

