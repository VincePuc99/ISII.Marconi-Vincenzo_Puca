using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Carrace
{
    public partial class frmmain : Form
    {
       private Graphics objG;
       private Rectangle rect;
        private int statorighe;
        private int Xautomobile;
     
        public frmmain()
        {
            InitializeComponent();
            statorighe = 0;
            Xautomobile = 280;
        }

        private void frmmain_Load(object sender, EventArgs e)
        {
            objG = this.CreateGraphics();
            this.BackColor = Color.DarkOliveGreen;
        }

        private void bttstart_Click(object sender, EventArgs e)
        {
            tmrVai.Enabled = true;
            //disegna cielo
            objG.FillRectangle(new SolidBrush(Color.Blue),
                0,0,480,200);

            //disegna sole
            objG.FillEllipse(new SolidBrush(Color.Yellow),
                200,50,100, 100);

            //disegna strada
            for (int i = 0; i < 300; i++) 
            {
                objG.DrawLine(new Pen(Color.Black),
                    150-i, 200+i, 350+i, 200+i);
            }
            //disegna linea di mezzaria
            DisegnaRighe();

            //disegna automobile
            DisegnaAutomobile(Xautomobile);

        }

        void DisegnaAutomobile(int Xstart)
        {
            objG.FillEllipse(new SolidBrush(Color.Red),
                Xstart, 300, 50, 100);
        }

        void CancellaAutomobile(int Xstart)
        {
            objG.FillEllipse(new SolidBrush(Color.Black),
                Xstart, 300, 50, 100);
        }

        void CancellaRighe()
        {
            objG.FillRectangle(new SolidBrush(Color.Black),
              250, 220, 10, 30);

            objG.FillRectangle(new SolidBrush(Color.Black),
               250, 260, 10, 30);

            objG.FillRectangle(new SolidBrush(Color.Black),
               250, 300, 10, 30);

            objG.FillRectangle(new SolidBrush(Color.Black),
               250, 340, 10, 30);

            objG.FillRectangle(new SolidBrush(Color.Black),
               250, 380, 10, 30);
        }

        void DisegnaRighe()
        {
            objG.FillRectangle(new SolidBrush(Color.White),
               250, 220, 10, 30);

            objG.FillRectangle(new SolidBrush(Color.White),
               250, 260, 10, 30);

            objG.FillRectangle(new SolidBrush(Color.White),
               250, 300, 10, 30);

            objG.FillRectangle(new SolidBrush(Color.White),
               250, 340, 10, 30);

            objG.FillRectangle(new SolidBrush(Color.White),
               250, 380, 10, 30);
        }

        void RiCancellaRighe()
        {
            objG.FillRectangle(new SolidBrush(Color.Black),
              250, 240, 10, 30);

            objG.FillRectangle(new SolidBrush(Color.Black),
               250, 280, 10, 30);

            objG.FillRectangle(new SolidBrush(Color.Black),
               250, 320, 10, 30);

            objG.FillRectangle(new SolidBrush(Color.Black),
               250, 360, 10, 30);

            objG.FillRectangle(new SolidBrush(Color.Black),
               250, 400, 10, 30);
        }
        void RiDisegnaRighe()
        {
            objG.FillRectangle(new SolidBrush(Color.White),
               250, 240, 10, 30);

            objG.FillRectangle(new SolidBrush(Color.White),
               250, 280, 10, 30);

            objG.FillRectangle(new SolidBrush(Color.White),
               250, 320, 10, 30);

            objG.FillRectangle(new SolidBrush(Color.White),
               250, 360, 10, 30);

            objG.FillRectangle(new SolidBrush(Color.White),
               250, 400, 10, 30);
        }

        private void tmrVai_Tick(object sender, EventArgs e)
        {
            switch (statorighe)
            {
                case 0:
                    DisegnaRighe();
                    break;
                case 1:
                    CancellaRighe();
                    break;
                case 2:
                    RiDisegnaRighe();
                    break;
                case 3:
                    RiCancellaRighe();
                    break;
            }
            statorighe = (statorighe+1) % 4;
          
        }//fine timer

        private void frmmain_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                CancellaAutomobile(Xautomobile);
                Xautomobile-=10;
                DisegnaAutomobile(Xautomobile);
            }
            else //click tasto destro
            {
                CancellaAutomobile(Xautomobile);
                Xautomobile+=10;
                DisegnaAutomobile(Xautomobile);
            }
        }//fine click

        private void frmmain_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.X < Xautomobile)
            {
                CancellaAutomobile(Xautomobile);
                Xautomobile --;
                DisegnaAutomobile(Xautomobile);
            }
            else 
            {
                CancellaAutomobile(Xautomobile);
                Xautomobile ++;
                DisegnaAutomobile(Xautomobile);
            }
        }//fine move
    }
}
