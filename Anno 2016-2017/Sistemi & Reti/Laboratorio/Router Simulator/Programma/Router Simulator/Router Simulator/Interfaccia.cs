using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Router_Simulator
{
    public class Interfaccia
    {
        protected string Denominazione, Duplex, MAc, Ip, SubnetMask;
        protected int BandWidth;

        public Interfaccia()
        { Denominazione = ""; Duplex = ""; MAc = ""; Ip = ""; SubnetMask = ""; BandWidth = 0; }

        public Interfaccia(string deno,string duple,string mac,string ip,string subnet,int band)
        { Denominazione = deno; Duplex = duple; MAc = mac; Ip = ip; ; SubnetMask = subnet; ; BandWidth = band; }

        public string DENOMINAZIONE { get {return Denominazione;} set { Denominazione=value; } }
        public string DUPLEX { get { return Duplex; } set { Duplex = value; } }
        public string MAC { get { return MAc; } set { MAc = value; } }
        public string IP { get { return Ip; } set { Ip = value; } }
        public string SUBNETMASK { get { return SubnetMask; } set { SubnetMask = value; } }
        public int BANDWIDTH { get { return BandWidth; } set { BandWidth = value; } }
    }
}
