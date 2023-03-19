using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("merhaba");

            Console.Write("isminiz nedir?");
            string isim = Console.ReadLine();

            Console.WriteLine("soyisminiz nedir ?");
            string soyisim = Console.ReadLine();

            Console.Clear();
            Console.WriteLine("isim :" + isim);
            Console.WriteLine("soyisim :" + soyisim);

            Console.ReadLine();

        }
    }
}
