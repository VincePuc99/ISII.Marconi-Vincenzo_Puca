using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace rubinetto
{
    public partial class Frmmain : Form
    {
        private Graphics ObjG;
        private int statoAcqua = 300;

        public Frmmain()
        {
            InitializeComponent();
            CoordinateCrea();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ObjG = this.CreateGraphics();
        }

        private void bttcrea_Click(object sender, EventArgs e)
        {
            CreaTovaglia();
            CreaBicchiere();       
            CreaRubinetto();

            Linee();

            bttcrea.Enabled = false;
            bttcrea.Visible = false;

            label1.Visible = true;
            label2.Visible = true;

            bttesci.Visible = true;
            bttesci.Enabled = true;
        }//pulsante

        void Linee()
        {
            ObjG.DrawLine(new Pen(Color.Black), 0, 100, 500, 100);
            ObjG.DrawLine(new Pen(Color.Black), 185, 100, 185, 0);
        }
        void CreaRubinetto()
        {
            pct.ImageLocation = @"../../images/rubinetto.jpg";
            ObjG.FillRectangle(new SolidBrush(Color.LightGray), 0, 140, 185, 110);
        }

        void CreaTovaglia()
        {
            ObjG.FillRectangle(new SolidBrush(Color.Red), 0, 250, 500, 250);
            for (int i = 300; i < 500; i += 50)
            {
                ObjG.DrawLine(new Pen(Color.Yellow,2), 0, i, 500, i);
            }

            int f = 0;

            for (int i = 50; i < 600; i += 50)
            {
                ObjG.DrawLine(new Pen(Color.Yellow,2), i, 250, f, 500);
                f += 50;
            }
        }

        void CreaBicchiere()
        {
            ObjG.DrawEllipse(new Pen(Color.LightBlue), 190, 150, 150, 30);//alto
            ObjG.DrawLine(new Pen(Color.LightBlue), 190, 170, 190, 315);//sinistra
            ObjG.DrawLine(new Pen(Color.LightBlue), 340, 170, 340, 315);//destra
            ObjG.DrawEllipse(new Pen(Color.LightBlue), 190, 300, 150, 30);//fondo
        }

        void AggiungiAcqua()
        {
            if (statoAcqua > 150)//limite
            {
                ObjG.FillEllipse(new SolidBrush(Color.LightBlue), 190, statoAcqua, 150, 30);
                statoAcqua -= 5;
            }
            else//reset acqua
            {
                tmrAggiungi.Enabled = false;

                CancFlusso();

                for(int f=150;f<300;f++)
                {
                 ObjG.FillEllipse(new SolidBrush(Color.White), 191, f, 150, 30);
                }

                ObjG.FillEllipse(new SolidBrush(Color.White), 260, 140, 30, 180);

                //ricostruzione
                CreaTovaglia();
                CreaBicchiere();

                statoAcqua = 300;
            }
  
        }

        void Flusso()
        {
            ObjG.FillEllipse(new SolidBrush(Color.LightBlue), 260, 140, 30, 180);       
        }

        void CancFlusso()
        {
            for (int i = 30; i > 0; i--)
            {
                ObjG.DrawEllipse(new Pen(Color.White), 260, 140, i, 180);
                Thread.Sleep(30);

                CreaTovaglia();
                CreaBicchiere();

                for (int g = 300; g > statoAcqua; g -= 5)
                {
                    ObjG.FillEllipse(new SolidBrush(Color.LightBlue), 190, g, 150, 30);
                }
            }         
        }

        private void tmrAggiungi_Tick(object sender, EventArgs e)
        {
            AggiungiAcqua();
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (e.X < 185 && e.Y < 100)
                {
                    tmrAggiungi.Enabled = true;
                    Flusso();
                }
            }

            if (e.Button == MouseButtons.Right)
            {
                if (e.X > 185 && e.Y < 100)
                {
                    tmrAggiungi.Enabled = false;
                    CancFlusso();
                }         
            }       
        }//click

        //Coordinate
        private TextBox txtX = new TextBox();
        private TextBox txtY = new TextBox();

        void CoordinateCrea()
        {              
                txtX.Size = new Size(24, 20);
                txtX.Location = new Point(0, 0);
                txtX.ReadOnly = true;
                txtX.Enabled = false;
                this.Controls.Add(txtX);
           
                txtY.Size = new Size(24, 20);
                txtY.Location = new Point(25, 0);
                txtY.ReadOnly = true;
                txtY.Enabled = false;
                this.Controls.Add(txtY);
        }

        void CoordinateUsa(MouseEventArgs e)
        {
            txtX.Text = "" + e.X;
            txtY.Text = "" + e.Y;
        }

        private void Frmmain_MouseMove(object sender, MouseEventArgs e)
        {
            CoordinateUsa(e);
        }

        private void bttesci_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
