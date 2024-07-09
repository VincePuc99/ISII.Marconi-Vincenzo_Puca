using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Testimage
{
    public partial class frmmain : Form
    {
        private Graphics objG;
        private Image Img;
        private Rectangle rect;
        private int xrett, yrett;
        public frmmain()
        {
            InitializeComponent();
            xrett = 0;
            yrett = 0;             
        }

        private void bttclick_Click(object sender, EventArgs e)
        {
            tmr.Enabled = true;        
        }

        private void tmr_Tick(object sender, EventArgs e)
        {
            this.Refresh();
            rect = new Rectangle(xrett, yrett, 100, 100);
            objG.DrawImage(Img, rect);
            
            xrett++;
            yrett++;
        }

        private void frmmain_Load(object sender, EventArgs e)
        {
            objG = this.CreateGraphics();
            Img = Image.FromFile(@"../../Images/F1.jpg");     
        }
    }
}
