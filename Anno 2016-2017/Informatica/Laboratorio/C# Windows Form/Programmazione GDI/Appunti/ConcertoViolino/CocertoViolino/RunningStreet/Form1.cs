using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RunningStreet
{
    public partial class frmMain : Form
    {
         // Attributi
        private Graphics G;
        private SolidBrush Pennello;
        private Pen Penna;
        private Rectangle PosizioneSpettatore;
        private Rectangle PosizioneViolinista;
        private Rectangle PosizionePosti;
        private Image Spettatore;
        private Image Violinista;
        private Image Posti;
        private int SunPos = 0;
        private int CarPos = 0;
        private int f = 0;
        private int ff = 0;
        private Random r;

        public frmMain()
        {
            InitializeComponent();

            r = new Random();

            G = this.CreateGraphics();
            Penna = new Pen(Color.Blue);
            Pennello = new SolidBrush(Color.Green);

            PosizioneViolinista = new Rectangle(200, 0, 400, 300);
            Violinista = Image.FromFile(@"../../v1.jpg");

            PosizionePosti = new Rectangle(0, 0, 400, 300);
            Posti = Image.FromFile(@"d:\scena\posti.jpg");

            PosizioneSpettatore = new Rectangle(0, 0, 20, 20);
            Spettatore = Image.FromFile(@"d:\scena\Spettatore.jpg");
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.Black ;

            tmr2.Enabled = true;

        }

        private void frmMain_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void btnDisegna_Click(object sender, EventArgs e)
        {
            
            tmr1.Enabled = true;
         }

        // Gestisce il concerto
        void tmr1_Tick(object sender, EventArgs e)
        {
            
            switch (f)
            {
                case 0:
                    PosizioneViolinista = new Rectangle(80, 10, 400, 300);
                    Violinista = Image.FromFile(@"d:\scena\v1.jpg");
                    G.DrawImage(Violinista, PosizioneViolinista);
                    break;

                case 1:
                    PosizioneViolinista = new Rectangle(80, 10, 400, 300);
                    Violinista = Image.FromFile(@"d:\scena\v2.jpg");
                    G.DrawImage(Violinista, PosizioneViolinista);
                    break;

                case 2:
                    PosizioneViolinista = new Rectangle(80, 10, 400, 300);
                    Violinista = Image.FromFile(@"d:\scena\v3.jpg");
                    G.DrawImage(Violinista, PosizioneViolinista);
                    break;
            }

            f++;
            f = f % 3;
            //this.Focus();
           
            
        }

     

        private void frmMain_KeyPress(object sender, KeyPressEventArgs e)
        {
            
         
        }

        private void frmMain_MouseClick(object sender, MouseEventArgs e)
        {

            if (e.Button == MouseButtons.Left)
            {
                tmr1.Enabled = true;

            }

            if (e.Button == MouseButtons.Right)
            {
                tmr1.Enabled = false;

            }

             
        }

        private void tmr2_Tick(object sender, EventArgs e)
        {
            // Posti spettatori
            if (ff == 0)
            {
                PosizionePosti = new Rectangle(0, 330, 550, 200);
                Posti = Image.FromFile(@"d:\scena\posti.jpg");
                G.DrawImage(Posti, PosizionePosti);
                ff++;

                // Violinista
                PosizioneViolinista = new Rectangle(80, 10, 400, 300);
                Violinista = Image.FromFile(@"d:\scena\v9.jpg");
                G.DrawImage(Violinista, PosizioneViolinista);

                return;
            }

            // Posti spettatori
            PosizionePosti = new Rectangle(0, 330, 550, 200);
            Posti = Image.FromFile(@"d:\scena\posti.jpg");
            G.DrawImage(Posti, PosizionePosti);

            // Spettatori seduti
            // I fila
            for (int ns = 0; ns < 12; ns++ )
                if (r.Next(0, 1000) < 950)
                {
                    PosizioneSpettatore = new Rectangle(10+(50*ns), 370, 30, 30);
                    Spettatore = Image.FromFile(@"d:\scena\Spettatore.jpg");
                    G.DrawImage(Spettatore, PosizioneSpettatore);
                }
            

            // II file
            
            for (int ns = 0; ns < 12; ns++)
                if (r.Next(0, 1000) < 850)
                {
                    PosizioneSpettatore = new Rectangle(10 + (50 * ns), 460, 30, 30);
                    Spettatore = Image.FromFile(@"d:\scena\Spettatore.jpg");
                    G.DrawImage(Spettatore, PosizioneSpettatore);
                }
            ////////////////////////////////////////////////////

            tmr2.Interval = 5000;
        }
    }
}
