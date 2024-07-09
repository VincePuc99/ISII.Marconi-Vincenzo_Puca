namespace Carrace
{
    partial class frmmain
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
            this.bttstart = new System.Windows.Forms.Button();
            this.tmrVai = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // bttstart
            // 
            this.bttstart.Location = new System.Drawing.Point(220, 440);
            this.bttstart.Name = "bttstart";
            this.bttstart.Size = new System.Drawing.Size(43, 23);
            this.bttstart.TabIndex = 0;
            this.bttstart.Text = "Start";
            this.bttstart.UseVisualStyleBackColor = true;
            this.bttstart.Click += new System.EventHandler(this.bttstart_Click);
            // 
            // tmrVai
            // 
            this.tmrVai.Interval = 50;
            this.tmrVai.Tick += new System.EventHandler(this.tmrVai_Tick);
            // 
            // frmmain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.bttstart);
            this.Name = "frmmain";
            this.Text = "Car Race V1.0";
            this.Load += new System.EventHandler(this.frmmain_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.frmmain_MouseClick);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmmain_MouseMove);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bttstart;
        private System.Windows.Forms.Timer tmrVai;
    }
}

