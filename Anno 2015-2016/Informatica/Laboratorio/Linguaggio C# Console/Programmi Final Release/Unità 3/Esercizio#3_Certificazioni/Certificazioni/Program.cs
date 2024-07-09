using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Certificazioni
{
    class Program
    {
        static void Main(string[] args)
        {
            int scelta = 0;
            int esami1 = 0;
            string scelta1;
            int[] certificazioni = new int[5];
            bool[] sn = new bool[5];

            do
            {
                //Menu
                do
                {
                    Console.Clear();
                    Console.WriteLine("1) Inserimento delle valutazioni.");
                    Console.WriteLine("2) Visualizzazione esami sostenuti.");
                    Console.WriteLine("3) Visualizzazione di un esame sostenuto.");
                    Console.WriteLine("4) Visualizzione esami tra due punteggi.");
                    Console.WriteLine("5) Cancellazione esami insufficienti.");
                    Console.WriteLine("6) Scambiare valutazioni.");
                    Console.WriteLine("7) Termina il programma.");
                    Console.WriteLine("===============================================");

                    Console.Write("Inserisci il comando da eseguire  ► ");
                    scelta = Convert.ToInt32(Console.ReadLine());

                    if (scelta < 0 && scelta > 8)
                    {
                        Console.WriteLine("◄ COMANDO NON ESISTENTE ►");
                        Console.ReadLine();
                    }
                } while (scelta < 0 && scelta > 8);

                switch (scelta)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("Inserisci i tuoi punteggi dei tuoi esami\n\n(Se inserisci come punteggio zero sarà considerato\ncome un esame non sostenuto)");
                        //Windows7
                        do
                        {
                            Console.Write("Windows7  ► ");
                            esami1 = Convert.ToInt32(Console.ReadLine());
                            certificazioni[0] = esami1;
                        } while (esami1 < 0 || esami1 > 101);
                        //Videoscrittura
                        do
                        {
                            Console.Write("Videoscrittura  ► ");
                            esami1 = Convert.ToInt32(Console.ReadLine());
                            certificazioni[1] = esami1;
                        } while (esami1 < 0 || esami1 > 101);
                        //Presentazione
                        do
                        {
                            Console.Write("Presentazione  ► ");
                            esami1 = Convert.ToInt32(Console.ReadLine());
                            certificazioni[2] = esami1;
                        } while (esami1 < 0 || esami1 > 101);

                        //Database
                        do
                        {
                            Console.Write("Database  ► ");
                            esami1 = Convert.ToInt32(Console.ReadLine());
                            certificazioni[3] = esami1;
                        } while (esami1 < 0 || esami1 > 101);
                        //Reti
                        do
                        {
                            Console.Write("Reti  ► ");
                            esami1 = Convert.ToInt32(Console.ReadLine());
                            certificazioni[4] = esami1;
                        } while (esami1 < 0 || esami1 > 101);
                        
                        Console.ReadLine();
                        break;

                    case 2:
                        //Visualizzazione punteggi
                        Console.Clear();
                        if (certificazioni[0] != 0 || certificazioni[1] != 0 || certificazioni[2] != 0 || certificazioni[3] != 0 || certificazioni[4] != 0)
                        {
                            Console.WriteLine("========= Punteggi ==========");
                            if (certificazioni[0] != 0)
                            {
                                Console.WriteLine("Windows7  ► {0}", certificazioni[0]);
                            }
                            if (certificazioni[1] != 0)
                            {
                                Console.WriteLine("Videoscrittura  ► {0}", certificazioni[1]);
                            }
                            if (certificazioni[2] != 0)
                            {
                                Console.WriteLine("Presentazione  ► {0}", certificazioni[2]);
                            }
                            if (certificazioni[3] != 0)
                            {
                                Console.WriteLine("Database  ► {0}", certificazioni[3]);
                            }
                            if (certificazioni[4] != 0)
                            {
                                Console.WriteLine("Reti  ► {0}", certificazioni[4]);
                            }
                        }
                        else
                            Console.WriteLine("Nessun esame sostenuto");

                        Console.ReadLine();
                        break;

                    case 3:
                        Console.Clear();
                        do
                        {
                            Console.Write("Inserisci il nome dell'esame sostenuto  ► ");
                            scelta1 = Console.ReadLine().ToUpper();
                        } while (scelta1 != "WINDOWS7" && scelta1 != "VIDEOSCRITTURA" && scelta1 != "PRESENTAZIONE" && scelta1 != "DATABASE" && scelta1 != "RETI");

                        if (scelta1 == "WINDOWS7")
                        {
                            if (certificazioni[0] != 0)
                            {
                                Console.WriteLine("\nWindows7  ► {0}", certificazioni[0]);                            
                            }
                        }

                        if (scelta1 == "VIDEOSCRITTURA")
                        {
                            if (certificazioni[1] != 0)
                            {
                                Console.WriteLine("\nVideoscrittura  ► {0}", certificazioni[1]);
                            }
                        }


                        if (scelta1 == "PRESENTAZIONE")
                        {
                            if (certificazioni[2] != 0)
                            {
                                Console.WriteLine("\nPresentazione  ► {0}", certificazioni[2]);
                            }
                        }

                        if (scelta1 == "DATABASE")
                        {
                            if (certificazioni[3] != 0)
                            {
                                Console.WriteLine("\nDatabase  ► {0}", certificazioni[3]);
                            }
                        }

                        if (scelta1 == "RETI")
                        {
                            if (certificazioni[4] != 0)
                            {
                                Console.WriteLine("\nReti  ► {0}", certificazioni[4]);
                            }
                        }
                        
                        Console.ReadLine();
                        break;
                    case 4:

                        int rangemin, rangemax;

                        Console.Clear();
                        do
                        {
                            Console.Write("Inserisci una range minimo di valori: ");
                            rangemin = Convert.ToInt16(Console.ReadLine());

                            Console.Write("Inserisci una range massimo di valori: ");
                            rangemax = Convert.ToInt16(Console.ReadLine());

                            if (rangemin == rangemax)
                            {
                                Console.WriteLine("I PUNTEGGI DEVONO ESSERE DIVERSI...");
                            }

                        } while (rangemin == rangemax);

                        
                        if (rangemin < certificazioni[0] && rangemax > certificazioni[0])
                        {
                            Console.WriteLine("Il punteggio di Windows 7 è compreso tra {0} e {1}", rangemin, rangemax);
                            sn[0] = true;
                        }
                        
                        if (rangemin < certificazioni[1] && rangemax > certificazioni[1])
                        {
                            Console.WriteLine("Il punteggio di Videoscrittura è compreso tra {0} e {1}", rangemin, rangemax);
                            sn[1] = true;
                        }
                        
                        if (rangemin < certificazioni[2] && rangemax > certificazioni[2])
                        {
                            Console.WriteLine("Il punteggio di Presentazione è compreso tra {0} e {1}", rangemin, rangemax);
                            sn[2] = true;
                        }
                        
                        if (rangemin < certificazioni[3] && rangemax > certificazioni[3])
                        {
                            Console.WriteLine("Il punteggio di Database è compreso tra {0} e {1}", rangemin, rangemax);
                            sn[3] = true;
                        }
                        
                        if (rangemin < certificazioni[4] && rangemax > certificazioni[4])
                        {
                            Console.WriteLine("Il punteggio di Reti è compreso tra {0} e {1}", rangemin, rangemax);
                            sn[4] = true;
                        }

                        bool final = true;
                        foreach (bool a in sn)
                        {
                            final = a;
                        }

                        if (final == false)
                            Console.WriteLine("Nessun punteggio è compreso tra {0} e {1}", rangemin, rangemax);
                        Console.ReadLine();

                        break;

                    case 5:
                        Console.Clear();
                        int cont = 0;
                        for (int i = 0; i < 5; i++)
                        {
                            if (certificazioni[i] < 70)
                            {                               
                                certificazioni[i] = 0;
                                cont++;
                            }
                        }

                        if (cont > 0)
                        {
                            Console.WriteLine("Valutazioni insufficienti eliminate");                            
                        }
                        else
                            Console.WriteLine("Non c'è nessun voto insufficiente");

                        Console.ReadLine();
                        break;

                    case 6:                      
                        string scelta6 = "", scelta7 = "";

                        Console.Clear();
                        Console.WriteLine("Inserisci due esami in cui scambiare le valutazioni");
                        //Prima valutazione     
                        
                        do
                        {
                            Console.Write("Prima valutazione  ►");
                            scelta6 = Console.ReadLine().ToUpper();
                        } while (scelta6 != "WINDOWS7" && scelta6 != "VIDEOSCRITTURA" && scelta6 != "PRESENTAZIONE" && scelta6 != "DATABASE" && scelta6 != "RETI"); 

                        //Seconda valutazione
                        do
                        {
                            Console.Write("Seconda valutazione  ►");
                            scelta7 = Console.ReadLine().ToUpper();

                            if (scelta6 == scelta7)
                                Console.WriteLine("LE DUE VALUTAZIONI SONO UGUALI\n");

                        } while (scelta7 != "WINDOWS7" && scelta7 != "VIDEOSCRITTURA" && scelta7 != "PRESENTAZIONE" && scelta7 != "DATABASE" && scelta7 != "RETI" || scelta6 == scelta7);
                        
                        //Scambiare valori
                        int prima, dopo;

                        //WINDOWS7
                        if (scelta6 == "WINDOWS7")
                        {
                            if (scelta7 == "VIDEOSCRITTURA")
                            {                                
                                prima = certificazioni[0];
                                dopo = certificazioni[1];

                                dopo = certificazioni[0];
                                prima = certificazioni[1];
                            }

                            if (scelta7 == "PRESENTAZIONE")
                            {
                                prima = certificazioni[0];
                                dopo = certificazioni[2];

                                dopo = certificazioni[0];
                                prima = certificazioni[2];
                            }

                            if (scelta7 == "DATABASE")
                            {
                                prima = certificazioni[0];
                                dopo = certificazioni[3];

                                dopo = certificazioni[0];
                                prima = certificazioni[3];
                            }

                            if (scelta7 == "RETI")
                            {
                                prima = certificazioni[0];
                                dopo = certificazioni[4];

                                dopo = certificazioni[0];
                                prima = certificazioni[4];
                            }
                        }

                        //VIDEOSCRITTURA
                        if (scelta6 == "VIDEOSCRITTURA")
                        {
                            if (scelta7 == "WINDOWS7")
                            {                                
                                prima = certificazioni[0];
                                dopo = certificazioni[1];

                                dopo = certificazioni[0];
                                prima = certificazioni[1];
                            }
  
                            if (scelta7 == "PRESENTAZIONE")
                            {
                                prima = certificazioni[0];
                                dopo = certificazioni[2];

                                dopo = certificazioni[0];
                                prima = certificazioni[2];
                            }
    
                            if (scelta7 == "DATABASE")
                            {
                                prima = certificazioni[0];
                                dopo = certificazioni[3];

                                dopo = certificazioni[0];
                                prima = certificazioni[3];
                            }
        
                            if (scelta7 == "RETI")
                            {
                                prima = certificazioni[0];
                                dopo = certificazioni[4];

                                dopo = certificazioni[0];
                                prima = certificazioni[4];
                            }
                        }

                        //PRESENTAZIONE

                        if (scelta6 == "PRESENTAZIONE")
                        {
                            if (scelta7 == "WINDOWS7")
                            {
                                prima = certificazioni[0];
                                dopo = certificazioni[1];

                                dopo = certificazioni[0];
                                prima = certificazioni[1];
                            }

                            if (scelta7 == "VIDEOSCRITTURA")
                            {
                                prima = certificazioni[0];
                                dopo = certificazioni[2];

                                dopo = certificazioni[0];
                                prima = certificazioni[2];
                            }

                            if (scelta7 == "DATABASE")
                            {
                                prima = certificazioni[0];
                                dopo = certificazioni[3];

                                dopo = certificazioni[0];
                                prima = certificazioni[3];
                            }

                            if (scelta7 == "RETI")
                            {
                                prima = certificazioni[0];
                                dopo = certificazioni[4];

                                dopo = certificazioni[0];
                                prima = certificazioni[4];
                            }
                        }
                        //DATABASE
                        if (scelta6 == "DATABASE")
                        {
                            if (scelta7 == "WINDOWS7")
                            {
                                prima = certificazioni[0];
                                dopo = certificazioni[1];

                                dopo = certificazioni[0];
                                prima = certificazioni[1];
                            }

                            if (scelta7 == "VIDEOSCRITTURA")
                            {
                                prima = certificazioni[0];
                                dopo = certificazioni[2];

                                dopo = certificazioni[0];
                                prima = certificazioni[2];
                            }

                            if (scelta7 == "PRESENTAZIONE")
                            {
                                prima = certificazioni[0];
                                dopo = certificazioni[3];

                                dopo = certificazioni[0];
                                prima = certificazioni[3];
                            }

                            if (scelta7 == "RETI")
                            {
                                prima = certificazioni[0];
                                dopo = certificazioni[4];

                                dopo = certificazioni[0];
                                prima = certificazioni[4];
                            }
                        }

                        //RETI
                        if (scelta6 == "RETI")
                        {
                            if (scelta7 == "WINDOWS7")
                            {
                                prima = certificazioni[0];
                                dopo = certificazioni[1];

                                dopo = certificazioni[0];
                                prima = certificazioni[1];
                            }

                            if (scelta7 == "VIDEOSCRITTURA")
                            {
                                prima = certificazioni[0];
                                dopo = certificazioni[2];

                                dopo = certificazioni[0];
                                prima = certificazioni[2];
                            }

                            if (scelta7 == "PRESENTAZIONE")
                            {
                                prima = certificazioni[0];
                                dopo = certificazioni[3];

                                dopo = certificazioni[0];
                                prima = certificazioni[3];
                            }

                            if (scelta7 == "DATABASE")
                            {
                                prima = certificazioni[0];
                                dopo = certificazioni[4];

                                dopo = certificazioni[0];
                                prima = certificazioni[4];
                            }
                        }

                       
                        Console.ReadLine();
                        break;

                    case 7:
                        Console.WriteLine("===================================================");
                        Console.WriteLine("\nTermine programma. Premi <INVIO> per continuare");
                        Console.ReadLine();
                        return;
                }

            } while (true);








        }
    }
}
