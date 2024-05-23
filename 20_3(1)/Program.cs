using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_3_1_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //универсальный параметр типа int
            Point<int> point1 = new Point<int>(1, 8);
            Console.Write(point1.OutPut());
            //универсальный параметр типа uint
            Point<uint> point2 = new Point<uint>(3, 4);
            Console.Write(point2.OutPut());
            //универсальный параметр типа double
            Point<double> point3 = new Point<double>(7.4,9.8);
            Console.Write(point3.OutPut());
            Console.ReadKey();
        }
    }
}
