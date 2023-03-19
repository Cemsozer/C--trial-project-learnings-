using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KullanıcıdanGelendegerleritoplama
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("lütfen toplamak istediğiniz değerleri giriniz");
            

            int toplam = 0;
            while (true) 

            {

                string deger = Console.ReadLine();
                int deger2 = int.Parse(deger);

                if (deger2 < 0)
                    break;
                else
                    toplam = toplam + deger2;


            }
            Console.WriteLine("toplamları : {0}", toplam);
            

        }
    }
}

