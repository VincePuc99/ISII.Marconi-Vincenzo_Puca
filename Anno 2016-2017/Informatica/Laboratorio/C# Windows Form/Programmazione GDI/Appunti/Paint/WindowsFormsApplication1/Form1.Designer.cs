namespace WindowsFormsApplication1
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
            this.cmbstyle = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbcolor = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbstylecolor = new System.Windows.Forms.GroupBox();
            this.cmbstylecolor.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbstyle
            // 
            this.cmbstyle.FormattingEnabled = true;
            this.cmbstyle.Items.AddRange(new object[] {
            "------",
            "-------",
            "--------"});
            this.cmbstyle.Location = new System.Drawing.Point(6, 19);
            this.cmbstyle.Name = "cmbstyle";
            this.cmbstyle.Size = new System.Drawing.Size(121, 21);
            this.cmbstyle.TabIndex = 0;
            this.cmbstyle.SelectedIndexChanged += new System.EventHandler(this.cmbstyle_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(134, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Style";
            // 
            // cmbcolor
            // 
            this.cmbcolor.FormattingEnabled = true;
            this.cmbcolor.Items.AddRange(new object[] {
            "Rosso",
            "Verde",
            "Giallo",
            "Blu"});
            this.cmbcolor.Location = new System.Drawing.Point(6, 46);
            this.cmbcolor.Name = "cmbcolor";
            this.cmbcolor.Size = new System.Drawing.Size(121, 21);
            this.cmbcolor.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(137, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Colore";
            // 
            // cmbstylecolor
            // 
            this.cmbstylecolor.Controls.Add(this.label1);
            this.cmbstylecolor.Controls.Add(this.label2);
            this.cmbstylecolor.Controls.Add(this.cmbstyle);
            this.cmbstylecolor.Controls.Add(this.cmbcolor);
            this.cmbstylecolor.Location = new System.Drawing.Point(12, 12);
            this.cmbstylecolor.Name = "cmbstylecolor";
            this.cmbstylecolor.Size = new System.Drawing.Size(181, 76);
            this.cmbstylecolor.TabIndex = 4;
            this.cmbstylecolor.TabStop = false;
            this.cmbstylecolor.Text = "Stile-Colore";
            // 
            // frmmain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(384, 361);
            this.Controls.Add(this.cmbstylecolor);
            this.Name = "frmmain";
            this.Text = "CAD";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseClick);
            this.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDoubleClick);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.cmbstylecolor.ResumeLayout(false);
            this.cmbstylecolor.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbstyle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbcolor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox cmbstylecolor;
    }
}

