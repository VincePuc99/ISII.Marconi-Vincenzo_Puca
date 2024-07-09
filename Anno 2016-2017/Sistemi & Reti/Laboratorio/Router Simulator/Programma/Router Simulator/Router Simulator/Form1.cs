using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace Router_Simulator
{
    public partial class frmmain : Form
    {
        private string startup = @"H:\Scuola ISII\Anno 2016-2017\Sistemi & Reti\Laboratorio\Router Simulator\Programma\startup_config.txt";
        private int contclick, conttick;
        private string IPDx, IPSx, SubDx, SubSx;
        private string ConfrIPImmessoFa1, ConfIPRandDx,ConfrIPImmessoFa0, ConfIPRandSx;

        private Router OggRouter = new Router();

        private Random randReti = new Random();

        public frmmain()
        {
            InitializeComponent();
            contclick = 0;
            conttick = 0;
        }

        private void frmmain_Load(object sender, EventArgs e)
        {
            CreaReti();
            pctTickDx.ImageLocation = @"../../Images/Tick.png";
            pctTickDx.SizeMode = PictureBoxSizeMode.StretchImage;
            pctTickDx.BackColor = Color.Transparent;

            pctTickSx.ImageLocation = @"../../Images/Tick.png";
            pctTickSx.SizeMode = PictureBoxSizeMode.StretchImage;
            pctTickSx.BackColor = Color.Transparent;

            pctRouter.ImageLocation = @"../../Images/Router.png";
            pctRouter.SizeMode = PictureBoxSizeMode.StretchImage;
            pctRouter.BackColor = Color.Transparent;

            Color GrigioRouter = ColorTranslator.FromHtml("#FFBDBDBD");
            label1.BackColor = GrigioRouter;

            Color BluComputer = ColorTranslator.FromHtml("#FF8EC4F4");
            label2.BackColor = BluComputer;

            bttLed.BackColor = Color.Red;
            label6.BackColor = GrigioRouter;

            bttinseriscicomandi.Enabled = false;

            pctFa0.ImageLocation = @"../../Images/Rj45.png";
            pctFa0.SizeMode = PictureBoxSizeMode.StretchImage;
            pctFa0.BackColor = GrigioRouter;

            pctFa1.ImageLocation = @"../../Images/Rj45.png";
            pctFa1.SizeMode = PictureBoxSizeMode.StretchImage;
            pctFa1.BackColor = GrigioRouter;

            pctConnessoFa0.ImageLocation = @"../../Images/Connesso.png";
            pctConnessoFa0.SizeMode = PictureBoxSizeMode.StretchImage;
            pctConnessoFa0.BackColor = GrigioRouter;

            pctConnessoFa1.ImageLocation = @"../../Images/Connesso.png";
            pctConnessoFa1.SizeMode = PictureBoxSizeMode.StretchImage;
            pctConnessoFa1.BackColor = GrigioRouter;

            pctComputer.ImageLocation = @"../../Images/Computer.png";
            pctComputer.SizeMode = PictureBoxSizeMode.StretchImage;
            pctComputer.BackColor = Color.Transparent;


            pctCavo.ImageLocation = @"../../Images/Cavo.png";
            pctCavo.SizeMode = PictureBoxSizeMode.StretchImage;
            pctCavo.BackColor = Color.Transparent;         
        }

        private void bttLed_Click(object sender, EventArgs e)
        {
            tmrPseudoReti.Enabled = true;
            contclick++;
            if (contclick % 2 != 0)
            {
                bttinseriscicomandi.Enabled = true;
                bttLed.BackColor = Color.Green;           
                //Accensione
                OggRouter.ColdStart();
               
                txtdisplay.Text = "startup_config cancellato e letto,Router Acceso,pronto per ricevere configurazioni.";    
            }
            else
            {
                bttAnalizza.Enabled = false;
                bttinseriscicomandi.Enabled = false;
                pctRouter.Enabled = false;
                pctFa0.Enabled = false;
                pctFa1.Enabled = false;
                bttLed.BackColor = Color.Red;
                //quando spegni il router cancella tutte le configurazioni
                OggRouter.CancellaStartUpConfig();

                txtdisplay.Text = "startup_config cancellato,Router spento.";

                pctConnessoFa1.Visible = false;
                pctConnessoFa0.Visible = false;

                bttping.Enabled = false;
            }
        }

        private void bttcarica_Click(object sender, EventArgs e)
        {
            this.Hide();
            OggRouter.CancellaStartUpConfig();

            Form frmLegenda = new frmLegenda();

            Process processo = new Process();
            ProcessStartInfo processoinfo = new ProcessStartInfo();

            frmLegenda.Show();

            processoinfo.FileName = startup;
            processo.StartInfo = processoinfo;

            processo.Start();

            processo.WaitForExit();

            frmLegenda.Close();

            txtdisplay.Text = "configurazioni vecchie eliminate e nuove inserite con successo.";
            
            this.Show();
            bttAnalizza.Enabled = true;
           
        }

        private void bttAnalizza_Click(object sender, EventArgs e)
        {
            OggRouter.AnalizzaCaricaConfig();
            txtdisplay.Text = "Comandi analizzati e inseriti correttamente nel Router.";

            pctFa0.Enabled = true;
            pctFa1.Enabled = true;
            pctRouter.Enabled = true;

            pctConnessoFa0.Visible = true;
            pctConnessoFa0.Enabled = true;
            pctConnessoFa1.Visible = true;
            pctConnessoFa1.Enabled = true;

            bttping.Enabled = true;
        }

        private void pctFa1_Click(object sender, EventArgs e)
        {
           MessageBox.Show("Porta: "+Globals.Ingressi[1].DENOMINAZIONE+" Bandwidth: "+Globals.Ingressi[1].BANDWIDTH+" Duplex: "+Globals.Ingressi[1].DUPLEX+
               " MAC: "+Globals.Ingressi[1].MAC+" IP: "+Globals.Ingressi[1].IP+" Subnetmask: "+Globals.Ingressi[1].SUBNETMASK);
        }

        private void pctFa0_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Porta: " + Globals.Ingressi[0].DENOMINAZIONE + " Bandwidth: " + Globals.Ingressi[0].BANDWIDTH + " Duplex: " + Globals.Ingressi[0].DUPLEX +
              " MAC: " + Globals.Ingressi[0].MAC + " IP: " + Globals.Ingressi[0].IP + " Subnetmask: " + Globals.Ingressi[0].SUBNETMASK);
        }

        private void pctConnessoFa0_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Porta: " + Globals.Ingressi[0].DENOMINAZIONE + "- Bandwidth: " + Globals.Ingressi[0].BANDWIDTH + "- Duplex: " + Globals.Ingressi[0].DUPLEX +
            "- MAC: " + Globals.Ingressi[0].MAC + "- IP: " + Globals.Ingressi[0].IP + "- Subnetmask: " + Globals.Ingressi[0].SUBNETMASK);
        }

        private void pctConnessoFa1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Porta: " + Globals.Ingressi[1].DENOMINAZIONE + "- Bandwidth: " + Globals.Ingressi[1].BANDWIDTH + "- Duplex: " + Globals.Ingressi[1].DUPLEX +
           "- MAC: " + Globals.Ingressi[1].MAC + "- IP: " + Globals.Ingressi[1].IP + "- Subnetmask: " + Globals.Ingressi[1].SUBNETMASK);
    
        }

        private void pctRouter_Click(object sender, EventArgs e)
        {
               txtdisplay.Text ="ID_Router: "+ OggRouter.DatiRouter[0];
               txtdisplay.Text +=" Hostname: "+ OggRouter.DatiRouter[1];
        }

        private void bttping_Click(object sender, EventArgs e)
        {
            ConfrontoRetiSxFa0();
            ConfrontoRetDxFa1();

            if (ConfrIPImmessoFa1 == ConfIPRandDx || Globals.Ingressi[0].SUBNETMASK == SubDx)
            {
                pctTickSx.Visible = true;
            }

            if (ConfrIPImmessoFa0 == ConfIPRandSx || Globals.Ingressi[1].SUBNETMASK == SubSx)
            {
                pctTickDx.Visible = true;
            }    
        }

        private void tmrPseudoReti_Tick(object sender, EventArgs e)
        {
            conttick++;
            if (conttick % 2 == 0)
            {
                txtReteDx.Text = "Sub: " + SubDx;
                txtReteSx.Text = "Sub: " + SubSx;         
            }
            else
            {
               txtReteDx.Text = "IP: " + IPDx;
               txtReteSx.Text = "IP: " + IPSx;   
            }
        }

        void CreaReti()///reti da modificare secondo criteri
        {
            int SubPrimoCampoDx = 0, SubSecondoCampoDx = 0, SubTerzoCampoDx = 0, SubQuartoCampoDx = 0;
            int SubPrimoCampoSx = 0, SubSecondoCampoSx = 0, SubTerzoCampoSx = 0, SubQuartoCampoSx = 0;

            //ip da modificare secondo criteri
            int PrimoCampoSx = randReti.Next(0, 255);
            int SecondoCampoSx = randReti.Next(0, 255);
            int TerzoCampoSx = randReti.Next(0, 255);
            int QuartoCampoSx = randReti.Next(0, 255);

            int[] ArrayValSub = new int[] { 128, 192, 224, 240, 248, 252, 254, 255 };

           

            if (PrimoCampoSx >= 0 && PrimoCampoSx < 128)
            {
                //Classe A
                SubPrimoCampoDx = ArrayValSub[randReti.Next(0, 8)];
                SubSecondoCampoDx = 0;
                SubTerzoCampoDx = 0;
                SubQuartoCampoDx = 0;
            }
            if (PrimoCampoSx >= 128 && PrimoCampoSx < 192)
            {
                //Classe B
                SubPrimoCampoDx = 255;
                SubSecondoCampoDx = ArrayValSub[randReti.Next(0, 8)];
                SubTerzoCampoDx = 0;
                SubQuartoCampoDx = 0;
            }
            if (PrimoCampoSx >= 192 && PrimoCampoSx < 224)
            {
                //Classe C
                SubPrimoCampoDx = 255;
                SubSecondoCampoDx = 255;
                SubTerzoCampoDx = ArrayValSub[randReti.Next(0, 8)];
                SubQuartoCampoDx = 0;
            }
            if (PrimoCampoSx >= 224 && PrimoCampoSx < 240)
            {
                //Classe D
                SubPrimoCampoDx = 255;
                SubSecondoCampoDx = 255;
                SubTerzoCampoDx = 255;
                SubQuartoCampoDx = ArrayValSub[randReti.Next(0, 8)];
            }
            if (PrimoCampoSx >= 240 && PrimoCampoSx < 255)
            {
                //Classe E
                //Non esiste subnet
                SubPrimoCampoDx = 0;
                SubSecondoCampoDx = 0;
                SubTerzoCampoDx = 0;
                SubQuartoCampoDx = 0;
            }

            int PrimoCampoDx = randReti.Next(0, 255);
            int SecondoCampoDx = randReti.Next(0, 255);
            int TerzoCampoDx = randReti.Next(0, 255);
            int QuartoCampoDx = randReti.Next(0, 255);

            if (PrimoCampoDx >= 0 && PrimoCampoDx < 128)
            {
                //Classe A
                SubPrimoCampoSx = ArrayValSub[randReti.Next(0, 8)];
                SubSecondoCampoSx = 0;
                SubTerzoCampoSx = 0;
                SubQuartoCampoSx = 0;
            }
            if (PrimoCampoDx >= 128 && PrimoCampoDx < 192)
            {
                //Classe B
                SubPrimoCampoSx = 255;
                SubSecondoCampoSx = ArrayValSub[randReti.Next(0, 8)];
                SubTerzoCampoSx = 0;
                SubQuartoCampoSx = 0;
            }
            if (PrimoCampoDx >= 192 && PrimoCampoDx < 224)
            {
                //Classe C
                SubPrimoCampoSx = 255;
                SubSecondoCampoSx = 255;
                SubTerzoCampoSx = ArrayValSub[randReti.Next(0, 8)];
                SubQuartoCampoSx = 0;
            }
            if (PrimoCampoDx >= 224 && PrimoCampoDx < 240)
            {
                //Classe D
                SubPrimoCampoSx = 255;
                SubSecondoCampoSx = 255;
                SubTerzoCampoSx = 255;
                SubQuartoCampoSx = ArrayValSub[randReti.Next(0, 8)];
            }
            if (PrimoCampoDx >= 240 && PrimoCampoDx < 255)
            {
                //Classe E
                //Non esiste subnet
                SubPrimoCampoSx = 0;
                SubSecondoCampoSx = 0;
                SubTerzoCampoSx = 0;
                SubQuartoCampoSx = 0;
            }


            //
            IPDx = "" + PrimoCampoDx + "." + SecondoCampoDx + "." + TerzoCampoDx + "." + QuartoCampoDx;
            IPSx = "" + PrimoCampoSx + "." + SecondoCampoSx + "." + TerzoCampoSx + "." + QuartoCampoSx;

            SubDx = "" + SubPrimoCampoDx + "." + SubSecondoCampoDx + "." + SubTerzoCampoDx + "." + SubQuartoCampoDx;
            SubSx = "" + SubPrimoCampoSx + "." + SubSecondoCampoSx + "." + SubTerzoCampoSx + "." + SubQuartoCampoSx;

            Globals.IP[0] = IPSx;
            Globals.IP[1] = SubSx;
            Globals.IP[2] = IPDx;
            Globals.IP[3] = SubDx;
        }

        void ConfrontoRetiSxFa0()
        {
            int cont = 0, cont1 = 0;
            string taglio = "", taglio1 = "";

            for (int i = 0; i < Globals.Ingressi[0].IP.Length; i++)
            {
                if (Globals.Ingressi[0].IP[i] == '.')
                {
                    cont++;
                    if (cont == 3)
                    {
                        taglio = Globals.Ingressi[0].IP.Substring(0, i);
                    }
                }

            }

            for(int s=0;s<IPSx.Length;s++)
            { 
                if (IPSx[s] == '.')
                {
                    cont1++;
                    if (cont1 == 3)
                    {
                        taglio1 = IPSx.Substring(0, s);
                    }
                }
            }

            ConfIPRandSx = taglio1;
            ConfrIPImmessoFa0 = taglio;

        }//fine metodo

        void ConfrontoRetDxFa1()
        {
            int cont = 0, cont1 = 0;
            string taglio = "", taglio1 = "";

            for (int i = 0; i < Globals.Ingressi[1].IP.Length; i++)
            {
                if (Globals.Ingressi[1].IP[i] == '.')
                {
                    cont++;
                    if (cont == 3)
                    {
                        taglio = Globals.Ingressi[1].IP.Substring(0, i);
                    }
                }
            }

            for(int s=0; s < IPDx.Length; s++)
            { 
                if (IPDx[s] == '.')
                {
                    cont1++;
                    if (cont1 == 3)
                    {
                        taglio1 = IPDx.Substring(0, s);
                    }
                }
            }

            ConfIPRandDx = taglio1;
            ConfrIPImmessoFa1 = taglio;

        }//fine metodo
    }
}
