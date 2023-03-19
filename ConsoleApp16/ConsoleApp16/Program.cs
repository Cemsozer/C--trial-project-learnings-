using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Girilendeğeri0kadaryazdırma
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("lüfen bir sayı değeri giriniz : ");
            string sayı = Console.ReadLine();
            int gelensayı = int.Parse(sayı);
            
            while(gelensayı!=0)
            {


                Console.WriteLine(gelensayı);
                gelensayı = gelensayı - 1;


            }
            Console.WriteLine("örnek 1 işlemi tamamlandı");



        }
    }
}
