using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Piazze
{
    class Program
    {      
        static void Main(string[] args)
        {
            string[] peeazze = new string[4];
            int[,] adeeacenze = new int[4,4];
            int num2 = 0;
            int num = 0;

            string parte;
            string arriva;

            for (int i = 0; i < 4; i++)
            {
                num++;
                Console.Write("Inserire il nome della piazza n°{0}: ", num);
                peeazze[i] = Console.ReadLine();
            }


            num = 0;
            for (int i = 0; i < adeeacenze.GetLength(0); i++)
            {
                for (int l = 0; l < adeeacenze.GetLength(1); l++)
                {
                    num++;
                    do
                    {
                        Console.Write("Inserire la matrice delle adiacenze: ", num);
                        adeeacenze[i, l] = Convert.ToInt16(Console.ReadLine());

                        if (adeeacenze[i, l] != 0 && adeeacenze[i, l] != 1)
                        {
                            Console.WriteLine("Solo numeri binari");
                        }
                    } while (adeeacenze[i, l] != 0 && adeeacenze[i, l] != 1);
                }
            }

            bool sn = false;

            for (int i = 0; i < 4; i++)
            {
                if (sn == false)
                {
                    Console.Write("\t{0}\t", peeazze[i]);
                }
                else
                    Console.Write("{0}\t", peeazze[i]);
               

                sn = true;
            }
            Console.WriteLine();
            for (int i = 0; i < adeeacenze.GetLength(0); i++)
            {
                Console.Write("{0}\t",peeazze[i]);
                for (int l = 0; l < adeeacenze.GetLength(1); l++)
                {
 
                    Console.Write("{0}\t",adeeacenze[i,l]);
                    num2++;
                    if (num2 == 4)
                    {
                        Console.WriteLine();
                        num2 = 0;
                    }
                }
            }

            do
                {
                    Console.Write("Inserire una piazza di partenza: ");
                    parte = Console.ReadLine();

                    if (peeazze[0] != parte && peeazze[1] != parte && peeazze[2] != parte && peeazze[3] != parte)
                    {
                        Console.WriteLine("Piazza inesistente!!!");
                    }

                } while (peeazze[0] != parte && peeazze[1] != parte && peeazze[2] != parte && peeazze[3] != parte);

                do
                {
                    Console.Write("Inserire una piazza di arrivo: ");
                    arriva = Console.ReadLine();

                    if (peeazze[0] != arriva && peeazze[1] != arriva && peeazze[2] != arriva && peeazze[3] != arriva)
                    {
                        Console.WriteLine("Piazza inesistente!!!");
                    }

                } while (peeazze[0] != arriva && peeazze[1] != arriva && peeazze[2] != arriva && peeazze[3] != arriva);

     
                //caso piazza 0
                if (parte == peeazze[0])
                {
                    //piazza arrivo 0 uguale
                    if (arriva == peeazze[0])
                    {
                        Console.WriteLine("Sei già in questa piazza!");
                    }
                        //arrivo 1
                        if (arriva == peeazze[1])
                        {

                        if (adeeacenze[0, 1] == 0)
                        {
                            Console.WriteLine("Non puoi andare in questa piazza");
                        }
                        else
                            Console.WriteLine("Sei in piazza {0}",arriva);

                        //arrivio 2
                        if (arriva == peeazze[2])
                        {

                            if (adeeacenze[0, 2] == 0)
                            {
                                Console.WriteLine("Non puoi andare in questa piazza");
                            }
                            else
                                Console.WriteLine("Sei in piazza {0}", arriva);
                        }
                        //arrivo 3
                        if (arriva == peeazze[3])
                        {

                            if (adeeacenze[0, 3] == 0)
                            {
                                Console.WriteLine("Non puoi andare in questa piazza");
                            }
                            else
                                Console.WriteLine("Sei in piazza {0}", arriva);
                        }
                    }


                    //caso piazza 1
                        if (parte == peeazze[1])
                        {
                            //piazza arrivo uguale
                            if (arriva == peeazze[1])
                            {
                                Console.WriteLine("Sei già in questa piazza!");
                            }
                            //arrivo 1
                            if (arriva == peeazze[0])
                            {

                                if (adeeacenze[1, 0] == 0)
                                {
                                    Console.WriteLine("Non puoi andare in questa piazza");
                                }
                                else
                                    Console.WriteLine("Sei in piazza {0}", arriva);

                                //arrivio 2
                                if (arriva == peeazze[2])
                                {

                                    if (adeeacenze[1, 2] == 0)
                                    {
                                        Console.WriteLine("Non puoi andare in questa piazza");
                                    }
                                    else
                                        Console.WriteLine("Sei in piazza {0}", arriva);
                                }
                                //arrivo 3
                                if (arriva == peeazze[3])
                                {

                                    if (adeeacenze[1, 3] == 0)
                                    {
                                        Console.WriteLine("Non puoi andare in questa piazza");
                                    }
                                    else
                                        Console.WriteLine("Sei in piazza {0}", arriva);
                                }
                            }

                        }


                        //caso piazza 2
                        if (parte == peeazze[2])
                        {
                            //piazza arrivo uguale
                            if (arriva == peeazze[2])
                            {
                                Console.WriteLine("Sei già in questa piazza!");
                            }
                            //arrivo 1
                            if (arriva == peeazze[0])
                            {

                                if (adeeacenze[2, 0] == 0)
                                {
                                    Console.WriteLine("Non puoi andare in questa piazza");
                                }
                                else
                                    Console.WriteLine("Sei in piazza {0}", arriva);

                                //arrivio 2
                                if (arriva == peeazze[1])
                                {

                                    if (adeeacenze[2,1] == 0)
                                    {
                                        Console.WriteLine("Non puoi andare in questa piazza");
                                    }
                                    else
                                        Console.WriteLine("Sei in piazza {0}", arriva);
                                }
                                //arrivo 3
                                if (arriva == peeazze[3])
                                {

                                    if (adeeacenze[2, 3] == 0)
                                    {
                                        Console.WriteLine("Non puoi andare in questa piazza");
                                    }
                                    else
                                        Console.WriteLine("Sei in piazza {0}", arriva);
                                }
                            }

                        }

                        //caso piazza 3
                        if (parte == peeazze[3])
                        {
                            //piazza arrivo uguale
                            if (arriva == peeazze[3])
                            {
                                Console.WriteLine("Sei già in questa piazza!");
                            }
                            //arrivo 1
                            if (arriva == peeazze[0])
                            {

                                if (adeeacenze[3, 0] == 0)
                                {
                                    Console.WriteLine("Non puoi andare in questa piazza");
                                }
                                else
                                    Console.WriteLine("Sei in piazza {0}", arriva);

                                //arrivio 2
                                if (arriva == peeazze[1])
                                {

                                    if (adeeacenze[3,1] == 0)
                                    {
                                        Console.WriteLine("Non puoi andare in questa piazza");
                                    }
                                    else
                                        Console.WriteLine("Sei in piazza {0}", arriva);
                                }
                                //arrivo 3
                                if (arriva == peeazze[3])
                                {

                                    if (adeeacenze[3,2] == 0)
                                    {
                                        Console.WriteLine("Non puoi andare in questa piazza");
                                    }
                                    else
                                        Console.WriteLine("Sei in piazza {0}", arriva);
                                }
                            }

                        }
                }//fine delle if

  





            //fine programma
        }
    }
}
