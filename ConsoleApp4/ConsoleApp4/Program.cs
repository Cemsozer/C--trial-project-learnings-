using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Merhaba");
            Console.Write("isminiz : ");

            string isim = Console.ReadLine();

            Console.Write("yaşınız : ");
           string yasstr = Console.ReadLine();
            int yas = Convert.ToInt32(yasstr);

            Console.Clear();
            Console.WriteLine("isim : " + isim);
            Console.WriteLine("yaş : " + yas);

            Console.ReadLine();
            
            

        }
    }
} 
