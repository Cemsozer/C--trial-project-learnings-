using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("sayı 1 değerini giriniz :");
            string str1 = Console.ReadLine();

            Console.WriteLine("sayı 2 değerini giriniz : ");
            string str2 = Console.ReadLine();

            decimal say1 = Convert.ToDecimal(str1);
            decimal say2 = Convert.ToDecimal(str2);

            decimal sonuc = say1 + say2; 

            if (sonuc >= 100)
            {

                Console.WriteLine("sayı 100 den büyüktür.");

            




            }
            else if (sonuc >= 50)
            {

                Console.WriteLine("girilen değer 50 den büyük");


            }
            else 
            {


                Console.WriteLine("50 den küçük") 

            }
           








        }
    }
}
