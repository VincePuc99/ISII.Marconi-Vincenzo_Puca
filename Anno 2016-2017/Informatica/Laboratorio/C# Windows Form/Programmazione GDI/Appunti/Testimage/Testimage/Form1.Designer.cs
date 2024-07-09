namespace Testimage
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
            this.bttclick = new System.Windows.Forms.Button();
            this.tmr = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // bttclick
            // 
            this.bttclick.Location = new System.Drawing.Point(12, 426);
            this.bttclick.Name = "bttclick";
            this.bttclick.Size = new System.Drawing.Size(75, 23);
            this.bttclick.TabIndex = 1;
            this.bttclick.Text = "Cliccami";
            this.bttclick.UseVisualStyleBackColor = true;
            this.bttclick.Click += new System.EventHandler(this.bttclick_Click);
            // 
            // tmr
            // 
            this.tmr.Interval = 300;
            this.tmr.Tick += new System.EventHandler(this.tmr_Tick);
            // 
            // frmmain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.bttclick);
            this.Name = "frmmain";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmmain_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button bttclick;
        private System.Windows.Forms.Timer tmr;
    }
}

