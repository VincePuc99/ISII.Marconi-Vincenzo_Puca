using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRace
{
    public partial class frmMain : Form
    {
        private Graphics objG;
        private TextBox txtX = new TextBox();
        private TextBox txtY = new TextBox();

        public frmMain()
        {
            InitializeComponent();
            CoordinateCrea();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            objG = this.CreateGraphics();
        }

        private void frmMain_MouseMove(object sender, MouseEventArgs e)
        {
            CoordinateUsa(e);
        }

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

        private void bttcrea_Click(object sender, EventArgs e)
        {
            CreaCieloErba();
            CreaStrada();
            CreaSoleNuvole();
            CreaLinee();
        }

        void CreaLinee()
        {
           
            for (int  i = 0; i < 40; i++)
            {
                objG.DrawLine(new Pen(Color.White), 240, 205+i, 245, 205+i);
            }
        }

        void CreaSoleNuvole()
        {
            //Sole
            objG.FillEllipse(new SolidBrush(Color.Yellow), 220, 20, 50, 50);

            //Nuvole destra
            objG.FillEllipse(new SolidBrush(Color.White), 280, 25, 30, 30);
            objG.FillEllipse(new SolidBrush(Color.White), 300, 25, 30, 30);
            objG.FillEllipse(new SolidBrush(Color.White), 290, 20, 30, 30);

            //Nuvole sinistra
            objG.FillEllipse(new SolidBrush(Color.White), 160, 15, 30, 30);
            objG.FillEllipse(new SolidBrush(Color.White), 180, 15, 30, 30);
            objG.FillEllipse(new SolidBrush(Color.White), 170, 10, 30, 30);
        }

        void CreaStrada()
        {
            for (int i = 0; i < 270; i++)
            {
                objG.DrawLine(new Pen(Color.Black), 115 - i, 200 + i, 368 + i, 200 + i);
            }         
        }

        void CreaCieloErba()
        {
            objG.FillRectangle(new SolidBrush(Color.LightSkyBlue), 0, 0, 500, 200);
            objG.FillRectangle(new SolidBrush(Color.ForestGreen), 0, 200, 500, 300);
        }

    }
}
