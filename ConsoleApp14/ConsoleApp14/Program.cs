using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    internal class Program
    {
        static void Main(string[] args)
        {

            for (int i = 1; i <= 9; i++)

            {


                for (int y = 1; y <= 9; y++)
                {
                    int carpimsonuc = i * y;
                    Console.Write("{0}*{1}={2}\t ", i , y , carpimsonuc);
                }
                Console.WriteLine();
                Console.ReadLine();
            }
           
            

        }
    }
}
