namespace Server
{
    partial class frmmain
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmmain));
            this.grptentativo = new System.Windows.Forms.GroupBox();
            this.bttled = new System.Windows.Forms.Button();
            this.btttentativo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.grpcomunicazione = new System.Windows.Forms.GroupBox();
            this.txtcomunicazione = new System.Windows.Forms.TextBox();
            this.bttricevi = new System.Windows.Forms.Button();
            this.grptentativo.SuspendLayout();
            this.grpcomunicazione.SuspendLayout();
            this.SuspendLayout();
            // 
            // grptentativo
            // 
            this.grptentativo.Controls.Add(this.bttled);
            this.grptentativo.Controls.Add(this.btttentativo);
            this.grptentativo.Controls.Add(this.label1);
            this.grptentativo.Location = new System.Drawing.Point(12, 12);
            this.grptentativo.Name = "grptentativo";
            this.grptentativo.Size = new System.Drawing.Size(198, 67);
            this.grptentativo.TabIndex = 0;
            this.grptentativo.TabStop = false;
            this.grptentativo.Text = "Tentativo di Connessione";
            // 
            // bttled
            // 
            this.bttled.BackColor = System.Drawing.Color.Red;
            this.bttled.Enabled = false;
            this.bttled.Location = new System.Drawing.Point(122, 19);
            this.bttled.Name = "bttled";
            this.bttled.Size = new System.Drawing.Size(24, 23);
            this.bttled.TabIndex = 3;
            this.bttled.UseVisualStyleBackColor = false;
            // 
            // btttentativo
            // 
            this.btttentativo.Location = new System.Drawing.Point(6, 19);
            this.btttentativo.Name = "btttentativo";
            this.btttentativo.Size = new System.Drawing.Size(110, 23);
            this.btttentativo.TabIndex = 2;
            this.btttentativo.Text = "Start";
            this.btttentativo.UseVisualStyleBackColor = true;
            this.btttentativo.Click += new System.EventHandler(this.btttentativo_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(6, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Connessione creata con successo";
            this.label1.Visible = false;
            // 
            // grpcomunicazione
            // 
            this.grpcomunicazione.Controls.Add(this.bttricevi);
            this.grpcomunicazione.Controls.Add(this.txtcomunicazione);
            this.grpcomunicazione.Enabled = false;
            this.grpcomunicazione.Location = new System.Drawing.Point(12, 85);
            this.grpcomunicazione.Name = "grpcomunicazione";
            this.grpcomunicazione.Size = new System.Drawing.Size(200, 129);
            this.grpcomunicazione.TabIndex = 1;
            this.grpcomunicazione.TabStop = false;
            this.grpcomunicazione.Text = "Finestra di Comunicazione";
            // 
            // txtcomunicazione
            // 
            this.txtcomunicazione.Enabled = false;
            this.txtcomunicazione.Location = new System.Drawing.Point(6, 19);
            this.txtcomunicazione.Multiline = true;
            this.txtcomunicazione.Name = "txtcomunicazione";
            this.txtcomunicazione.ReadOnly = true;
            this.txtcomunicazione.Size = new System.Drawing.Size(188, 75);
            this.txtcomunicazione.TabIndex = 0;
            // 
            // bttricevi
            // 
            this.bttricevi.Location = new System.Drawing.Point(62, 100);
            this.bttricevi.Name = "bttricevi";
            this.bttricevi.Size = new System.Drawing.Size(75, 23);
            this.bttricevi.TabIndex = 1;
            this.bttricevi.Text = "Receive";
            this.bttricevi.UseVisualStyleBackColor = true;
            this.bttricevi.Click += new System.EventHandler(this.bttinvio_Click);
            // 
            // frmmain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(225, 225);
            this.Controls.Add(this.grpcomunicazione);
            this.Controls.Add(this.grptentativo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmmain";
            this.Text = "Server";
            this.grptentativo.ResumeLayout(false);
            this.grpcomunicazione.ResumeLayout(false);
            this.grpcomunicazione.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grptentativo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btttentativo;
        private System.Windows.Forms.Button bttled;
        private System.Windows.Forms.GroupBox grpcomunicazione;
        private System.Windows.Forms.TextBox txtcomunicazione;
        private System.Windows.Forms.Button bttricevi;
    }
}

