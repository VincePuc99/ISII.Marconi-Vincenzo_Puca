namespace Router_Simulator
{
    partial class frmmain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmmain));
            this.pctRouter = new System.Windows.Forms.PictureBox();
            this.bttLed = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtdisplay = new System.Windows.Forms.TextBox();
            this.bttinseriscicomandi = new System.Windows.Forms.Button();
            this.pctFa0 = new System.Windows.Forms.PictureBox();
            this.pctFa1 = new System.Windows.Forms.PictureBox();
            this.pctConnessoFa0 = new System.Windows.Forms.PictureBox();
            this.pctConnessoFa1 = new System.Windows.Forms.PictureBox();
            this.bttAnalizza = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pctComputer = new System.Windows.Forms.PictureBox();
            this.pctCavo = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtReteSx = new System.Windows.Forms.TextBox();
            this.txtReteDx = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.bttping = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.pctTickDx = new System.Windows.Forms.PictureBox();
            this.pctTickSx = new System.Windows.Forms.PictureBox();
            this.tmrPseudoReti = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pctRouter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctFa0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctFa1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctConnessoFa0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctConnessoFa1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctComputer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctCavo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctTickDx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctTickSx)).BeginInit();
            this.SuspendLayout();
            // 
            // pctRouter
            // 
            this.pctRouter.Enabled = false;
            this.pctRouter.Location = new System.Drawing.Point(35, 35);
            this.pctRouter.Name = "pctRouter";
            this.pctRouter.Size = new System.Drawing.Size(400, 300);
            this.pctRouter.TabIndex = 0;
            this.pctRouter.TabStop = false;
            this.pctRouter.Click += new System.EventHandler(this.pctRouter_Click);
            // 
            // bttLed
            // 
            this.bttLed.BackColor = System.Drawing.SystemColors.Control;
            this.bttLed.Location = new System.Drawing.Point(218, 185);
            this.bttLed.Margin = new System.Windows.Forms.Padding(0);
            this.bttLed.Name = "bttLed";
            this.bttLed.Size = new System.Drawing.Size(20, 20);
            this.bttLed.TabIndex = 1;
            this.bttLed.UseVisualStyleBackColor = false;
            this.bttLed.Click += new System.EventHandler(this.bttLed_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("OCR A Extended", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(201, 172);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "ON/OFF";
            // 
            // txtdisplay
            // 
            this.txtdisplay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtdisplay.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txtdisplay.Enabled = false;
            this.txtdisplay.Font = new System.Drawing.Font("OCR A Extended", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdisplay.Location = new System.Drawing.Point(88, 231);
            this.txtdisplay.Multiline = true;
            this.txtdisplay.Name = "txtdisplay";
            this.txtdisplay.ReadOnly = true;
            this.txtdisplay.Size = new System.Drawing.Size(289, 55);
            this.txtdisplay.TabIndex = 3;
            // 
            // bttinseriscicomandi
            // 
            this.bttinseriscicomandi.Location = new System.Drawing.Point(508, 84);
            this.bttinseriscicomandi.Name = "bttinseriscicomandi";
            this.bttinseriscicomandi.Size = new System.Drawing.Size(55, 23);
            this.bttinseriscicomandi.TabIndex = 4;
            this.bttinseriscicomandi.Text = "Inserisci";
            this.bttinseriscicomandi.UseVisualStyleBackColor = true;
            this.bttinseriscicomandi.Click += new System.EventHandler(this.bttcarica_Click);
            // 
            // pctFa0
            // 
            this.pctFa0.Enabled = false;
            this.pctFa0.Location = new System.Drawing.Point(361, 113);
            this.pctFa0.Name = "pctFa0";
            this.pctFa0.Size = new System.Drawing.Size(46, 47);
            this.pctFa0.TabIndex = 5;
            this.pctFa0.TabStop = false;
            this.pctFa0.Click += new System.EventHandler(this.pctFa0_Click);
            // 
            // pctFa1
            // 
            this.pctFa1.Enabled = false;
            this.pctFa1.Location = new System.Drawing.Point(69, 93);
            this.pctFa1.Name = "pctFa1";
            this.pctFa1.Size = new System.Drawing.Size(46, 47);
            this.pctFa1.TabIndex = 6;
            this.pctFa1.TabStop = false;
            this.pctFa1.Click += new System.EventHandler(this.pctFa1_Click);
            // 
            // pctConnessoFa0
            // 
            this.pctConnessoFa0.Location = new System.Drawing.Point(369, 122);
            this.pctConnessoFa0.Name = "pctConnessoFa0";
            this.pctConnessoFa0.Size = new System.Drawing.Size(31, 30);
            this.pctConnessoFa0.TabIndex = 7;
            this.pctConnessoFa0.TabStop = false;
            this.pctConnessoFa0.Visible = false;
            this.pctConnessoFa0.Click += new System.EventHandler(this.pctConnessoFa0_Click);
            // 
            // pctConnessoFa1
            // 
            this.pctConnessoFa1.Location = new System.Drawing.Point(77, 102);
            this.pctConnessoFa1.Name = "pctConnessoFa1";
            this.pctConnessoFa1.Size = new System.Drawing.Size(31, 30);
            this.pctConnessoFa1.TabIndex = 8;
            this.pctConnessoFa1.TabStop = false;
            this.pctConnessoFa1.Visible = false;
            this.pctConnessoFa1.Click += new System.EventHandler(this.pctConnessoFa1_Click);
            // 
            // bttAnalizza
            // 
            this.bttAnalizza.Enabled = false;
            this.bttAnalizza.Location = new System.Drawing.Point(508, 109);
            this.bttAnalizza.Name = "bttAnalizza";
            this.bttAnalizza.Size = new System.Drawing.Size(98, 23);
            this.bttAnalizza.TabIndex = 9;
            this.bttAnalizza.Text = "Analizza e carica";
            this.bttAnalizza.UseVisualStyleBackColor = true;
            this.bttAnalizza.Click += new System.EventHandler(this.bttAnalizza_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(518, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "startup_config ";
            // 
            // pctComputer
            // 
            this.pctComputer.Location = new System.Drawing.Point(475, 35);
            this.pctComputer.Name = "pctComputer";
            this.pctComputer.Size = new System.Drawing.Size(162, 170);
            this.pctComputer.TabIndex = 11;
            this.pctComputer.TabStop = false;
            // 
            // pctCavo
            // 
            this.pctCavo.Location = new System.Drawing.Point(431, 157);
            this.pctCavo.Name = "pctCavo";
            this.pctCavo.Size = new System.Drawing.Size(45, 48);
            this.pctCavo.TabIndex = 12;
            this.pctCavo.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Enabled = false;
            this.label3.Location = new System.Drawing.Point(441, 223);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(229, 117);
            this.label3.TabIndex = 13;
            this.label3.Text = resources.GetString("label3.Text");
            // 
            // txtReteSx
            // 
            this.txtReteSx.Enabled = false;
            this.txtReteSx.Location = new System.Drawing.Point(506, 7);
            this.txtReteSx.Name = "txtReteSx";
            this.txtReteSx.ReadOnly = true;
            this.txtReteSx.Size = new System.Drawing.Size(132, 20);
            this.txtReteSx.TabIndex = 14;
            // 
            // txtReteDx
            // 
            this.txtReteDx.Enabled = false;
            this.txtReteDx.Location = new System.Drawing.Point(202, 7);
            this.txtReteDx.Name = "txtReteDx";
            this.txtReteDx.ReadOnly = true;
            this.txtReteDx.Size = new System.Drawing.Size(132, 20);
            this.txtReteDx.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Enabled = false;
            this.label4.Location = new System.Drawing.Point(340, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(160, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Pacchetto ricevuto da(COM Sx):";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Enabled = false;
            this.label5.Location = new System.Drawing.Point(35, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(164, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Pacchetto ricevuto da (COM Dx):";
            // 
            // bttping
            // 
            this.bttping.Enabled = false;
            this.bttping.Location = new System.Drawing.Point(566, 84);
            this.bttping.Name = "bttping";
            this.bttping.Size = new System.Drawing.Size(40, 23);
            this.bttping.TabIndex = 18;
            this.bttping.Text = "Ping";
            this.bttping.UseVisualStyleBackColor = true;
            this.bttping.Click += new System.EventHandler(this.bttping_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(156, 289);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(151, 18);
            this.label6.TabIndex = 19;
            this.label6.Text = "Cizco System S.P.A";
            // 
            // pctTickDx
            // 
            this.pctTickDx.Location = new System.Drawing.Point(2, 3);
            this.pctTickDx.Name = "pctTickDx";
            this.pctTickDx.Size = new System.Drawing.Size(27, 27);
            this.pctTickDx.TabIndex = 20;
            this.pctTickDx.TabStop = false;
            this.pctTickDx.Visible = false;
            // 
            // pctTickSx
            // 
            this.pctTickSx.Location = new System.Drawing.Point(644, 3);
            this.pctTickSx.Name = "pctTickSx";
            this.pctTickSx.Size = new System.Drawing.Size(27, 27);
            this.pctTickSx.TabIndex = 21;
            this.pctTickSx.TabStop = false;
            this.pctTickSx.Visible = false;
            // 
            // tmrPseudoReti
            // 
            this.tmrPseudoReti.Interval = 3000;
            this.tmrPseudoReti.Tick += new System.EventHandler(this.tmrPseudoReti_Tick);
            // 
            // frmmain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 362);
            this.Controls.Add(this.pctTickSx);
            this.Controls.Add(this.pctTickDx);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.bttping);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtReteDx);
            this.Controls.Add(this.txtReteSx);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bttinseriscicomandi);
            this.Controls.Add(this.bttAnalizza);
            this.Controls.Add(this.pctComputer);
            this.Controls.Add(this.pctConnessoFa1);
            this.Controls.Add(this.pctConnessoFa0);
            this.Controls.Add(this.pctFa1);
            this.Controls.Add(this.pctFa0);
            this.Controls.Add(this.txtdisplay);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bttLed);
            this.Controls.Add(this.pctRouter);
            this.Controls.Add(this.pctCavo);
            this.Cursor = System.Windows.Forms.Cursors.UpArrow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmmain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "~Router Simulator~";
            this.Load += new System.EventHandler(this.frmmain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pctRouter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctFa0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctFa1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctConnessoFa0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctConnessoFa1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctComputer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctCavo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctTickDx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctTickSx)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pctRouter;
        private System.Windows.Forms.Button bttLed;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtdisplay;
        private System.Windows.Forms.Button bttinseriscicomandi;
        private System.Windows.Forms.PictureBox pctFa0;
        private System.Windows.Forms.PictureBox pctFa1;
        private System.Windows.Forms.PictureBox pctConnessoFa0;
        private System.Windows.Forms.PictureBox pctConnessoFa1;
        private System.Windows.Forms.Button bttAnalizza;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pctComputer;
        private System.Windows.Forms.PictureBox pctCavo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtReteSx;
        private System.Windows.Forms.TextBox txtReteDx;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button bttping;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pctTickDx;
        private System.Windows.Forms.PictureBox pctTickSx;
        private System.Windows.Forms.Timer tmrPseudoReti;
    }
}

