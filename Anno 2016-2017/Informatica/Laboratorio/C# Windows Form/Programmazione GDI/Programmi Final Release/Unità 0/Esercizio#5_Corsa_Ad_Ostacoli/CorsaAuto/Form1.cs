using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CorsaAuto
{
    public partial class frmmain : Form
    {
        private int posizioneauto;
        private int posizionealbero, posizionealberopiccolo;
        private int posizionepalla;
        private int posizionepalla2;
        private int posizioneauto2;

        public frmmain()
        {
            posizionealberopiccolo = 226;
            posizionepalla = 427;
            posizioneauto = 12;
            posizionealbero = 332;
            posizionepalla2 = 273;
            InitializeComponent();
        }

        private void bttcrea_Click(object sender, EventArgs e)
        {
            grpcomandi.Visible = true;
            label1.Visible = false;
            bttcrea.Visible = false;
            this.BackgroundImage = Image.FromFile(@"../../Images/AsfaltoTop.png");

            pctAuto.ImageLocation = @"../../Images/Auto.png";
            pctAuto.SizeMode = PictureBoxSizeMode.StretchImage;
            pctAuto.BackColor = Color.Transparent;

            pctAuto2.Visible = false;
            pctAuto2.ImageLocation = @"../../Images/Auto.png";
            pctAuto2.SizeMode = PictureBoxSizeMode.StretchImage;
            pctAuto2.BackColor = Color.Transparent;

            pctAlbero.ImageLocation = @"../../Images/albero.png";
            pctAlbero.SizeMode = PictureBoxSizeMode.StretchImage;
            pctAlbero.BackColor = Color.Transparent;

            pctSole.ImageLocation = @"../../Images/Sole.gif";
            pctSole.SizeMode = PictureBoxSizeMode.StretchImage;
            pctSole.BackColor = Color.Transparent;

            pctPalla.ImageLocation = @"../../Images/Palla.png";
            pctPalla.SizeMode = PictureBoxSizeMode.StretchImage;
            pctPalla.BackColor = Color.Transparent;

            pctpalla2.Visible = false;
            pctpalla2.ImageLocation = @"../../Images/Palla.png";
            pctpalla2.SizeMode = PictureBoxSizeMode.StretchImage;
            pctpalla2.BackColor = Color.Transparent;

            pctAlberopiccolo.ImageLocation = @"../../Images/AlberoPiccolo.png";
            pctAlberopiccolo.SizeMode = PictureBoxSizeMode.StretchImage;
            pctAlberopiccolo.BackColor = Color.Transparent;

            tmrAlbero.Enabled = true;
            tmrPalla.Enabled = true;
            tmrTestTocco.Enabled = true;
        }

        private void bttcrea_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyData)
            { 
                case Keys.D:
                    posizioneauto2 = posizioneauto;
                        if (posizioneauto < 380 )
                        {
                            pctAuto.Location = new Point(posizioneauto, 345);
                            posizioneauto += 5;

                            pctAuto2.Location = new Point(posizioneauto2, 416);
                            posizioneauto2 += 5;
                        }
                          
                    break;

                case Keys.A:
                    posizioneauto2 = posizioneauto;
                        if (posizioneauto > 10)
                        {
                            pctAuto.Location = new Point(posizioneauto, 345);
                            posizioneauto -= 5;

                            pctAuto2.Location = new Point(posizioneauto2, 416);
                            posizioneauto2-= 5;
                        }
                    break;

                case Keys.S:
                    pctAuto.Visible = false;
                    pctAuto2.Visible = true;
                    break;

                case Keys.W:
                    pctAuto.Visible = true;
                    pctAuto2.Visible = false;
                    break;      
            }//switch
        }

        private void tmrAlbero_Tick(object sender, EventArgs e)
        {
            if (posizionealbero > -5)
            {
                pctAlbero.Location = new Point(posizionealbero, 206);
                posizionealbero-=5;
            }
            else
            {
                posizionealbero = 332;
            }

            if (posizionealberopiccolo > -5)
            {
                pctAlberopiccolo.Location = new Point(posizionealberopiccolo, 247);
                posizionealberopiccolo -= 5;
            }
            else
            {
                posizionealberopiccolo = 332;
            }
        }

        private void tmrSpawnPalla_Tick(object sender, EventArgs e)
        {
            pctPalla.Visible = true;
            if (posizionepalla > 10)
            {
                pctPalla.Location = new Point(posizionepalla, 363);
                posizionepalla -= 5;
            }
            else
            {
                posizionepalla = 427;
                tmrPalla2.Enabled = true;
            }
        }

        private void tmrPalla2_Tick(object sender, EventArgs e)
        {
            pctpalla2.Visible = true;
            if (posizionepalla2 > 10)
            {
                pctpalla2.Location = new Point(posizionepalla2, 433);
                posizionepalla2 -= 5;
            }
            else
            {
                posizionepalla2 = 427;
            }
        }

        private void tmrTestTocco_Tick(object sender, EventArgs e)
        {
           if (pctAuto2.Visible == true)
            {
                if (posizionepalla2 == posizioneauto2)
                {
                    MessageBox.Show("Un Ragazzino ti ha distrutto la macchina...GAME OVER");
                    this.Close();
                }
            }
           if (pctAuto.Visible == true)
            {
                if (posizionepalla == posizioneauto)
                {
                    MessageBox.Show("Un Bambino ti ha distrutto la macchina...GAME OVER");
                    this.Close();
                }
            }

        }
    }
}
