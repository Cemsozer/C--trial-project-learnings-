using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string kullanıcısecim = String.Empty;
            ArrayList degerlistesi = new ArrayList();
            do
            {
                Console.Clear();
                Console.WriteLine("Menu");
                Console.WriteLine("1 - Değer ekle");
                Console.WriteLine("2 - değer listele");
                Console.WriteLine("3 - değer ara");
                Console.WriteLine("4- değer düzenle");
                Console.WriteLine("5 - değeri sil");
                Console.WriteLine("6 - uygulama çıkış");
                Console.Write("seçiniz : ");
                 kullanıcısecim = Console.ReadLine();

                

                switch (kullanıcısecim)
                {

                    case "1":
                        Console.Write("lütfen eklemek istediğiniz değeri giriniz : ");
                        string kullanıcıDeger = Console.ReadLine();
                        degerlistesi.Add(kullanıcıDeger);
                        Console.WriteLine("Değeriniz başarılı bir şekilde eklendi");
                        System.Threading.Thread.Sleep(2000);


                        break;

                    case "2":
                        for (int i =0; i<degerlistesi.Count; i++)
                        {
                            Console.WriteLine("{0}. Değer = {1}", i, degerlistesi[i]);
                            Console.WriteLine("Devam etmek için bir tuşa basınız.");
                            Console.ReadLine();
                        }
                        break;

                    case "3":

                        Console.WriteLine("aramak istediğiniz değeri giriniz");
                        string kullaniciaramadegeri = Console.ReadLine();
                        bool kontrol = degerlistesi.Contains(kullaniciaramadegeri);
                        if(kontrol)
                        {
                            int bulunanındex = degerlistesi.IndexOf(kullaniciaramadegeri);
                            string bulunandeger = degerlistesi[bulunanındex].ToString();
                            Console.WriteLine("değeriniz bulundu : index sırarsı :{0} - Değer : {1}",bulunanındex, bulunandeger);
                        }

                        else
                        {

                            Console.WriteLine("aradığınız kriterde bir değer bulunamadı");

                        }
                        System.Threading.Thread.Sleep(1000);
                        break;

                    case "4":

                        Console.WriteLine("Güncellemek istediğiniz değeri giriniz : ");
                        string kullaniciduzenlenecekdeger = Console.ReadLine();

                        Console.WriteLine("{0}değerini hangi değer ile güncellemek istiyorsunuz", kullaniciduzenlenecekdeger);
                        string kullaniciyenideger = Console.ReadLine();
                        if (degerlistesi.Contains(kullaniciduzenlenecekdeger))
                        {
                            int kullanıcıhedefındex = degerlistesi.IndexOf(kullaniciduzenlenecekdeger);
                            degerlistesi[kullanıcıhedefındex] = kullaniciyenideger;
                            
                            Console.WriteLine("değeriniz güncellendi");
                        }

                        else
                        {

                            Console.WriteLine("aradığınız değer liste içerisinde bulunamadı ");

                        }
                        break;



                    case "5":



                        break;


                    default:
                        break;

                }
            } while (kullanıcısecim != "6");



        }
    }
}
