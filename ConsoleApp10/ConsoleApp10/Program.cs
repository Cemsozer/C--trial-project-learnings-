using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("kullancı adı giriniz : ");
            string Kullanıcıadı = Console.ReadLine();


            Console.WriteLine("şifre giriniz : " );
            string sifre = Console.ReadLine();

            if (Kullanıcıadı == "admin" && sifre == "123")
            {


                Console.WriteLine("kullanıcı girişi başarılı");



            }
           else
            {

                Console.WriteLine("kullanıcı adı veya şifre başarızı");

            }


            






        }
    }
}
