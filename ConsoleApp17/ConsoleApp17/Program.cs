using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace ConsoleApp17
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string kullanıcıadi = string.Empty;
            string sifre = string.Empty;
            int sayac = 0;

            do
            {
                Console.WriteLine("kullanıcı adı giriniz : ");
                kullanıcıadi = Console.ReadLine();

                Console.WriteLine("şifre giriniz : ");
                sifre = Console.ReadLine();





                if (sayac > 0)
                    Console.WriteLine("kullanıcı girişi başarısız");
                sayac++;

            }




            while (kullanıcıadi.ToLower() != "demo" || sifre.ToLower() != "demo");
            Console.WriteLine("kullanıcı girişi başarılı");



        }
    }
}
