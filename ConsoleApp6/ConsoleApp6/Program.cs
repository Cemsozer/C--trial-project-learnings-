using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Merhaba");

            Console.WriteLine("isminizi : ");
            string isim = Console.ReadLine();

            Console.WriteLine("soyisminiz : ");
            string soyisim = Console.ReadLine();

            Console.WriteLine("Doğum yılınız : ?");
            string Dogumyılı = Console.ReadLine();
            Console.Clear();
            
            int yıl = Convert.ToInt32(Dogumyılı);
            int mevcutyıl = DateTime.Now.Year;
            int yas = mevcutyıl - yıl;

            string mesaj = "Merhaba"  +  isim +  " "  + soyisim + " " + yas + "yaşındasınız...";
            Console.WriteLine(mesaj);
            Console.ReadLine();






        }
    }
}
