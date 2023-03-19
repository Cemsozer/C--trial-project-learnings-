using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region
            Hashtable H1 = new Hashtable();
            H1.Add("car", "araba");
            H1.Add("house", "ev");
            
            H1.Add("cars", "araba");
            #endregion


            #region yardımcı metodlar
            bool kontrol1 = H1.Contains("house");
            bool kontrol2 = H1.Contains("door");

            bool kontrol3 = H1.ContainsKey("house");
            bool kontrol4 = H1.ContainsValue("araba");

            H1.Remove("cars");
            int koleksiyonıcındekitoplamdeger = H1.Count;
            H1.Clear();

            H1["house"] = "villa";



            #endregion
        }
    }
}
