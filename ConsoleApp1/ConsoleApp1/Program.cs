using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string adsoyad = "cem sözer";

            Console.WriteLine(adsoyad);

            string buyukharf = adsoyad.ToUpper();
            string kucukharf = adsoyad.ToLower();
            string belirlibirkısım = adsoyad.Substring(2, 3);
            int deger = 100; 
            int deger1 = int.MaxValue;
            double deger2 = 10.2;
            Console.WriteLine(deger2 + deger);
            Console.WriteLine(buyukharf);
            Console.WriteLine(kucukharf);
            Console.WriteLine(belirlibirkısım);
            Console.WriteLine(deger1);
            Console.WriteLine(deger);
            Console.ReadLine();
            bool kullanıcıdeğer;
            kullanıcıdeğer = false;
        }
    }
}
