using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    internal class Program
    {
        static void Main(string[] args)
        {



            Console.WriteLine("kullanıcı adi giriniz : ");
            string kullanıcıadi = Console.ReadLine();


            Console.WriteLine("sifre giriniz : ");
            string sifre = Console.ReadLine();

            bool kullanıcıadi1 = kullanıcıadi == "admin";
            bool kullancıadi2 = kullanıcıadi != "admin";

            
            bool sifre1 = sifre == "123";
            bool sifre2 = sifre != "123";
            Console.ReadLine();

















        }
    }
}
