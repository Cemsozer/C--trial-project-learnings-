using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("kullanıcı değeri giriniz : ");
            string kullanıcıdegeri = Console.ReadLine();

            if (kullanıcıdegeri == "ABC" || kullanıcıdegeri == "123" || kullanıcıdegeri == "BCD")
            {


                Console.WriteLine("kullanıcı değerleri doğrudur");

            }
            else if(kullanıcıdegeri == "HHH" || kullanıcıdegeri == "AAA" || kullanıcıdegeri == "BBB")
            {

                Console.WriteLine("kullanıcı değeri engellenmiştir hatalı giriş");

            }
            else
            {

                Console.WriteLine("Kullanıcı değeri yanlıştır");

            }


        }
    }
}
