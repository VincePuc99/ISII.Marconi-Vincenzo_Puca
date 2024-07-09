using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prova
{
    public partial class Form1 : Form
    {
        //variabili globali
        static int i;


        public Form1()
        {
            //inizializzo le variabili qui
            InitializeComponent();

            i = 0;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ///inizializzo i controlli
            txt.TextAlign = HorizontalAlignment.Center;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            i++;
            txt.Text = i.ToString();
            progressBar1.Value = i;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tmr.Enabled = true;
          
        }

        private void txt_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tmr.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            i = 0;
            txt.Text = "0";
           
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {
           
        }
    }
}
