namespace rubinetto
{
    partial class Frmmain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frmmain));
            this.bttcrea = new System.Windows.Forms.Button();
            this.pct = new System.Windows.Forms.PictureBox();
            this.tmrAggiungi = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bttesci = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pct)).BeginInit();
            this.SuspendLayout();
            // 
            // bttcrea
            // 
            this.bttcrea.BackColor = System.Drawing.Color.Gold;
            this.bttcrea.Location = new System.Drawing.Point(51, 0);
            this.bttcrea.Name = "bttcrea";
            this.bttcrea.Size = new System.Drawing.Size(39, 23);
            this.bttcrea.TabIndex = 0;
            this.bttcrea.Text = "Crea";
            this.bttcrea.UseVisualStyleBackColor = false;
            this.bttcrea.Click += new System.EventHandler(this.bttcrea_Click);
            // 
            // pct
            // 
            this.pct.Enabled = false;
            this.pct.Location = new System.Drawing.Point(106, 6);
            this.pct.Name = "pct";
            this.pct.Size = new System.Drawing.Size(189, 129);
            this.pct.TabIndex = 1;
            this.pct.TabStop = false;
            // 
            // tmrAggiungi
            // 
            this.tmrAggiungi.Interval = 200;
            this.tmrAggiungi.Tick += new System.EventHandler(this.tmrAggiungi_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Enabled = false;
            this.label2.Location = new System.Drawing.Point(301, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 39);
            this.label2.TabIndex = 3;
            this.label2.Text = "Chiudi con\r\ntasto destro \r\nin questa zona";
            this.label2.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Enabled = false;
            this.label1.Location = new System.Drawing.Point(1, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 39);
            this.label1.TabIndex = 4;
            this.label1.Text = "Apri con\r\ntasto sinistro \r\nin questa zona";
            this.label1.Visible = false;
            // 
            // bttesci
            // 
            this.bttesci.BackColor = System.Drawing.Color.Red;
            this.bttesci.Enabled = false;
            this.bttesci.Location = new System.Drawing.Point(1, 21);
            this.bttesci.Name = "bttesci";
            this.bttesci.Size = new System.Drawing.Size(39, 23);
            this.bttesci.TabIndex = 5;
            this.bttesci.Text = "Exit";
            this.bttesci.UseVisualStyleBackColor = false;
            this.bttesci.Visible = false;
            this.bttesci.Click += new System.EventHandler(this.bttesci_Click);
            // 
            // Frmmain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(484, 462);
            this.Controls.Add(this.bttesci);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pct);
            this.Controls.Add(this.bttcrea);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frmmain";
            this.Text = "Rubinetto V1.0";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseClick);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Frmmain_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.pct)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bttcrea;
        private System.Windows.Forms.PictureBox pct;
        private System.Windows.Forms.Timer tmrAggiungi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bttesci;
    }
}

