using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Not 1 değerini giriniz : ");
            string not1 = Console.ReadLine();

            Console.WriteLine("not 2 değerini giriniz : ");
            string not2 = Console.ReadLine();

            Console.WriteLine(" Not 3 değerini giriniz : ");
            string not3 = Console.ReadLine();

            decimal dnot1 = Convert.ToDecimal(not1);
            decimal dnot2 = Convert.ToDecimal(not2);
            decimal dnot3 = Convert.ToDecimal(not3);

            decimal sonuc = (dnot1 + dnot2 + dnot3) / 3;
            
            
            bool kontrolsonuc = sonuc >= 45;
           
            Console.WriteLine("ortalama 45 değerinden büyük veya eşit " + kontrolsonuc );
            Console.ReadLine();
            

          



        }
    }
}
