using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class frmmain : Form
    {
        private bool scrivo;
        private Graphics obJ;
        private SolidBrush Pennello;
        private SolidBrush PennelloGomma;
        private int dimpunta;
        private bool FaiNiente;

        public frmmain()
        {
            InitializeComponent();
            obJ = this.CreateGraphics();
            Pennello = new SolidBrush(Color.Black);
            PennelloGomma = new SolidBrush(Color.White);
            dimpunta = 10;
            scrivo = false;
            FaiNiente = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (!FaiNiente)
            {
                if (scrivo == true)
                {
                    if (cmbstyle.SelectedIndex == 0)
                    {
                        dimpunta = 5;

                        if (cmbcolor.SelectedIndex == 0)
                        {
                            Pennello = new SolidBrush(Color.Red);
                            obJ.FillEllipse(Pennello, e.X, e.Y, dimpunta, dimpunta);
                        }
                        else if (cmbcolor.SelectedIndex == 1)
                        {
                            Pennello = new SolidBrush(Color.Green);
                            obJ.FillEllipse(Pennello, e.X, e.Y, dimpunta, dimpunta);
                        }
                        else if (cmbcolor.SelectedIndex == 2)
                        {
                            Pennello = new SolidBrush(Color.Yellow);
                            obJ.FillEllipse(Pennello, e.X, e.Y, dimpunta, dimpunta);
                        }
                        else if (cmbcolor.SelectedIndex == 3)
                        {
                            Pennello = new SolidBrush(Color.Blue);
                            obJ.FillEllipse(Pennello, e.X, e.Y, dimpunta, dimpunta);
                        }
                        else
                        {
                            obJ.FillEllipse(Pennello, e.X, e.Y, dimpunta, dimpunta);
                        }
                       
                    }
                    else if (cmbstyle.SelectedIndex == 1)
                    {
                        dimpunta = 10;
                        if (cmbcolor.SelectedIndex == 0)
                        {
                            Pennello = new SolidBrush(Color.Red);
                            obJ.FillEllipse(Pennello, e.X, e.Y, dimpunta, dimpunta);
                        }
                        else if (cmbcolor.SelectedIndex == 1)
                        {
                            Pennello = new SolidBrush(Color.Green);
                            obJ.FillEllipse(Pennello, e.X, e.Y, dimpunta, dimpunta);
                        }
                        else if (cmbcolor.SelectedIndex == 2)
                        {
                            Pennello = new SolidBrush(Color.Yellow);
                            obJ.FillEllipse(Pennello, e.X, e.Y, dimpunta, dimpunta);
                        }
                        else if (cmbcolor.SelectedIndex == 3)
                        {
                            Pennello = new SolidBrush(Color.Blue);
                            obJ.FillEllipse(Pennello, e.X, e.Y, dimpunta, dimpunta);
                        }
                        else
                        {
                            obJ.FillEllipse(Pennello, e.X, e.Y, dimpunta, dimpunta);
                        }
                    }
                    else if (cmbstyle.SelectedIndex == 2)
                    {
                        dimpunta = 20;
                        if (cmbcolor.SelectedIndex == 0)
                        {
                            Pennello = new SolidBrush(Color.Red);
                            obJ.FillEllipse(Pennello, e.X, e.Y, dimpunta, dimpunta);
                        }
                        else if (cmbcolor.SelectedIndex == 1)
                        {
                            Pennello = new SolidBrush(Color.Green);
                            obJ.FillEllipse(Pennello, e.X, e.Y, dimpunta, dimpunta);
                        }
                        else if (cmbcolor.SelectedIndex == 2)
                        {
                            Pennello = new SolidBrush(Color.Yellow);
                            obJ.FillEllipse(Pennello, e.X, e.Y, dimpunta, dimpunta);
                        }
                        else if (cmbcolor.SelectedIndex == 3)
                        {
                            Pennello = new SolidBrush(Color.Blue);
                            obJ.FillEllipse(Pennello, e.X, e.Y, dimpunta, dimpunta);
                        }
                        else
                        {
                            obJ.FillEllipse(Pennello, e.X, e.Y, dimpunta, dimpunta);
                        }
                    }
                    else
                    {
                        dimpunta = 15;
                        if (cmbcolor.SelectedIndex == 0)
                        {
                            Pennello = new SolidBrush(Color.Red);
                            obJ.FillEllipse(Pennello, e.X, e.Y, dimpunta, dimpunta);
                        }
                        else if (cmbcolor.SelectedIndex == 1)
                        {
                            Pennello = new SolidBrush(Color.Green);
                            obJ.FillEllipse(Pennello, e.X, e.Y, dimpunta, dimpunta);
                        }
                        else if (cmbcolor.SelectedIndex == 2)
                        {
                            Pennello = new SolidBrush(Color.Yellow);
                            obJ.FillEllipse(Pennello, e.X, e.Y, dimpunta, dimpunta);
                        }
                        else if (cmbcolor.SelectedIndex == 3)
                        {
                            Pennello = new SolidBrush(Color.Blue);
                            obJ.FillEllipse(Pennello, e.X, e.Y, dimpunta, dimpunta);
                        }
                        else
                        {
                            obJ.FillEllipse(Pennello, e.X, e.Y, dimpunta, dimpunta);
                        }
                    }


                }
                else
                {
                    obJ.FillEllipse(PennelloGomma, e.X, e.Y, dimpunta, dimpunta);
                }
            }
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            if (!FaiNiente)
            {
                if (e.Button == MouseButtons.Left)
                {
                    scrivo = true;
                }
                else if (e.Button == MouseButtons.Right)
                {
                    scrivo = false;
                }
                else if (e.Button == MouseButtons.Middle)
                {
                    scrivo = true;
                }
            }


           
        }//fine click

        private void Form1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            MessageBox.Show("Disabilito...");
            FaiNiente = !FaiNiente;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void cmbstyle_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
