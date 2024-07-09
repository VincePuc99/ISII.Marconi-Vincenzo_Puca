using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Router_Simulator
{
    class Router : Interfaccia
    {
        private string startup = @"H:\Scuola ISII\Anno 2016-2017\Sistemi & Reti\Laboratorio\Router Simulator\Programma\startup_config.txt";

        private StreamReader Leggi;
        private StreamWriter Scrivi;

        public string[] DatiRouter = new string[2];

        private string ID_Router, Hostname;

        public Router() 
        {
            ID_Router = "";
            Hostname = "";
        }

        public void ColdStart()
        {
            string riga;

            Scrivi = new StreamWriter(startup, false);
            Scrivi.Write("");
            Scrivi.Close();

            Leggi = new StreamReader(startup);
            while ((riga = Leggi.ReadLine()) != null)
            {
                //legge tutto il file vuoto
            }
            Leggi.Close();
        }

        public void CancellaStartUpConfig()
        {
            Scrivi = new StreamWriter(startup, false);
            Scrivi.Write("");
            Scrivi.Close();
        }

        public void AnalizzaCaricaConfig()
        {
            string RigaComandoLetta;

            Leggi = new StreamReader(startup);

            //comandi router
            RigaComandoLetta = Leggi.ReadLine();
            ID_Router = RigaComandoLetta;
            DatiRouter[0] = ID_Router;

            RigaComandoLetta = Leggi.ReadLine();
            Hostname = RigaComandoLetta;
            DatiRouter[1] = Hostname;

            //comandi interfaccie
            for (int i = 0; i < 2; i++)
            {
                RigaComandoLetta = Leggi.ReadLine();
                Denominazione = RigaComandoLetta;

                RigaComandoLetta = Leggi.ReadLine();
                int banda = int.Parse(RigaComandoLetta);
                BandWidth = banda;

                RigaComandoLetta = Leggi.ReadLine();
                Duplex = RigaComandoLetta;

                RigaComandoLetta = Leggi.ReadLine();
                MAc = RigaComandoLetta;

                RigaComandoLetta = Leggi.ReadLine();
                Ip = RigaComandoLetta;

                RigaComandoLetta = Leggi.ReadLine();
                SubnetMask = RigaComandoLetta;

                Globals.Ingressi[i] = new Interfaccia(Denominazione,Duplex,MAc,Ip,SubnetMask,banda);
            }

            Leggi.Close();
        }
    }
}
