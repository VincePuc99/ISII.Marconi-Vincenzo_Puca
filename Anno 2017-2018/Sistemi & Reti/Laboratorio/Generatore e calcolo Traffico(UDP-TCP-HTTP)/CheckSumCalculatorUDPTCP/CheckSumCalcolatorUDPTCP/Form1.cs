using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CheckSumCalcolatorUDPTCP
{
    public partial class Form1 : Form
    {
        public string sourceip, destinationip, protocol, lenght, udpsource, udpdestination, udplenght, udpdata, tcpheader, tcpdata;

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void bttcalcolatcp_Click(object sender, EventArgs e)
        {
            int sommahexindec;
            string sommahexindecstringa;
            string checksum;

            sourceip = calcolobinariohex(txtsourceip.Text);
            destinationip = calcolobinariohex(txtdestip.Text);
            protocol = calcolobinariohex(txtprotocol.Text);
            lenght = calcolobinariohex(txtlenght.Text);
            tcpheader = calcolobinariohex(txtTCPheader.Text);
            tcpdata = calcolobinariohex(txtTCPdata.Text);

            //somma hex in dec
            sommahexindec = Convert.ToInt32(sourceip, 16) + Convert.ToInt32(destinationip, 16)
            + Convert.ToInt32(protocol, 16) + Convert.ToInt32(lenght, 16) + Convert.ToInt32(tcpheader, 16) +
            Convert.ToInt32(tcpdata, 16);

            //risultato somma hex in binario (strnga)
            sommahexindecstringa = Convert.ToString(sommahexindec, 2);

            //complemento1

            long sommahexbinarioint;
            sommahexbinarioint = Int64.Parse(sommahexindecstringa.ToString());
            sommahexbinarioint = ~sommahexbinarioint;


            string risultato = sommahexbinarioint.ToString("X");


            //riporto il risultato complementato e convertito
            checksum = calcolobinariohex(sommahexbinarioint.ToString());
            txtrisultatotcp.Text = "" + checksum;

        }

        private void bttcalcolaudp_Click(object sender, EventArgs e)
        {
           int hexsommatodec;
           string sommahexbinariostringa;
           string checksum;

           sourceip = calcolobinariohex(txtsourceip.Text);
           destinationip = calcolobinariohex(txtdestip.Text);
           protocol = calcolobinariohex(txtprotocol.Text);
           lenght = calcolobinariohex(txtlenght.Text);
           udpsource = calcolobinariohex(txtudpsource.Text);
           udpdestination = calcolobinariohex(txtudpdestination.Text);
           udplenght = calcolobinariohex(txtudplenght.Text);
           udpdata = calcolobinariohex(txtudpdata.Text);


            //somma hex in decimale
            hexsommatodec = Convert.ToInt32(sourceip, 16) + Convert.ToInt32(destinationip, 16)
            + Convert.ToInt32(protocol, 16) + Convert.ToInt32(lenght, 16) + Convert.ToInt32(udpsource, 16) +
            Convert.ToInt32(udpdestination, 16) + Convert.ToInt32(udplenght, 16) + Convert.ToInt32(udpdata, 16);

            //risultato somma hex in binario
            sommahexbinariostringa = Convert.ToString(hexsommatodec, 2);

            //complemento1

            long sommahexbinarioint;
            sommahexbinarioint = Int64.Parse(sommahexbinariostringa);
            sommahexbinarioint = ~sommahexbinarioint;


            string risultato = sommahexbinarioint.ToString("X");


            //riporto il risultato somma complementato a 1 in hex e trovo il checksum
            checksum = calcolobinariohex(sommahexbinarioint.ToString());
            txtrisultatochecksumudp.Text = checksum;
        }

        public string calcolobinariohex(string stringabinario)
        {
            string convertito;
            StringBuilder risultato = new StringBuilder(stringabinario.Length / 8 + 1);
            int lunghezza = stringabinario.Length % 8;

            if (lunghezza != 0)
            {
                stringabinario = stringabinario.PadLeft(((stringabinario.Length / 8) + 1) * 8, '0');
            }

            for (int i = 0; i < stringabinario.Length; i += 8)
            {
                string ottobit = stringabinario.Substring(i, 8);
                risultato.AppendFormat("{0:X2}", Convert.ToByte(ottobit, 2));
            }

            convertito = risultato.ToString();
            return convertito;
        }

        private void rdbTCP_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbTCP.Checked == false)
            {
                grpUDP.Enabled = true;
                grpTCP.Enabled = false;
            }
            else { grpTCP.Enabled = true; grpUDP.Enabled = false; }
        }

        private void rdbUDP_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbTCP.Checked == false)
            {
                grpUDP.Enabled = true;
                grpTCP.Enabled = false;
            }
            else { grpTCP.Enabled = true; grpUDP.Enabled = false; }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
  
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void grpmodel_Enter(object sender, EventArgs e)
        {

        }
    }
}
