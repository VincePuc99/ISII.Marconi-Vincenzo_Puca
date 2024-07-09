using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Asta
{
    class Program
    {
        static void Main(string[] args)
        {
            int scelta, conterr = 0;
            Random r = new Random();
            int articolo, persona1, persona2, persona3, persona4, persona5;
            int portaf1, portaf2, portaf3, portaf4, bas = 0, portaf5;
            articolo = r.Next(1, 4);
            portaf1 = r.Next(3000, 7001);
            portaf2 = r.Next(3000, 7001);
            portaf3 = r.Next(3000, 7001);
            portaf4 = r.Next(3000, 7001);
            portaf5 = r.Next(3000, 7001);
           do
           {
                do
                {
                    Console.WriteLine("================= Asta ===============");
                    Console.WriteLine("  1)    Presentazione singolo articolo");
                    Console.WriteLine("  2)    Apertura offerte");
                    Console.WriteLine("  3)    Fine Programma");
                    Console.WriteLine("======================================");


                    Thread.Sleep(900);


                    Console.Write("Opzione Scelta --> ");
                    scelta = Convert.ToInt16(Console.ReadLine());
                    Thread.Sleep(500);

                    if (scelta > 3 || scelta < 1)
                    {
                        Console.Clear();
                        Console.WriteLine("Opzione non valida...riprovare!!!");
                        conterr++;
                        Thread.Sleep(1000);
                        Console.Clear();
                    }
                    if (conterr == 3)
                    {
                        Console.Clear();
                        Console.WriteLine("Limite tentativi raggiunto, chiusura...");
                        Thread.Sleep(1500);
                        return;
                    }


                } while (scelta > 3 || scelta < 1);


                switch (scelta)
                { 

                    case 1:
                       
                switch (articolo)
                {
                    case 1:

            

                        Console.WriteLine("……………………………………………");
                        Console.WriteLine("L’articolo proposto è il seguente:");
                        Console.WriteLine("QUADRO del 1800 del pittore ANZIO");
                        Console.WriteLine("Base d’asta: $ 3000,00");
                        Console.WriteLine("……………………………………………\n");
                        Console.WriteLine("Ritorno ad inizio...");
                        Thread.Sleep(5000);
                        Console.Clear();

                        break;

                    case 2:
                        Console.WriteLine("……………………………………………");
                        Console.WriteLine("L’articolo proposto è il seguente:");
                        Console.WriteLine("MOBILE del 1700  stile Luigi XVI  ");
                        Console.WriteLine("Base d’asta: $ 5000,00");
                        Console.WriteLine("……………………………………………\n");
                        Console.WriteLine("Ritorno ad inizio...");
                        Thread.Sleep(5000);
                        Console.Clear();
                        break;
                    case 3:
                        Console.WriteLine("……………………………………………");
                        Console.WriteLine("L’articolo proposto è il seguente:");
                        Console.WriteLine("COMPUTER del 1985 APPLE MAC1 ");
                        Console.WriteLine("Base d’asta: $ 1000,00");
                        Console.WriteLine("……………………………………………\n");
                        Console.WriteLine("Ritorno ad inizio...");
                        Thread.Sleep(5000);
                        Console.Clear();
                        break;
                }
                break;

                        case 2:

                        if (articolo == 1)
                        {
                            bas += 3000;
                        }

                        if (articolo == 2)
                        {
                            bas += 5000;
                        }

                        if (articolo == 3)
                        {
                            bas += 1000;
                        }

                        

                        do
                        {
                            Console.WriteLine("Hai {0} $", portaf1);
                            Console.Write("Player 1 offre: ");     
                            persona1 = Convert.ToInt32(Console.ReadLine());
                        
                            if (persona1 > portaf1)
                            {
                                Console.WriteLine("Non Hai abbastanza credito! Riprova...");
                            }
                            if (persona1 == 0)
                            {
                                Console.WriteLine("Non sei interessato...");
                            }

                            if (persona1 < bas && persona1 !=0)
                            {
                                Console.WriteLine("Offerta inferiore alla base d'asta, Riprova...");
                            }

                            if (persona1 != 0 && persona1 >= bas && persona1 < portaf1)
                            {
                                Console.WriteLine("Offerta riuscita!!!\n");
                            }
                            if (portaf1 < bas)
                            {
                                Console.WriteLine("Non Hai abbastanza credito! Fine asta per te.");
                                goto avanti;
                            }            
                        } while (persona1 < bas && persona1 != 0 || persona1 > portaf1 || portaf1 < bas);
                               avanti:
                    

                            do
                            {
                            Console.WriteLine("Hai {0} $", portaf2);
                            Console.Write("Player 2 offre: ");     
                            persona2 = Convert.ToInt32(Console.ReadLine());
                    
                            if (persona2 > portaf2)
                            {
                                Console.WriteLine("Non Hai abbastanza credito! Riprova...");
                            }
                            if (persona2 == 0)
                            {
                                Console.WriteLine("Non sei interessato...");
                            }

                            if (persona2 < bas && persona2 !=0)
                            {
                                Console.WriteLine("Offerta inferiore alla base d'asta, Riprova...");
                            }

                            if (persona2 != 0 && persona2 >= bas && persona2 < portaf2)
                            {
                                Console.WriteLine("Offerta riuscita!!!");
                            }
                            if (persona1 > persona2)
                            {
                                Console.WriteLine("Offerta inferiore a quella di un concorrente, Riprova...");
                            }

                            if (persona1 > portaf2)
                            {
                                Console.WriteLine("Non Hai abbastanza credito! Fine asta per te.");
                                goto avanti1;
                            }
                            if (portaf2 < bas)
                            {
                                Console.WriteLine("Non Hai abbastanza credito! Fine asta per te.");
                                goto avanti1;
                            }
                            } while (persona2 < bas && persona2 != 0 || persona2 > portaf2 || persona1 > persona2 || portaf2 < bas || persona1 > portaf2);

                              avanti1:

                            Console.WriteLine("");
                                do
                            {
                            Console.WriteLine("Hai {0} $", portaf3);
                            Console.Write("Player 3 offre: ");     
                            persona3 = Convert.ToInt32(Console.ReadLine());
                    
                            if (persona3 > portaf3)
                            {
                                Console.WriteLine("Non Hai abbastanza credito! Riprova...");
                            }
                            if (persona3 == 0)
                            {
                                Console.WriteLine("Non sei interessato...");
                            }

                            if (persona3 < bas && persona3 !=0)
                            {
                                Console.WriteLine("Offerta inferiore alla base d'asta, Riprova...");
                            }

                            if (persona3 != 0 && persona3 >= bas && persona3 < portaf3)
                            {
                                Console.WriteLine("Offerta riuscita!!!");
                            }

                            if (persona1 > persona3||persona2>persona3)
                            {
                                Console.WriteLine("Offerta inferiore a quella di un concorrente, Riprova...");
                            }
                            if (portaf3 < bas)
                            {
                                Console.WriteLine("Non Hai abbastanza credito! Fine asta per te.");
                                goto avanti2;
                            }
                            if (persona1 > portaf3||persona2>portaf3)
                            {
                                Console.WriteLine("Non Hai abbastanza credito! Fine asta per te.");
                                goto avanti2;
                            }
                            } while (persona3 < bas && persona3 != 0 || persona3 > portaf3 || persona1 > persona3 || persona2 > persona3 || portaf3 < bas || persona1 > portaf3 || persona2 > portaf3);

                            avanti2:
                        Console.WriteLine("");

                                do
                            {
                       Console.WriteLine("Hai {0} $", portaf4);
                            Console.Write("Player 4 offre: ");     
                            persona4 = Convert.ToInt32(Console.ReadLine());
                    
                            if (persona4 > portaf4)
                            {
                                Console.WriteLine("Non Hai abbastanza credito! Riprova...");
                            }
                            if (persona4 == 0)
                            {
                                Console.WriteLine("Non sei interessato...");
                            }

                            if (persona4 < bas && persona4 !=0)
                            {
                                Console.WriteLine("Offerta inferiore alla base d'asta, Riprova...");
                            }

                            if (persona4 != 0 && persona4 >= bas && persona4 < portaf4)
                            {
                                Console.WriteLine("Offerta riuscita!!!");
                            }
                            if (persona1 > persona4 || persona2 > persona4||persona3>persona4)
                            {
                                Console.WriteLine("Offerta inferiore a quella di un concorrente, Riprova...");
                            }
                            if (portaf4 < bas)
                            {
                                Console.WriteLine("Non Hai abbastanza credito! Fine asta per te.");
                                goto avanti3;
                            }

                            if (persona1 > portaf4 || persona2 > portaf4||persona3>portaf4)
                            {
                                Console.WriteLine("Non Hai abbastanza credito! Fine asta per te.");
                                goto avanti3;
                            }

                            } while (persona4 < bas && persona4 != 0 || persona4 > portaf4 || persona1 > persona4 || persona2 > persona4 || persona3 > persona4 || portaf4 < bas || persona1 > portaf4 || persona2 > portaf4 || persona3 > portaf4);

                            avanti3:
                        Console.WriteLine("");


                         do
                            {
                       Console.WriteLine("Hai {0} $", portaf5);
                            Console.Write("Player 5 offre: ");     
                            persona5 = Convert.ToInt32(Console.ReadLine());
                    
                            if (persona5 > portaf5)
                            {
                                Console.WriteLine("Non Hai abbastanza credito! Riprova...");
                            }
                            if (persona5 == 0)
                            {
                                Console.WriteLine("Non sei interessato...");
                            }

                            if (persona5 < bas && persona5 !=0)
                            {
                                Console.WriteLine("Offerta inferiore alla base d'asta, Riprova...");
                            }

                            if (persona5 != 0 && persona5 >= bas && persona5 < portaf5)
                            {
                                Console.WriteLine("Offerta riuscita!!!");
                            }

                            if (persona1 > persona5 || persona2 > persona5 || persona3 > persona5||persona4>persona5)
                            {
                                Console.WriteLine("Offerta inferiore a quella di un concorrente, Riprova...");
                            }
                            if (portaf5 < bas)
                            {
                                Console.WriteLine("Non Hai abbastanza credito! Fine asta per te.");
                                goto avanti4;
                            }

                            if (persona1 > portaf5 || persona2 > portaf5 || persona3 > portaf5||persona4>portaf5)
                            {
                                Console.WriteLine("Non Hai abbastanza credito! Fine asta per te.");
                                goto avanti4;
                            }

                            } while (persona5 < bas && persona5 != 0 || persona5 > portaf5 || persona1 > persona5 || persona2 > persona5 || persona3 > persona5 || persona4 > persona5 || portaf5 < bas || persona1 > portaf5 || persona2 > portaf5 || persona3 > portaf5 || persona4 > portaf5);

                            avanti4:
                        Console.WriteLine("");

                        //vincitori

                         if (persona1 > persona2 && persona1 > persona3 && persona1 > persona4 && persona1 > persona5)
                         {
                             Console.WriteLine("Complimenti Player 1, lei si è aggiudicato l'asta!");
                         }

                         if (persona2 > persona1 && persona2 > persona3 && persona2 > persona4 && persona2 > persona5)
                         {
                             Console.WriteLine("Complimenti Player 2, lei si è aggiudicato l'asta!");
                         }

                         if (persona3 > persona2 && persona3 > persona1 && persona3 > persona4 && persona3 > persona5)
                         {
                             Console.WriteLine("Complimenti Player 3, lei si è aggiudicato l'asta!");
                         }

                         if (persona4 > persona2 && persona4> persona3 && persona4 > persona1 && persona4 > persona5)
                         {
                             Console.WriteLine("Complimenti Player 4, lei si è aggiudicato l'asta!");
                         }

                         if (persona5 > persona2 && persona5 > persona3 && persona5 > persona4 && persona5 > persona1)
                         {
                             Console.WriteLine("Complimenti Player 5, lei si è aggiudicato l'asta!");
                         }
                        //offerte uguali
                         if (persona1 == persona2 || persona1 == persona3 || persona1 == persona4 || persona1 == persona5)
                         {
                             Console.WriteLine("Però ci sono offerte uguali quindi nessuno vince,tutta l'asta è annullata");
                         }

                         if (persona2 == persona1 || persona2 == persona3 || persona2 == persona4 || persona2 == persona5)
                         {
                             Console.WriteLine("Però ci sono offerte uguali quindi nessuno vince,tutta l'asta è annullata");
                         }

                         if (persona3 == persona1 || persona3 == persona2 || persona3 == persona4 || persona3 == persona5)
                         {
                             Console.WriteLine("Però ci sono offerte uguali quindi nessuno vince,tutta l'asta è annullata");
                         }

                         if (persona4 == persona1 || persona4 == persona2 || persona4== persona3 || persona4 == persona5)
                         {
                             Console.WriteLine("Però ci sono offerte uguali quindi nessuno vince,tutta l'asta è annullata");
                         }

                         if (persona5 == persona1 || persona5 == persona2 || persona5 == persona3 || persona5 == persona4)
                         {
                             Console.WriteLine("Però ci sono offerte uguali quindi nessuno vince,tutta l'asta è annullata");
                         }

                         Console.WriteLine("Premere un tasto qualsiasi per tornare al menù!");
                         Console.ReadKey();
                    break;

                    case 3:
                    Console.Clear();
                        Console.WriteLine("Arresto Programma in corso...");
                        Thread.Sleep(1000);
                        return;
                        
                }  


           }while(true);



            }
        }
    }

