using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine(" 1.toplama");
            Console.WriteLine("2.çıkarma ");
            Console.WriteLine("3.çarpma");
            Console.WriteLine("4.bölme");
            string kullanıcısecimi = Console.ReadLine();

            Console.Write("sayı 1 değerini giriniz");
            string s1 = Console.ReadLine();

            Console.Write("sayı 2 değerini giriniz");
            string s2 = Console.ReadLine();

            double sayı1 = Convert.ToDouble(s1);
            double sayı2 = Convert.ToDouble(s2);

            if (kullanıcısecimi == "1")
            {

                double toplam = sayı1 + sayı2;
                Console.WriteLine("toplam : " + toplam);



            }


            else if (kullanıcısecimi == "2")
            {

                double cıkartma = sayı1 - sayı2;
                Console.WriteLine("çıkartma : " + cıkartma);




            }


            else if (kullanıcısecimi == "3")
            {

                double carpma = sayı1 * sayı2;
                Console.WriteLine("çarpma : " + carpma);



            }
            else if (kullanıcısecimi == "4")
            {

                if (sayı2 == 0) ;
                {
                    Console.WriteLine("bölen değer 0 olamaz");
                }

                double bolme = sayı1 / sayı2;
                Console.WriteLine("bölme : " + bolme);

            }





        }
    }
}
