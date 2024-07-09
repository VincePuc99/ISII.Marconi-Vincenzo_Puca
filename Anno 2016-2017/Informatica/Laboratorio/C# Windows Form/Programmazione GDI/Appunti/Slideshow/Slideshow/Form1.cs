using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Slideshow
{
    public partial class frmMain : Form
    {
        private int i;
        static Random rand = new Random();
        
        public frmMain()
        {
            i = 0;
            InitializeComponent();
        }

        private void pcbFiori_Click(object sender, EventArgs e)
        {

        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            pctFiori.ImageLocation = @"../../Flowers/r1.jpg";
            pctFiori.SizeMode = PictureBoxSizeMode.CenterImage;
        }

        private void btnAvanti_Click(object sender, EventArgs e)
        {
            i++;
            
            if (i > 4)
            {
                i = 1;
            }
            pctFiori.ImageLocation = @"../../Flowers/r"+ i.ToString() +".jpg";
            pctFiori.SizeMode = PictureBoxSizeMode.CenterImage;
        }

        private void btnIndietro_Click(object sender, EventArgs e)
        {
            i--;
            if (i<1)
            {
                i = 2;
            }
            pctFiori.ImageLocation = @"../../Flowers/r" + i.ToString() + ".jpg";
            pctFiori.SizeMode = PictureBoxSizeMode.CenterImage;
        }

        private void btnAutoRiproduzione_Click(object sender, EventArgs e)
        {

            if(btnAutoRiproduzione.Text=="AUTO RIPRODUZIONE")
            {
                btnAutoRiproduzione.Text = "RIPRODUZIONE MANUALE";
                tmr.Enabled = true;
            }
            else
            {
                btnAutoRiproduzione.Text = "AUTO RIPRODUZIONE";
                tmr.Enabled = false;
            }
            
        }

        private void tmr_Tick(object sender, EventArgs e)
        {
            i++;

            //if (i > 4)
            //{
            //    i = 1;
            //}
            i = rand.Next(1, 5);
            pctFiori.ImageLocation = @"../../Flowers/r" + i.ToString() + ".jpg";
            pctFiori.SizeMode = PictureBoxSizeMode.CenterImage;

            
        }

        private void pctFiori_MouseHover(object sender, EventArgs e)
        {
            if(btnAutoRiproduzione.Text == "RIPRODUZIONE MANUALE")
            {
                tmr.Stop();

            }
        }

        private void pctFiori_MouseLeave(object sender, EventArgs e)
        {
            if (btnAutoRiproduzione.Text == "RIPRODUZIONE MANUALE")
            {
                tmr.Start();

            }
        }
    }
}
