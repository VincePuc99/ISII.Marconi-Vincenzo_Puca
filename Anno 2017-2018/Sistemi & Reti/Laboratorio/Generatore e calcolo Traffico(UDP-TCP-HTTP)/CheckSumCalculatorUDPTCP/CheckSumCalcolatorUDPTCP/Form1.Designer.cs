namespace CheckSumCalcolatorUDPTCP
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.grpUDP = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtrisultatochecksumudp = new System.Windows.Forms.TextBox();
            this.bttcalcolaudp = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtudpdata = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtudplenght = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtudpdestination = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtudpsource = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtlenght = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtprotocol = new System.Windows.Forms.TextBox();
            this.txtdestip = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtsourceip = new System.Windows.Forms.TextBox();
            this.grpTCP = new System.Windows.Forms.GroupBox();
            this.rdbUDP = new System.Windows.Forms.RadioButton();
            this.rdbTCP = new System.Windows.Forms.RadioButton();
            this.grppseudo = new System.Windows.Forms.GroupBox();
            this.txtTCPheader = new System.Windows.Forms.TextBox();
            this.txtTCPdata = new System.Windows.Forms.TextBox();
            this.bttcalcolatcp = new System.Windows.Forms.Button();
            this.txtrisultatotcp = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.grpmodel = new System.Windows.Forms.GroupBox();
            this.grpUDP.SuspendLayout();
            this.grpTCP.SuspendLayout();
            this.grppseudo.SuspendLayout();
            this.grpmodel.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpUDP
            // 
            this.grpUDP.Controls.Add(this.label9);
            this.grpUDP.Controls.Add(this.txtrisultatochecksumudp);
            this.grpUDP.Controls.Add(this.bttcalcolaudp);
            this.grpUDP.Controls.Add(this.label8);
            this.grpUDP.Controls.Add(this.txtudpdata);
            this.grpUDP.Controls.Add(this.label7);
            this.grpUDP.Controls.Add(this.txtudplenght);
            this.grpUDP.Controls.Add(this.label6);
            this.grpUDP.Controls.Add(this.txtudpdestination);
            this.grpUDP.Controls.Add(this.label5);
            this.grpUDP.Controls.Add(this.txtudpsource);
            this.grpUDP.Enabled = false;
            this.grpUDP.Location = new System.Drawing.Point(12, 142);
            this.grpUDP.Name = "grpUDP";
            this.grpUDP.Size = new System.Drawing.Size(262, 184);
            this.grpUDP.TabIndex = 0;
            this.grpUDP.TabStop = false;
            this.grpUDP.Text = "Checksum UDP";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(136, 160);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(86, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Risultato Calcolo";
            // 
            // txtrisultatochecksumudp
            // 
            this.txtrisultatochecksumudp.Location = new System.Drawing.Point(7, 153);
            this.txtrisultatochecksumudp.Name = "txtrisultatochecksumudp";
            this.txtrisultatochecksumudp.ReadOnly = true;
            this.txtrisultatochecksumudp.Size = new System.Drawing.Size(123, 20);
            this.txtrisultatochecksumudp.TabIndex = 17;
            // 
            // bttcalcolaudp
            // 
            this.bttcalcolaudp.Location = new System.Drawing.Point(6, 123);
            this.bttcalcolaudp.Name = "bttcalcolaudp";
            this.bttcalcolaudp.Size = new System.Drawing.Size(244, 23);
            this.bttcalcolaudp.TabIndex = 16;
            this.bttcalcolaudp.Text = "Calcola Checksum";
            this.bttcalcolaudp.UseVisualStyleBackColor = true;
            this.bttcalcolaudp.Click += new System.EventHandler(this.bttcalcolaudp_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(136, 100);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "UDP Data";
            // 
            // txtudpdata
            // 
            this.txtudpdata.Location = new System.Drawing.Point(6, 97);
            this.txtudpdata.Name = "txtudpdata";
            this.txtudpdata.Size = new System.Drawing.Size(124, 20);
            this.txtudpdata.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(136, 74);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "UDP Length";
            // 
            // txtudplenght
            // 
            this.txtudplenght.Location = new System.Drawing.Point(6, 71);
            this.txtudplenght.Name = "txtudplenght";
            this.txtudplenght.Size = new System.Drawing.Size(124, 20);
            this.txtudplenght.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(136, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "UDP Destionation Port";
            // 
            // txtudpdestination
            // 
            this.txtudpdestination.Location = new System.Drawing.Point(6, 45);
            this.txtudpdestination.Name = "txtudpdestination";
            this.txtudpdestination.Size = new System.Drawing.Size(124, 20);
            this.txtudpdestination.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(137, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "UDP Source Port";
            // 
            // txtudpsource
            // 
            this.txtudpsource.Location = new System.Drawing.Point(6, 19);
            this.txtudpsource.Name = "txtudpsource";
            this.txtudpsource.Size = new System.Drawing.Size(124, 20);
            this.txtudpsource.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(136, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Lenght";
            // 
            // txtlenght
            // 
            this.txtlenght.Location = new System.Drawing.Point(6, 97);
            this.txtlenght.Name = "txtlenght";
            this.txtlenght.Size = new System.Drawing.Size(124, 20);
            this.txtlenght.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(136, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Protocol";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(136, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Destination IP";
            // 
            // txtprotocol
            // 
            this.txtprotocol.Location = new System.Drawing.Point(6, 71);
            this.txtprotocol.Name = "txtprotocol";
            this.txtprotocol.Size = new System.Drawing.Size(124, 20);
            this.txtprotocol.TabIndex = 3;
            // 
            // txtdestip
            // 
            this.txtdestip.Location = new System.Drawing.Point(6, 45);
            this.txtdestip.Name = "txtdestip";
            this.txtdestip.Size = new System.Drawing.Size(124, 20);
            this.txtdestip.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(136, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Source IP";
            // 
            // txtsourceip
            // 
            this.txtsourceip.Location = new System.Drawing.Point(6, 19);
            this.txtsourceip.Name = "txtsourceip";
            this.txtsourceip.Size = new System.Drawing.Size(124, 20);
            this.txtsourceip.TabIndex = 0;
            // 
            // grpTCP
            // 
            this.grpTCP.Controls.Add(this.label12);
            this.grpTCP.Controls.Add(this.label11);
            this.grpTCP.Controls.Add(this.label10);
            this.grpTCP.Controls.Add(this.txtrisultatotcp);
            this.grpTCP.Controls.Add(this.bttcalcolatcp);
            this.grpTCP.Controls.Add(this.txtTCPdata);
            this.grpTCP.Controls.Add(this.txtTCPheader);
            this.grpTCP.Enabled = false;
            this.grpTCP.Location = new System.Drawing.Point(280, 142);
            this.grpTCP.Name = "grpTCP";
            this.grpTCP.Size = new System.Drawing.Size(262, 129);
            this.grpTCP.TabIndex = 1;
            this.grpTCP.TabStop = false;
            this.grpTCP.Text = "Checksum TCP";
            // 
            // rdbUDP
            // 
            this.rdbUDP.AutoSize = true;
            this.rdbUDP.Location = new System.Drawing.Point(6, 19);
            this.rdbUDP.Name = "rdbUDP";
            this.rdbUDP.Size = new System.Drawing.Size(48, 17);
            this.rdbUDP.TabIndex = 2;
            this.rdbUDP.TabStop = true;
            this.rdbUDP.Text = "UDP";
            this.rdbUDP.UseVisualStyleBackColor = true;
            this.rdbUDP.CheckedChanged += new System.EventHandler(this.rdbUDP_CheckedChanged);
            // 
            // rdbTCP
            // 
            this.rdbTCP.AutoSize = true;
            this.rdbTCP.Location = new System.Drawing.Point(58, 19);
            this.rdbTCP.Name = "rdbTCP";
            this.rdbTCP.Size = new System.Drawing.Size(46, 17);
            this.rdbTCP.TabIndex = 3;
            this.rdbTCP.TabStop = true;
            this.rdbTCP.Text = "TCP";
            this.rdbTCP.UseVisualStyleBackColor = true;
            this.rdbTCP.CheckedChanged += new System.EventHandler(this.rdbTCP_CheckedChanged);
            // 
            // grppseudo
            // 
            this.grppseudo.Controls.Add(this.txtdestip);
            this.grppseudo.Controls.Add(this.txtsourceip);
            this.grppseudo.Controls.Add(this.label1);
            this.grppseudo.Controls.Add(this.txtprotocol);
            this.grppseudo.Controls.Add(this.label2);
            this.grppseudo.Controls.Add(this.label3);
            this.grppseudo.Controls.Add(this.txtlenght);
            this.grppseudo.Controls.Add(this.label4);
            this.grppseudo.Location = new System.Drawing.Point(179, 12);
            this.grppseudo.Name = "grppseudo";
            this.grppseudo.Size = new System.Drawing.Size(217, 124);
            this.grppseudo.TabIndex = 6;
            this.grppseudo.TabStop = false;
            this.grppseudo.Text = "Pseudo-Header";
            // 
            // txtTCPheader
            // 
            this.txtTCPheader.Location = new System.Drawing.Point(6, 19);
            this.txtTCPheader.Name = "txtTCPheader";
            this.txtTCPheader.Size = new System.Drawing.Size(124, 20);
            this.txtTCPheader.TabIndex = 19;
            // 
            // txtTCPdata
            // 
            this.txtTCPdata.Location = new System.Drawing.Point(6, 45);
            this.txtTCPdata.Name = "txtTCPdata";
            this.txtTCPdata.Size = new System.Drawing.Size(124, 20);
            this.txtTCPdata.TabIndex = 20;
            // 
            // bttcalcolatcp
            // 
            this.bttcalcolatcp.Location = new System.Drawing.Point(6, 71);
            this.bttcalcolatcp.Name = "bttcalcolatcp";
            this.bttcalcolatcp.Size = new System.Drawing.Size(244, 23);
            this.bttcalcolatcp.TabIndex = 23;
            this.bttcalcolatcp.Text = "Calcola Checksum";
            this.bttcalcolatcp.UseVisualStyleBackColor = true;
            this.bttcalcolatcp.Click += new System.EventHandler(this.bttcalcolatcp_Click);
            // 
            // txtrisultatotcp
            // 
            this.txtrisultatotcp.Location = new System.Drawing.Point(6, 100);
            this.txtrisultatotcp.Name = "txtrisultatotcp";
            this.txtrisultatotcp.ReadOnly = true;
            this.txtrisultatotcp.Size = new System.Drawing.Size(123, 20);
            this.txtrisultatotcp.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(135, 104);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(86, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "Risultato Calcolo";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(136, 22);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(66, 13);
            this.label11.TabIndex = 24;
            this.label11.Text = "TCP Header";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(136, 48);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(54, 13);
            this.label12.TabIndex = 25;
            this.label12.Text = "TCP Data";
            // 
            // grpmodel
            // 
            this.grpmodel.Controls.Add(this.rdbUDP);
            this.grpmodel.Controls.Add(this.rdbTCP);
            this.grpmodel.Location = new System.Drawing.Point(12, 12);
            this.grpmodel.Name = "grpmodel";
            this.grpmodel.Size = new System.Drawing.Size(110, 44);
            this.grpmodel.TabIndex = 7;
            this.grpmodel.TabStop = false;
            this.grpmodel.Text = "Modello";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(550, 333);
            this.Controls.Add(this.grpmodel);
            this.Controls.Add(this.grppseudo);
            this.Controls.Add(this.grpTCP);
            this.Controls.Add(this.grpUDP);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Checksum Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpUDP.ResumeLayout(false);
            this.grpUDP.PerformLayout();
            this.grpTCP.ResumeLayout(false);
            this.grpTCP.PerformLayout();
            this.grppseudo.ResumeLayout(false);
            this.grppseudo.PerformLayout();
            this.grpmodel.ResumeLayout(false);
            this.grpmodel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpUDP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtprotocol;
        private System.Windows.Forms.TextBox txtdestip;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtsourceip;
        private System.Windows.Forms.GroupBox grpTCP;
        private System.Windows.Forms.RadioButton rdbUDP;
        private System.Windows.Forms.RadioButton rdbTCP;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtlenght;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtudplenght;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtudpdestination;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtudpsource;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtrisultatochecksumudp;
        private System.Windows.Forms.Button bttcalcolaudp;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtudpdata;
        private System.Windows.Forms.Button bttcalcolatcp;
        private System.Windows.Forms.TextBox txtTCPdata;
        private System.Windows.Forms.TextBox txtTCPheader;
        private System.Windows.Forms.GroupBox grppseudo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtrisultatotcp;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox grpmodel;
    }
}

