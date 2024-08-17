using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tahminoyunu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // TAHMİN OYUNU

            // Bilgisayar 1 ile 100 arasından sayı tutsun, kullanıcı tahmin edecek ve bilemediği sürece ipucu alacak. 5 tahmin hakkı olsun

            Random sayigen = new Random();
            int sayi=sayigen.Next(1,101);
            int i = 1 , tahmin;
            bool bildi=false;
            for (i = 1; (i <= 10) && (bildi!=true); i++)
            {
                Console.Write("{0} Hakkiniz Kaldi , {1}.Tahmininizi Girin: ",(11-i),i);
                tahmin=Convert.ToInt32(Console.ReadLine());
                if (tahmin == sayi)
                    bildi = true;
                else if (tahmin > sayi)
                    Console.WriteLine("Tahmininizi azaltin!\n");
                else
                    Console.WriteLine("Tahmininizi arttirin!\n");
            }
            if (bildi == true)
            {
                Console.WriteLine("\n---{0}.Tahminde {1} sayisini bildiniz!---",i-1,sayi);
            }
            else
                Console.WriteLine("\n---{0} sayisini bilemediniz!---", sayi);

            Console.ReadKey();
        }
    }
}
