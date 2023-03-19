using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace AZsıralama
{
    internal class Program
    {
        static void Main(string[] args)
        {


            ArrayList odevliste = new ArrayList();

            odevliste.Add("ahmet");
            odevliste.Add("mehmet");
            odevliste.Add("cem");
            odevliste.Add("coskun");
            odevliste.Add("ata");
            odevliste.Add("göksel");
            odevliste.Add("anan");
            odevliste.Add("deneme");
            odevliste.Add("anannn");
            odevliste.Add("ben");

            //tüm değerleri A-Z çevir 
            odevliste.Sort();
            odevliste.Reverse();



        }
    }
}
