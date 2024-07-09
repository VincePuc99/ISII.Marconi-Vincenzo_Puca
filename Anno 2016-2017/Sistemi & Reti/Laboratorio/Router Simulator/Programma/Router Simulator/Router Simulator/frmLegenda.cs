using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Router_Simulator
{
    public partial class frmLegenda : Form
    {
        public frmLegenda()
        {
            InitializeComponent();
        }

        private void frmLegenda_Load(object sender, EventArgs e)
        {
            this.Location = new Point(0, 0);
            this.ControlBox = false;

            label9.Text = Globals.IP[0];
            label11.Text = Globals.IP[1];
            label18.Text = Globals.IP[2];
            label19.Text = Globals.IP[3];
        }
    }
}
