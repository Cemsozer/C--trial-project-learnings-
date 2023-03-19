using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp24
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Hashtable sozlukveritabani = new Hashtable();

            do
            {


                Console.Clear();
                Console.WriteLine("eklemek istediğinizi sözlük değerini yazınız");
                Console.Write("EN : ");
                string eng = Console.ReadLine();
                bool kontrol = sozlukveritabani.ContainsKey(eng);

                if (kontrol)
                {

                    Console.WriteLine("eklemek istediğiniz değer{0} sözlük içerisinde bulunmaktadır. {1] değerin türkçe karşılığıdır.", eng, sozlukveritabani[eng].ToString());

                }
                else
                {


                    Console.WriteLine("{0} ingilizce değerin türkçe karşılığını yazınız");
                    string tr = Console.ReadLine();
                    sozlukveritabani.Add(eng, tr);
                    Console.WriteLine("değer ekleme başarılı");

                }

                Console.WriteLine("yeni değer eklemek istiyor musunuz");



            }
            while (Console.ReadLine().ToUpper() != "E");
            
        
                 foreach (var item in sozlukveritabani.Keys)
            
            {

                Console.WriteLine("ENG : {0} = TR : {1}", item);


            }

        }
    }
}
