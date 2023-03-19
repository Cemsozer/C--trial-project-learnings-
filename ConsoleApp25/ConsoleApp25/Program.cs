using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp25
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Queue Q1 = new Queue();
            Q1.Enqueue("bir");
            Q1.Enqueue("iki");
            Q1.Enqueue("üç");
            Q1.Enqueue("dört");

            object O1 = Q1.Peek();
            object O2 = Q1.Dequeue();



        }
    }
}
