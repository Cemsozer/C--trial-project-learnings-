using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("lütfen oluşturmak istediğiniz veri kümesi uzunluğunu giriniz : ");//ekrana yazı yazıyoruz 
            string uygulamadiziuzunluk = Console.ReadLine(); //console'dan gelen değeri buradan alıyoruz
            int uygulamadiziuzunlukInt = int.Parse(uygulamadiziuzunluk);// uygulamadiziuzunluğumuzu string değerini integera çeviriyoruz.
                
                int[] uygulama1dizi = new int[uygulamadiziuzunlukInt];// [] değeri dizi oluşturmak için kullanılır int[] uygulam1dizi tanımladıktan sonra console'dan çevirdiğimiz
            //değeri dizi sayısı olarak alınsın diye new int[]olarak içine yazıyorum.
            // uygulama1dizi int olarak almamızın sebebi kullanıcının dizinin boyutunu kendisinin ayarlaması için oluşturulmuştur.

            for (int uygulamasayac = 0; uygulamasayac < uygulama1dizi.Length; uygulamasayac++)  // burada tekrar tekrar dönsün diye for döngünüsü kullanıyoruz
                                                                                               // uygulama sayacı 0 eşitlememizin sebebi uygulamanın 0 dan başlaması 
                                                                                               // uygulamsayacı uygulama1.dizi.lengt; küçük olmasının sebebi ise 
                                                                                               // kullancıdan aldığımız değerden fazla olmaması için 
                                                                                               // sonunda ise her for döngüsünden sonra sayacın 1er artması


            {

                Console.WriteLine("{0}. index'e denk gelen değeri giriniz : ");
                uygulama1dizi[uygulamasayac] = int.Parse(Console.ReadLine());//uygulama 1 dizisi'nin içerisine uygulamasayacı kullanarak değer aktarımı yapacağız
                                                                             //integer bir diziydi öncelikle kullanıcdan gelen değeri string olarak gelen değeri integer olarak
                                                                             // alıp string dönüştürmek için int.parse yapıyorum kullanı değerini okumak için console.readline


            }

            Console.WriteLine("tebrikler dizinin içerisindeki tüm alanları doldurdunuz.");
            Console.WriteLine("dizi içerisindeki değerler ve toplam, ortalama değeri aşağıdaki gibidir");

            int uygulama1toplam = 0, uygulama1ortalama = 0;
            foreach (int item in uygulama1dizi)//uygulama 1 dizi içerisinde dönmek için foreach döngünüsü kullandık item genel kullanılan keylerden birisi olduğu için yazdık 
            {
                Console.WriteLine(item); // her döndüğünde yazması için item yazdık 
                uygulama1toplam = uygulama1toplam + item;

            }

            Console.WriteLine("+--------------------------------");
            Console.WriteLine(uygulama1toplam);
            Console.WriteLine("dizi içerisindeki eleman sayısı : {0}",uygulama1dizi.Length);
            uygulama1ortalama = uygulama1toplam / uygulama1dizi.Length;
            Console.WriteLine("Ortalama : {0}" , uygulama1ortalama);


        }
    }
}
