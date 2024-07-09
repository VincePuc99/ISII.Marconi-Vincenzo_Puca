using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Validatore_Email
{
    class Program
    {
        static void Main(string[] args)
        {
            string mail;
            string utente, dominio;
            int index, cont = 0;
            bool endm = false;
            bool endt = false;
            int fine;

            do
            {
                do
                {
                    Console.Write("Inserire una Mail per validarla: ");
                    mail = Console.ReadLine();

                    if (mail.Length > 30)
                    {
                        Console.WriteLine("Mail troppo lunga,riprova!!!");
                    }

                } while (mail.Length > 30);
                //nome utente
                index = mail.IndexOf('@');
                utente = mail.Substring(0, index);
                utente = utente.ToLower();

                for (int i = 0; i < mail.Length; i++)
                {
                    if (mail[i] == '@')
                    {
                        cont++;
                    }
                }

                if (cont != 1 && cont != 0&&utente.Length == 0 )
                {
                    Console.WriteLine("O hai inserito troppi '@'");
                    Console.WriteLine("O non hai inserito '@'");
                    Console.WriteLine("O il nome utente non può essere vuoto");
                }
                //dominio
                
                endm = mail.EndsWith("m");
                endt = mail.EndsWith("t");
                
                if(endm == true)
                {
                    fine = mail.Length;
                    fine -= 1;
                    dominio = mail.Substring(index + 1, fine);
                    Console.WriteLine("Dominio = {0}", dominio);
                }

                if (endt == true)
                {
                    fine = mail.Length;
                    fine -= 1;
                    dominio = mail.Substring(index + 1, fine);
                    Console.WriteLine("Dominio = {0}", dominio);
                    
                }

                if (endm == false && endt == false)
                {
                    Console.WriteLine("Dominio inesistente riprova!!!");               
                }


            } while (cont != 1 && cont != 0 && utente.Length == 0 && endm == false && endt == false);

            Console.WriteLine("Mail Valida!!!");
            Console.WriteLine("Utente  = {0}", utente);
            




            








        }
    }
}
