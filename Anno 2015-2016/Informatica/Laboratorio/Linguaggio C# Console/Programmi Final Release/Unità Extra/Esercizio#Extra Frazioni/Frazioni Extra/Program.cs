using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frazioni_Extra
{
    class Program
    {
        static void Main(string[] args)
        {

            int numero1, numero2, numero3, numero4, somma, sottrazione, prodotto, divisione, dem1, dem2, dem3, dem4;

            Console.WriteLine("Inserisci il numeratore della prima frazione");
            numero1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Inserisci il denominatore della prima frazione");
            numero2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Inserisci il numeratore della seconda frazione");
            numero3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Inserisci il denominatore della seconda frazione");
            numero4 = Convert.ToInt32(Console.ReadLine());

            dem1 = numero2 * numero4;
            if (dem1 > 0)
            {

                somma = (dem1 / numero2 * numero1) + (dem1 / numero4 * numero3);

                while (somma % 2 == 0 && dem1 % 2 == 0)
                {
                    somma = somma / 2;
                    dem1 = dem1 / 2;
                }
                while (somma % 3 == 0 && dem1 % 3 == 0)
                {
                    somma = somma / 3;
                    dem1 = dem1 / 3;
                }
                while (somma % 5 == 0 && dem1 % 5 == 0)
                {
                    somma = somma / 5;
                    dem1 = dem1 / 5;
                }
                dem2 = dem1;

                sottrazione = (dem2 / numero2 * numero1) - (dem2 / numero4 * numero3);

                while (sottrazione % 2 == 0 && dem1 % 2 == 0)
                {
                    sottrazione = sottrazione / 2;
                    dem2 = dem2 / 2;
                }
                while (sottrazione % 3 == 0 && dem2 % 3 == 0)
                {
                    sottrazione = sottrazione / 3;
                    dem2 = dem2 / 3;
                }
                while (sottrazione % 5 == 0 && dem2 % 5 == 0)
                {
                    sottrazione = sottrazione / 5;
                    dem2 = dem2 / 5;
                }

                prodotto = numero1 * numero3;
                dem3 = numero2 * numero4;
                if (dem3 > 0)
                {

                    while (prodotto % 2 == 0 && dem3 % 2 == 0)
                    {
                        prodotto = prodotto / 2;
                        dem3 = dem3 / 2;
                    }
                    while (prodotto % 3 == 0 && dem3 % 3 == 0)
                    {
                        prodotto = prodotto / 3;
                        dem3 = dem3 / 3;
                    }
                    while (prodotto % 5 == 0 && dem3 % 5 == 0)
                    {
                        prodotto = prodotto / 5;
                        dem3 = dem3 / 5;
                    }
                    divisione = numero1 * numero4;
                    dem4 = numero2 * numero3;
                    if (dem4 > 0)
                    {

                        while (divisione % 2 == 0 && dem4 % 2 == 0)
                        {
                            divisione = divisione / 2;
                            dem4 = dem4 / 2;
                        }
                        while (divisione % 3 == 0 && dem4 % 3 == 0)
                        {
                            divisione = divisione / 3;
                            dem4 = dem4 / 3;
                        }
                        while (divisione % 5 == 0 && dem4 % 5 == 0)
                        {
                            divisione = divisione / 5;
                            dem4 = dem3 / 5;
                        }

                        Console.Write("\nI risultati sono i seguenti: \n\nSomma = {0}/{1} \n\nSottrazione = {2}/{3} \n\nMoltiplicazione = {4}/{5} \n\nQuoziente= {6}/{7}", somma, dem1, sottrazione, dem2, prodotto, dem3, divisione, dem4);
                        Console.ReadKey();
                    }
                    else
                        Console.WriteLine("Errore!!!, nessun denominatore deve essere minore oppure uguale a 0 ");
                    Console.ReadKey();
                }
                else
                    Console.WriteLine("Errore!!!, nessun denominatore deve essere minore oppure uguale a 0 ");
                Console.ReadKey();
            }
            else
                Console.WriteLine("Errore!!!, nessun denominatore deve essere minore oppure uguale a 0 ");

            Console.ReadKey();

        }
    }
}
