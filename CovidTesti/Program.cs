using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CovidTesti
{
    class Program
    {
        static void Main(string[] args)
        {

            
            BaslikGetir();
            Console.Write("Yaşınız: ");
            string yas = Convert.ToString(Console.ReadLine());

            Console.Write("Ateşin var mı? " + SoruEk());
            string atesCevap = Convert.ToString(Console.ReadLine());

            Console.Write("Öksürük var mı? " + SoruEk());
            string oksurukCevap = Convert.ToString(Console.ReadLine());

            if (atesCevap == "e" || oksurukCevap == "e" || atesCevap == "h" || oksurukCevap == "h")
            {
              
                 if (atesCevap == "e" && oksurukCevap == "e")
                {

                    Console.WriteLine("Covid Oldun.");

                }

                else
                {
                    if (atesCevap == "e")
                    {
                        Console.WriteLine("Ateşiniz olduğu için büyük risk altındasınız.");
                    }

                    else
                    {
                        Console.WriteLine("Covid deelsin.");
                    }

                }
            }

            else
            {

                Console.WriteLine("HATALI KOD");

            }
            Console.ReadLine();
        }

        static void BaslikGetir()
        {
            Console.WriteLine("COVID 19 TEST");
        }

        static string SoruEk()
        {
           string Metin = "Var ise(e) yok ise(h)";
           return Metin;
        }
    }
}
