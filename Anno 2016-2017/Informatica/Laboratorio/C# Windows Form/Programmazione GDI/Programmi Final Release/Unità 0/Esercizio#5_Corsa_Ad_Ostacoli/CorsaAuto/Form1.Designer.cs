namespace CorsaAuto
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
            this.pctAuto = new System.Windows.Forms.PictureBox();
            this.bttcrea = new System.Windows.Forms.Button();
            this.pctAuto2 = new System.Windows.Forms.PictureBox();
            this.pctAlbero = new System.Windows.Forms.PictureBox();
            this.tmrAlbero = new System.Windows.Forms.Timer(this.components);
            this.pctSole = new System.Windows.Forms.PictureBox();
            this.pctPalla = new System.Windows.Forms.PictureBox();
            this.pctpalla2 = new System.Windows.Forms.PictureBox();
            this.tmrPalla = new System.Windows.Forms.Timer(this.components);
            this.tmrPalla2 = new System.Windows.Forms.Timer(this.components);
            this.tmrTestTocco = new System.Windows.Forms.Timer(this.components);
            this.pctAlberopiccolo = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grpcomandi = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pctAuto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctAuto2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctAlbero)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctSole)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctPalla)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctpalla2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctAlberopiccolo)).BeginInit();
            this.grpcomandi.SuspendLayout();
            this.SuspendLayout();
            // 
            // pctAuto
            // 
            this.pctAuto.Location = new System.Drawing.Point(12, 345);
            this.pctAuto.Name = "pctAuto";
            this.pctAuto.Size = new System.Drawing.Size(128, 73);
            this.pctAuto.TabIndex = 0;
            this.pctAuto.TabStop = false;
            // 
            // bttcrea
            // 
            this.bttcrea.Location = new System.Drawing.Point(297, 79);
            this.bttcrea.Name = "bttcrea";
            this.bttcrea.Size = new System.Drawing.Size(51, 35);
            this.bttcrea.TabIndex = 1;
            this.bttcrea.UseVisualStyleBackColor = true;
            this.bttcrea.Click += new System.EventHandler(this.bttcrea_Click);
            this.bttcrea.KeyDown += new System.Windows.Forms.KeyEventHandler(this.bttcrea_KeyDown);
            // 
            // pctAuto2
            // 
            this.pctAuto2.Location = new System.Drawing.Point(12, 416);
            this.pctAuto2.Name = "pctAuto2";
            this.pctAuto2.Size = new System.Drawing.Size(128, 73);
            this.pctAuto2.TabIndex = 2;
            this.pctAuto2.TabStop = false;
            // 
            // pctAlbero
            // 
            this.pctAlbero.Location = new System.Drawing.Point(332, 206);
            this.pctAlbero.Name = "pctAlbero";
            this.pctAlbero.Size = new System.Drawing.Size(167, 139);
            this.pctAlbero.TabIndex = 3;
            this.pctAlbero.TabStop = false;
            // 
            // tmrAlbero
            // 
            this.tmrAlbero.Tick += new System.EventHandler(this.tmrAlbero_Tick);
            // 
            // pctSole
            // 
            this.pctSole.Location = new System.Drawing.Point(185, 29);
            this.pctSole.Name = "pctSole";
            this.pctSole.Size = new System.Drawing.Size(128, 124);
            this.pctSole.TabIndex = 4;
            this.pctSole.TabStop = false;
            // 
            // pctPalla
            // 
            this.pctPalla.Location = new System.Drawing.Point(447, 363);
            this.pctPalla.Name = "pctPalla";
            this.pctPalla.Size = new System.Drawing.Size(40, 38);
            this.pctPalla.TabIndex = 5;
            this.pctPalla.TabStop = false;
            // 
            // pctpalla2
            // 
            this.pctpalla2.Location = new System.Drawing.Point(252, 431);
            this.pctpalla2.Name = "pctpalla2";
            this.pctpalla2.Size = new System.Drawing.Size(40, 38);
            this.pctpalla2.TabIndex = 6;
            this.pctpalla2.TabStop = false;
            // 
            // tmrPalla
            // 
            this.tmrPalla.Interval = 50;
            this.tmrPalla.Tick += new System.EventHandler(this.tmrSpawnPalla_Tick);
            // 
            // tmrPalla2
            // 
            this.tmrPalla2.Interval = 50;
            this.tmrPalla2.Tick += new System.EventHandler(this.tmrPalla2_Tick);
            // 
            // tmrTestTocco
            // 
            this.tmrTestTocco.Interval = 1;
            this.tmrTestTocco.Tick += new System.EventHandler(this.tmrTestTocco_Tick);
            // 
            // pctAlberopiccolo
            // 
            this.pctAlberopiccolo.Location = new System.Drawing.Point(226, 247);
            this.pctAlberopiccolo.Name = "pctAlberopiccolo";
            this.pctAlberopiccolo.Size = new System.Drawing.Size(87, 98);
            this.pctAlberopiccolo.TabIndex = 7;
            this.pctAlberopiccolo.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(50, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(390, 66);
            this.label1.TabIndex = 8;
            this.label1.Text = "Premi qui per -->\r\ncominciare la tua sfida!!!";
            // 
            // grpcomandi
            // 
            this.grpcomandi.BackColor = System.Drawing.Color.Transparent;
            this.grpcomandi.Controls.Add(this.label5);
            this.grpcomandi.Controls.Add(this.label4);
            this.grpcomandi.Controls.Add(this.label3);
            this.grpcomandi.Controls.Add(this.label2);
            this.grpcomandi.Location = new System.Drawing.Point(1, 4);
            this.grpcomandi.Name = "grpcomandi";
            this.grpcomandi.Size = new System.Drawing.Size(165, 56);
            this.grpcomandi.TabIndex = 9;
            this.grpcomandi.TabStop = false;
            this.grpcomandi.Text = "Comandi";
            this.grpcomandi.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "W-->1°Corsia";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "A-->Vai Indietro";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(74, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "S-->2°Corsia";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(88, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "D-->Vai Avanti";
            // 
            // frmmain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 501);
            this.Controls.Add(this.grpcomandi);
            this.Controls.Add(this.bttcrea);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pctAlberopiccolo);
            this.Controls.Add(this.pctpalla2);
            this.Controls.Add(this.pctPalla);
            this.Controls.Add(this.pctSole);
            this.Controls.Add(this.pctAlbero);
            this.Controls.Add(this.pctAuto2);
            this.Controls.Add(this.pctAuto);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmmain";
            this.Text = "~Corsa auto~";
            ((System.ComponentModel.ISupportInitialize)(this.pctAuto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctAuto2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctAlbero)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctSole)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctPalla)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctpalla2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctAlberopiccolo)).EndInit();
            this.grpcomandi.ResumeLayout(false);
            this.grpcomandi.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pctAuto;
        private System.Windows.Forms.Button bttcrea;
        private System.Windows.Forms.PictureBox pctAuto2;
        private System.Windows.Forms.PictureBox pctAlbero;
        private System.Windows.Forms.Timer tmrAlbero;
        private System.Windows.Forms.PictureBox pctSole;
        private System.Windows.Forms.PictureBox pctPalla;
        private System.Windows.Forms.PictureBox pctpalla2;
        private System.Windows.Forms.Timer tmrPalla;
        private System.Windows.Forms.Timer tmrPalla2;
        private System.Windows.Forms.Timer tmrTestTocco;
        private System.Windows.Forms.PictureBox pctAlberopiccolo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpcomandi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}

