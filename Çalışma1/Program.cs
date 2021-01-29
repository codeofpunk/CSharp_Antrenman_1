using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Çalışma1
{
    class Program
    {
        static void Main(string[] args)
        {
            double sayi1,sayi2,sonuc = 0;
            string islem;

            Console.WriteLine("Hesap Makinesi");

            Console.Write("1. Sayı: ");
            sayi1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("2. Sayı: ");
            sayi2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Yapmak istediğiniz işlem: (*, +, -, /)");
            islem = Convert.ToString(Console.ReadLine());

            if (islem == "*" || islem == "+" || islem == "-" || islem == "/")
            {

                if (islem == "*")
                {
                    sonuc = sayi1 * sayi2;
                    
                }

                else if (islem == "+")
                {
                    sonuc = sayi1 + sayi2;
                  
                }

                else if (islem == "-")
                {
                    sonuc = sayi1 - sayi2;
                   
                }

                else if (islem == "/")
                {
                    sonuc = sayi1 / sayi2;
                    
                }

                Console.WriteLine("İşlem Sonucunuz: " + sonuc.ToString());

            }

            else
            {
                Console.WriteLine("Hatalı işlem kodu!");
            }



            Console.ReadLine();
        }
    }
}
