using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Barchetta
{
    public partial class frmMain : Form
    {
        Graphics objG;
        private int cont, statosole, giornitrascorsi;
        private Random ran = new Random();

        public frmMain()
        {
            InitializeComponent();
            statosole = 0;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            objG = this.CreateGraphics();
        }

        private void bttcrea_Click(object sender, EventArgs e)
        {   //barca e onda sono due picturebox fisse sullo sfondo
            //le altre invece hanno un bordo che esce dal form a sinistra per sfasare l'immagine
            txtGiorni.Visible = true;
            labelgiorni.Visible = true;
            txtGiorni.Text = "0";
            label1.Visible = false;

            pctSfondoSottoMare.BackColor = Color.DeepSkyBlue;
            bttcrea.Visible = false;

            pctLuna.SizeMode = PictureBoxSizeMode.Zoom;
            pctLuna.ImageLocation = @"../../Immagini/Luna.png";
            pctLuna.BackColor = Color.Transparent;

            pctSole.SizeMode = PictureBoxSizeMode.Zoom;
            pctSole.ImageLocation = @"../../Immagini/Sole.png";
            pctSole.BackColor = Color.Transparent;

            pctSoleTramonto.SizeMode = PictureBoxSizeMode.Zoom;
            pctSoleTramonto.ImageLocation = @"../../Immagini/Sole.png";
            pctSoleTramonto.BackColor = Color.Transparent;

            pctSoleAlba.SizeMode = PictureBoxSizeMode.Zoom;
            pctSoleAlba.ImageLocation = @"../../Immagini/Sole.png";
            pctSoleAlba.BackColor = Color.Transparent;

            pctBarca.SizeMode = PictureBoxSizeMode.Zoom;
            pctBarca.ImageLocation = @"../../Immagini/Barca.png";

            pctBarca2.SizeMode = PictureBoxSizeMode.Zoom;
            pctBarca2.ImageLocation = @"../../Immagini/Barca.png";

            pctBarca.BackgroundImage = Image.FromFile(@"../../Immagini/Onde.png");
            pctBarca2.BackgroundImage = Image.FromFile(@"../../Immagini/Onde.png");

            pctOnda2.BackgroundImage = Image.FromFile(@"../../Immagini/Onde.png");
            pctOnda.ImageLocation = @"../../Immagini/Onde.png";

            tmrOnde.Enabled = true;
            tmrcoralli.Enabled = true;
            tmrPesci.Enabled = true;
            tmrSole.Enabled = true;

            pctSabbia.Visible = true;
            pctOnda.Visible = true;
            pctOnda2.Visible = true;

            pctCorallo1.SizeMode = PictureBoxSizeMode.Zoom;
            pctCorallo1.ImageLocation = @"../../Immagini/CoralloRosso.png";
            pctCorallo1.BackColor = Color.Goldenrod;

            pctCoralloRossoFolto.SizeMode = PictureBoxSizeMode.Zoom;
            pctCoralloRossoFolto.ImageLocation = @"../../Immagini/CoralloRossoFolto.png";
            pctCoralloRossoFolto.BackColor = Color.Goldenrod;

            pctSqualo.SizeMode = PictureBoxSizeMode.StretchImage;
            pctSqualo.ImageLocation = @"../../Immagini/Squalo.png";
            pctSqualo.BackColor = Color.DeepSkyBlue;

            pctSqualo2.SizeMode = PictureBoxSizeMode.StretchImage;
            pctSqualo2.ImageLocation = @"../../Immagini/Squalo.png";
            pctSqualo2.BackColor = Color.DeepSkyBlue;

            pctCoralloConPesci.SizeMode = PictureBoxSizeMode.StretchImage;
            pctCoralloConPesci.ImageLocation = @"../../Immagini/CoralloConPesci.png";
            pctCoralloConPesci.BackColor = Color.Goldenrod;

            pctCoralloRossoBianco.SizeMode = PictureBoxSizeMode.StretchImage;
            pctCoralloRossoBianco.ImageLocation = @"../../Immagini/CoralloRossoBianco.png";
            pctCoralloRossoBianco.BackColor = Color.Goldenrod;

            pctCoralloRosso2.SizeMode = PictureBoxSizeMode.StretchImage;
            pctCoralloRosso2.ImageLocation = @"../../Immagini/CoralloRosso.png";
            pctCoralloRosso2.BackColor = Color.Goldenrod;

            pctCoralloConPesci2.SizeMode = PictureBoxSizeMode.StretchImage;
            pctCoralloConPesci2.ImageLocation = @"../../Immagini/CoralloConPesci.png";
            pctCoralloConPesci2.BackColor = Color.Goldenrod;

            pctCoralloRossoBianco2.SizeMode = PictureBoxSizeMode.StretchImage;
            pctCoralloRossoBianco2.ImageLocation = @"../../Immagini/CoralloRossoBianco.png";
            pctCoralloRossoBianco2.BackColor = Color.Goldenrod;

            
            pctPesceBlu.SizeMode = PictureBoxSizeMode.StretchImage;
            pctPesceBlu.ImageLocation = @"../../Immagini/PesceBlu.png";
            pctPesceBlu.BackColor = Color.DeepSkyBlue;

            pctPesceBlu2.SizeMode = PictureBoxSizeMode.StretchImage;
            pctPesceBlu2.ImageLocation = @"../../Immagini/PesceBlu.png";
            pctPesceBlu2.BackColor = Color.DeepSkyBlue;

            pctPesceRosso.SizeMode = PictureBoxSizeMode.StretchImage;
            pctPesceRosso.ImageLocation = @"../../Immagini/PesceRosso.png";
            pctPesceRosso.BackColor = Color.DeepSkyBlue;

            pctPesceRosso2.SizeMode = PictureBoxSizeMode.StretchImage;
            pctPesceRosso2.ImageLocation = @"../../Immagini/PesceRosso.png";
            pctPesceRosso2.BackColor = Color.DeepSkyBlue;

            pctNuvola.SizeMode = PictureBoxSizeMode.StretchImage;
            pctNuvola.ImageLocation = @"../../Immagini/Nuvola.png";
            pctNuvola.BackColor = Color.Transparent;

            pctNuvola1.SizeMode = PictureBoxSizeMode.StretchImage;
            pctNuvola1.ImageLocation = @"../../Immagini/Nuvola.png";
            pctNuvola1.BackColor = Color.Transparent;

            pctNuvola2.SizeMode = PictureBoxSizeMode.StretchImage;
            pctNuvola2.ImageLocation = @"../../Immagini/Nuvola.png";
            pctNuvola2.BackColor = Color.Transparent;
        }

        private void tmrOnde_Tick(object sender, EventArgs e)
        {
            switch (cont)
            { 
                case 1:
                    pctOnda2.Visible = false;
                    pctBarca2.Visible = true;
                    pctSqualo.Visible = true;
                    pctSqualo2.Visible = false;
                    pctPesceRosso.Visible = false;
                    pctPesceRosso2.Visible = true;
                    pctPesceBlu.Visible = true;
                    pctPesceBlu2.Visible = false;
                    break;
                case 2:
                    pctOnda2.Visible = true;
                    pctBarca2.Visible = false;
                    pctSqualo.Visible = false;
                    pctSqualo2.Visible = true;
                     pctPesceRosso.Visible = true;
                    pctPesceRosso2.Visible = false;
                     pctPesceBlu.Visible = false;
                    pctPesceBlu2.Visible = true;
                    cont = 0;
                    break;  
            }
            cont++;
        }

        private void tmrcoralli_Tick(object sender, EventArgs e)
        {

            switch (ran.Next(0, 3))
            {
                case 0:
                    pctCorallo1.Visible = false;
                    pctCoralloConPesci2.Visible = false;
                    pctCoralloRossoBianco.Visible = false;

                    pctCoralloConPesci.Visible = true;
                    pctCoralloRossoBianco2.Visible = true;
                    pctCoralloRosso2.Visible = true;

                    pctCoralloRossoFolto.Visible = true;
                    pctCoralloConPesci2.Visible = true;
                    pctCoralloConPesci.Visible = true;

                    pctNuvola.Visible = true;
                    pctNuvola1.Visible = true;
                    pctNuvola2.Visible = false;
                    break;
                case 1:
                    pctCorallo1.Visible = true;
                    pctCoralloConPesci2.Visible = true;
                    pctCoralloConPesci.Visible = true;

                    pctCoralloRossoFolto.Visible = true;
                    pctCoralloConPesci2.Visible = true;
                    pctCoralloRossoBianco.Visible = true;

                    pctCoralloConPesci.Visible = false;
                    pctCoralloRossoBianco2.Visible = false;
                    pctCoralloRosso2.Visible = false;

                    pctNuvola.Visible = false;
                    pctNuvola1.Visible = false;
                    pctNuvola2.Visible = true;
                    break;

                case 2:
                    pctCoralloConPesci.Visible = true;
                    pctCoralloRossoBianco2.Visible = true;
                    pctCoralloRosso2.Visible = true;

                    pctCoralloRossoFolto.Visible = false;
                    pctCoralloConPesci2.Visible = false;
                    pctCoralloConPesci.Visible = false;

                    pctCorallo1.Visible = true;
                    pctCoralloConPesci2.Visible = true;
                    pctCoralloRossoBianco.Visible = true;

                    pctNuvola.Visible = false;
                    pctNuvola1.Visible = true;
                    pctNuvola2.Visible = true;
                    break;
            }
        }

        private void tmrPesci_Tick(object sender, EventArgs e)
        {
            switch (ran.Next(1,3))
            {
                case 1:
                    pctSqualo.Visible = true;
                    pctSqualo2.Visible = false;
                    break;
                case 2:
                    pctSqualo.Visible = false;
                    pctSqualo2.Visible = true;
                    break;
            }     
        }

        private void tmrSole_Tick(object sender, EventArgs e)
        {
            if (statosole == 3)
            {
                this.BackColor = Color.Black;
                pctSoleTramonto.Visible = false;
                pctSoleAlba.Visible = false;
                pctSole.Visible = false;

                pctLuna.Visible = true; 
                giornitrascorsi++;
                txtGiorni.Text = "" + giornitrascorsi;
                statosole = 0;
                goto fine;
            }

            if (statosole == 2)
            {
                pctSoleTramonto.Visible = true;
                pctSoleAlba.Visible = false;
                pctSole.Visible = false;
            }

            if (statosole == 1)
            {
                pctSole.Visible = true;
                pctSoleAlba.Visible = false;
                pctSoleTramonto.Visible = false;
            }

            if (statosole == 0)
            {
                pctLuna.Visible = false;
                this.BackColor = Color.LightSkyBlue;
                pctSoleAlba.Visible = true;
                pctSole.Visible = false;
                pctSoleTramonto.Visible = false;
            }

            statosole++;
            fine:
            int c;
      
            
        }

        private void tmrNuvole_Tick(object sender, EventArgs e)
        {
            switch (ran.Next(0, 3))
            {
                case 0:
                    pctNuvola.Visible = true;
                    pctNuvola1.Visible = true;
                    pctNuvola2.Visible = false;
                    break;
                case 1:
                    pctNuvola.Visible = false;
                    pctNuvola1.Visible = false;
                    pctNuvola2.Visible = true;
                    break;

                case 2:
                    pctNuvola.Visible = false;
                    pctNuvola1.Visible = true;
                    pctNuvola2.Visible = true;
                    break;
            }
        }
    }
}
