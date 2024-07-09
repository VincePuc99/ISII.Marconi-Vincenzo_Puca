using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Albergo
{
    class Program
    {
        static void Main(string[] args)
        {
            int stanza, letti, scelta, cont = 0, cont1 = 0, stanzi,numero,numero1;
            bool[] stanza1 = new bool[7];
            int[] lettitab = new int[7];
            string sn;


            do
            {
                do
                {
                    Console.Write("Inserire il numero della stanza da prenotare: ");
                    stanza = Convert.ToInt16(Console.ReadLine());                    

                    if (1 > stanza || stanza > 7)
                    {
                        Console.WriteLine("Numero di stanza non disponibile");
                    }
                } while (1 > stanza || stanza > 7);

                do
                {
                    Console.Write("Inserire il numero dei letti da inserire: ");
                    letti = Convert.ToInt16(Console.ReadLine());

                    if (1 > letti || letti > 3)
                    {
                        Console.WriteLine("Numero di letti non consentito");
                    }
                } while (1 > letti || letti > 3);
                

                switch (stanza)
                {
                    case 1:
                        if (stanza1[0] == false)
                        {
                            stanza1[0] = true;
                            Console.WriteLine("Stanza libera!!! Numero stanza '1'");
                            lettitab[0] = letti;
                            Console.WriteLine("Numero di letti inseriti: {0}", lettitab[0]);
                        }
                        else
                            Console.WriteLine("Stanza occupata cambia la tua scelta!");
                        break;

                    case 2:
                        if (stanza1[1] == false)
                        {
                            stanza1[1] = true;
                            Console.WriteLine("Stanza libera!!! Numero stanza '2'");
                            lettitab[1] = letti;
                            Console.WriteLine("Numero di letti inseriti: {0}", lettitab[1]);
                        }
                        else
                            Console.WriteLine("Stanza occupata cambia la tua scelta!");
                        break;

                    case 3:
                        if (stanza1[2] == false)
                        {
                            stanza1[2] = true;
                            Console.WriteLine("Stanza libera!!! Numero stanza '3'");
                            lettitab[2] = letti;
                            Console.WriteLine("Numero di letti inseriti: {0}", lettitab[2]);
                        }
                        else
                            Console.WriteLine("Stanza occupata cambia la tua scelta!");
                        break;

                    case 4:
                        if (stanza1[3] == false)
                        {
                            stanza1[3] = true;
                            Console.WriteLine("Stanza libera!!! Numero stanza '4'");
                            lettitab[3] = letti;
                            Console.WriteLine("Numero di letti inseriti: {0}", lettitab[3]);
                        }
                        else
                            Console.WriteLine("Stanza occupata cambia la tua scelta!");
                        break;

                    case 5:
                        if (stanza1[4] == false)
                        {
                            stanza1[4] = true;
                            Console.WriteLine("Stanza libera!!! Numero stanza '5'");
                            lettitab[4] = letti;
                            Console.WriteLine("Numero di letti inseriti: {0}", lettitab[4]);
                        }
                        else
                            Console.WriteLine("Stanza occupata cambia la tua scelta!");
                        break;

                    case 6:
                        if (stanza1[5] == false)
                        {
                            stanza1[5] = true;
                            Console.WriteLine("Stanza libera!!! Numero stanza '6'");
                            lettitab[5] = letti;
                            Console.WriteLine("Numero di letti inseriti: {0}", lettitab[5]);
                        }
                        else
                            Console.WriteLine("Stanza occupata cambia la tua scelta!");
                        break;

                    case 7:
                        if (stanza1[6] == false)
                        {
                            stanza1[6] = true;
                            Console.WriteLine("Stanza libera!!! Numero stanza '7'");
                            lettitab[6] = letti;
                            Console.WriteLine("Numero di letti inseriti: {0}", lettitab[6]);
                        }
                        else
                            Console.WriteLine("Stanza occupata cambia la tua scelta!");
                        break;
                }

                Console.Write("Hai finito con le prenotazioni? (SI)--(NO): ");
                sn = Console.ReadLine();
                sn = sn.ToUpper();

                if (sn == "SI")
                {
                    continue;
                }

            } while (sn == "NO");

            Thread.Sleep(1000);
            Console.Clear();

            Console.WriteLine("\n======== MENU' Mostra stanze libere/occupate =========");
            Console.WriteLine("1) Visualizzazione del numero di stanze libere");
            Console.WriteLine("2) Visualizzazione del numero di stanze occupate    ");
            Console.WriteLine("3) Elenco stanze libere                             ");
            Console.WriteLine("4) Elenco stanze occupate                           ");
            Console.WriteLine("======================================================");
            Console.Write("Opzione scelta: ");
            scelta = Convert.ToInt16(Console.ReadLine());

            switch (scelta)
            { 
                case 1:

                    for (int i = 0; i < 1; i++)
                    {
                        if (lettitab[0] == 0)
                        {
                            cont++;
                        }

                        if (lettitab[1] == 0)
                        {
                            cont++;
                        }

                        if (lettitab[2] == 0)
                        {
                            cont++;
                        }

                        if (lettitab[3] == 0)
                        {
                            cont++;
                        }

                        if (lettitab[4] == 0)
                        {
                            cont++;
                        }

                        if (lettitab[5] == 0)
                        {
                            cont++;
                        }

                        if (lettitab[6] == 0)
                        {
                            cont++;
                        }

                    }
                    
                    Console.WriteLine("Numero di stanze libere {0}",cont);

                    break;

                case 2:

                    for (int i = 0; i < 1; i++)
                    {
                        if (lettitab[0] != 0)
                        {
                            cont1++;
                        }

                        if (lettitab[1] != 0)
                        {
                            cont1++;
                        }

                        if (lettitab[2] != 0)
                        {
                            cont1++;
                        }

                        if (lettitab[3] != 0)
                        {
                            cont1++;
                        }

                        if (lettitab[4] != 0)
                        {
                            cont1++;
                        }

                        if (lettitab[5] != 0)
                        {
                            cont1++;
                        }

                        if (lettitab[6] != 0)
                        {
                            cont1++;
                        }

                    }

                    Console.WriteLine("Numero di stanze occupate {0}", cont1);

                    break;

                case 3:

                    for (int i = 0; i < 1; i++)
                    {
                        if (lettitab[0] == 0)
                        {
                            Console.WriteLine("Stanza 1 Libera");
                        }

                        if (lettitab[1] == 0)
                        {
                            Console.WriteLine("Stanza 2 Libera");
                        }

                        if (lettitab[2] == 0)
                        {
                            Console.WriteLine("Stanza 3 Libera");
                        }

                        if (lettitab[3] == 0)
                        {
                            Console.WriteLine("Stanza 4 Libera");
                        }

                        if (lettitab[4] == 0)
                        {
                            Console.WriteLine("Stanza 5 Libera");
                        }

                        if (lettitab[5] == 0)
                        {
                            Console.WriteLine("Stanza 6 Libera");
                        }

                        if (lettitab[6] == 0)
                        {
                            Console.WriteLine("Stanza 7 Libera");
                        }

                    }
                    break;

                case 4:

                    for (int i = 0; i < 1; i++)
                    {
                        if (lettitab[0] != 0)
                        {
                            Console.WriteLine("Stanza 1 Occupata");
                        }

                        if (lettitab[1] != 0)
                        {
                            Console.WriteLine("Stanza 2 Occupata");
                        }

                        if (lettitab[2] != 0)
                        {
                            Console.WriteLine("Stanza 3 Occupata");
                        }

                        if (lettitab[3] != 0)
                        {
                            Console.WriteLine("Stanza 4 Occupata");
                        }

                        if (lettitab[4] != 0)
                        {
                            Console.WriteLine("Stanza 5 Occupata");
                        }

                        if (lettitab[5] != 0)
                        {
                            Console.WriteLine("Stanza 6 Occupata");
                        }

                        if (lettitab[6] != 0)
                        {
                            Console.WriteLine("Stanza 7 Occupata");
                        }
                    }
                    break;          
            }

            Thread.Sleep(3000);
            Console.Clear();

            //vedi se occupata
            do
            {
                Console.Write("Inserire il numero di stanza per la verifica: ");
                stanzi = Convert.ToInt16(Console.ReadLine());

                if (stanzi < 1 && stanzi > 7)
                {
                    Console.WriteLine("Stanza inesistente...");
                }

            } while (stanzi < 1 && stanzi > 7);

            switch(stanzi)
            {
                case 1:

                    if (stanza1[0] == false)
                    {
                        Console.WriteLine("Stanza libera");
                    }
                    else
                        Console.WriteLine("Stanza occupata");
                break;

                case 2:

                if (stanza1[1] == false)
                {
                    Console.WriteLine("Stanza libera");
                }
                else
                    Console.WriteLine("Stanza occupata");
                break;

                case 3:

                if (stanza1[2] == false)
                {
                    Console.WriteLine("Stanza libera");
                }
                else
                    Console.WriteLine("Stanza occupata");
                break;

                case 4:

                if (stanza1[3] == false)
                {
                    Console.WriteLine("Stanza libera");
                }
                else
                    Console.WriteLine("Stanza occupata");
                break;

                case 5:

                if (stanza1[4] == false)
                {
                    Console.WriteLine("Stanza libera");
                }
                else
                    Console.WriteLine("Stanza occupata");
                break;

                case 6:

                if (stanza1[5] == false)
                {
                    Console.WriteLine("Stanza libera");
                }
                else
                    Console.WriteLine("Stanza occupata");
                break;

                case 7:

                if (stanza1[6] == false)
                {
                    Console.WriteLine("Stanza libera");
                }
                else
                    Console.WriteLine("Stanza occupata");
                break;
            }
            Thread.Sleep(3000);
            Console.Clear();

            //rendere disponibile

            do
            {
                Console.Write("Inserire il numero di stanza per renderla libera: ");
                numero = Convert.ToInt16(Console.ReadLine());

                if (numero < 1 && numero > 7)
                {
                    Console.WriteLine("Stanza inesistente...");
                }

            } while (numero < 1 && numero > 7);

            switch (numero)
            {
                case 1:

                    if (stanza1[0] == false)
                    {
                        Console.WriteLine("Stanza libera");
                    }
                    else
                        Console.WriteLine("Stanza occupata");
                        stanza1[0] = false;
                        Console.WriteLine("Ora la stanza è libera");
                    break;

                case 2:

                    if (stanza1[1] == false)
                    {
                        Console.WriteLine("Stanza libera");
                    }
                    else
                        Console.WriteLine("Stanza occupata");
                    stanza1[1] = false;
                        Console.WriteLine("Ora la stanza è libera");
                    break;

                case 3:

                    if (stanza1[2] == false)
                    {
                        Console.WriteLine("Stanza libera");
                    }
                    else
                        Console.WriteLine("Stanza occupata");
                    stanza1[2] = false;
                        Console.WriteLine("Ora la stanza è libera");
                    break;

                case 4:

                    if (stanza1[3] == false)
                    {
                        Console.WriteLine("Stanza libera");
                    }
                    else
                        Console.WriteLine("Stanza occupata");
                    stanza1[3] = false;
                        Console.WriteLine("Ora la stanza è libera");
                    break;

                case 5:

                    if (stanza1[4] == false)
                    {
                        Console.WriteLine("Stanza libera");
                    }
                    else
                        Console.WriteLine("Stanza occupata");
                    stanza1[4] = false;
                        Console.WriteLine("Ora la stanza è libera");
                    break;

                case 6:

                    if (stanza1[5] == false)
                    {
                        Console.WriteLine("Stanza libera");
                    }
                    else
                        Console.WriteLine("Stanza occupata");
                    stanza1[5] = false;
                        Console.WriteLine("Ora la stanza è libera");
                    break;

                case 7:

                    if (stanza1[6] == false)
                    {
                        Console.WriteLine("Stanza libera");
                    }
                    else
                        Console.WriteLine("Stanza occupata");
                    stanza1[6] = false;
                        Console.WriteLine("Ora la stanza è libera");
                    break;
            }

            //rendere occupata
            Thread.Sleep(3000);
            Console.Clear();

            do
            {
                Console.Write("Inserire il numero di stanza per renderla occupata: ");
                numero1 = Convert.ToInt16(Console.ReadLine());

                if (numero1 < 1 && numero1 > 7)
                {
                    Console.WriteLine("Stanza inesistente...");
                }

            } while (numero1 < 1 && numero1 > 7);

            switch (numero1)
            {
                case 1:

                    if (stanza1[0] == false)
                    {
                        Console.WriteLine("Stanza libera");
                        stanza1[0] = true;
                        Console.WriteLine("Ora la stanza è occupata");
                    }
                    else
                        Console.WriteLine("Stanza occupata");
                    
                    break;

                case 2:

                    if (stanza1[1] == false)
                    {
                        Console.WriteLine("Stanza libera");
                        stanza1[1] = true;
                        Console.WriteLine("Ora la stanza è occupata");
                    }
                    else
                        Console.WriteLine("Stanza occupata");
                    
                    break;

                case 3:

                    if (stanza1[2] == false)
                    {
                        Console.WriteLine("Stanza libera");
                        stanza1[2] = true;
                        Console.WriteLine("Ora la stanza è occupata");
                    }
                    else
                        Console.WriteLine("Stanza occupata");
                    
                    break;

                case 4:

                    if (stanza1[3] == false)
                    {
                        Console.WriteLine("Stanza libera");
                        stanza1[3] = true;
                        Console.WriteLine("Ora la stanza è occupata");
                    }
                    else
                        Console.WriteLine("Stanza occupata");

                    break;

                case 5:

                    if (stanza1[4] == false)
                    {
                        Console.WriteLine("Stanza libera");
                        stanza1[4] = true;
                        Console.WriteLine("Ora la stanza è occupata");
                    }
                    else
                        Console.WriteLine("Stanza occupata");
                    break;

                case 6:

                    if (stanza1[5] == false)
                    {
                        Console.WriteLine("Stanza libera");
                        stanza1[5] = true;
                        Console.WriteLine("Ora la stanza è occupata");
                    }
                    else
                        Console.WriteLine("Stanza occupata");

                    break;

                case 7:

                    if (stanza1[6] == false)
                    {
                        Console.WriteLine("Stanza libera");
                        stanza1[6] = true;
                        Console.WriteLine("Ora la stanza è occupata");
                    }
                    else
                        Console.WriteLine("Stanza occupata");

                    break;
            }

            Thread.Sleep(3000);
            Console.Clear();

            //cerca stanza libera
            string ricerca;
            int letto = 0;
            bool celetto = false;

            Console.WriteLine("====== Visualizzazione stato stanze ========");
            Console.Write("Inserire la tipologia di una stanza (singola - doppia - tripla):  ");
            ricerca = Console.ReadLine();
            ricerca = ricerca.ToUpper();

            if (ricerca == "SINGOLA")
            {

                if (lettitab[0] == 1)
                {
                    Console.WriteLine("Stanza 1 con 1 letto");
                }

                if (lettitab[1] == 1)
                {
                    Console.WriteLine("Stanza 2 con 1 letto");
                }

                if (lettitab[2] == 1)
                {
                    Console.WriteLine("Stanza 3 con 1 letto");
                }

                if (lettitab[3] == 1)
                {
                    Console.WriteLine("Stanza 4 con 1 letto");
                }

                if (lettitab[4] == 1)
                {
                    Console.WriteLine("Stanza 5 con 1 letto");
                }

                if (lettitab[5] == 1)
                {
                    Console.WriteLine("Stanza 6 con 1 letto");
                }

                if (lettitab[6] == 1)
                {
                    Console.WriteLine("Stanza 7 con 1 letto");
                }


            }

            if (ricerca == "DOPPIA")
            {

                if (lettitab[0] == 2)
                {
                    Console.WriteLine("Stanza 1 con 2 letti");
                }

                if (lettitab[1] == 2)
                {
                    Console.WriteLine("Stanza 2 con 2 letti");
                }

                if (lettitab[2] == 2)
                {
                    Console.WriteLine("Stanza 3 con 2 letti");
                }

                if (lettitab[3] == 2)
                {
                    Console.WriteLine("Stanza 4 con 2 letti");
                }

                if (lettitab[4] == 2)
                {
                    Console.WriteLine("Stanza 5 con 2 letti");
                }

                if (lettitab[5] == 2)
                {
                    Console.WriteLine("Stanza 6 con 2 letti");
                }

                if (lettitab[6] == 2)
                {
                    Console.WriteLine("Stanza 7 con 2 letti");
                }


            }

            if (ricerca == "TRIPLA")
            {

                if (lettitab[0] == 3)
                {
                    Console.WriteLine("Stanza 1 con 3 letti");
                }

                if (lettitab[1] == 3)
                {
                    Console.WriteLine("Stanza 2 con 3 letti");
                }

                if (lettitab[2] == 3)
                {
                    Console.WriteLine("Stanza 3 con 3 letti");
                }

                if (lettitab[3] == 3)
                {
                    Console.WriteLine("Stanza 4 con 3 letti");
                }

                if (lettitab[4] == 3)
                {
                    Console.WriteLine("Stanza 5 con 3 letti");
                }

                if (lettitab[5] == 3)
                {
                    Console.WriteLine("Stanza 6 con 3 letti");
                }

                if (lettitab[6] == 3)
                {
                    Console.WriteLine("Stanza 7 con 3 letti");
                }


            }
            
            
            


        }
    }
}
