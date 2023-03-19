using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sayuretme
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int sayıuretme = 0;
            int tahminadeti = 1;
            Random rnd = new Random();
            sayıuretme = rnd.Next(1, 10);

            while (true)
            {

                Console.WriteLine("{0} Lütfen sistemin üretmiş olduğu sayıyı tahmin ediniz : " , tahminadeti);
                string rndkullanıcıgelen = Console.ReadLine();
                int rndkullanıcıgelenINT = int.Parse(rndkullanıcıgelen);

               // if (int.Parse(rndkullanıcıgelen) == sayıuretme)
                    if (rndkullanıcıgelenINT == sayıuretme)
                {

                    tahminadeti++;
                    Console.WriteLine("{0}. denemenizde tebrikler doğru tahmin ettiniz.");
                    break;



                }
                else
                {


                    Console.WriteLine("{0}.denemizde yanlış tahmin ettiniz.", tahminadeti);
                    tahminadeti++;
                }




            }
             


        }
    }
}
