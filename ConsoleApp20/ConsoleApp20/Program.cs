using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace detaylıarraylistyorumu
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int capacity = 0;// capacity genel bir terimdir 4,4 er artar arrayliste bulunabilecek değerlerin kısaca kapasitedir.
            int count = 0;// count bir sayaçtır döngünün kaç kez sayılması gerektiğini yazar bundan dolayısı ile programlamada ilk başta 0 dan başlatılır.

            string[] isimler = new string[10];//string bir metinsel değerdir yanında kapalı parantez ile dizi açılır.

            ArrayList A1 = new ArrayList();// arraylist tanımlıyoruz arraylistimizin ismi A1 
            #region Tek değer ekleme
            A1.Add("cem sözer");// array listin içine atılan ilk değer 
           
            capacity = A1.Capacity; // capacity ve count içini koyuyoruz döngüde sayılsın diye daha doğrusu integer olarak tanımladığımız capacity ve count A1 OLARAK SAYIYORUM 
            count = A1.Count;
            
            
            
            A1.Add(100);//array listin içine atılan 2.değer(önemli not: array listin içine integer veya string değeri girilebilir değer olarak sayılır 
            #endregion

            ArrayList A2 = new ArrayList();

            A2.Add("deneme"); 
            A2.Add("deneme2");
            A2.Add("deneme3");

            A1.AddRange(A2);// Addrange komutu başka bir arraylisti başka bir array liste eklemek için kullanılır 


            #region

            object C1 = A1[3];// burada C1 değeri object olarak kullanılmıştır bunun sebebi ise 3.değerin string veya integer olup olmadığı belli olmadığından dolayı kabul edilsin diye 
            string S1 = A1[3].ToString();// burada stinr bir değeri string dönüştürmüşsüzdür.
            

            A1[3] = "Hamza Atilla";// burada ise 3.değeri hamza atilla ya eşitledik.



            #endregion







        }
    }
}
