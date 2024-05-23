using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_3_2_
{
    class Program
    {
        static void Main(string[] args)
        {
            //универсальный параметр типа int
            Triangle<int> triangle1 = new Triangle<int>(1,2,3);
            triangle1.OutPut();
            Console.WriteLine($"Площадь равна: {triangle1.Area()}");
            //универсальный параметр типа uint
            Triangle<uint> triangle2 = new Triangle<uint>(3, 3, 3);
            triangle2.OutPut();
            Console.WriteLine($"Площадь равна: {triangle2.Area():f2}");
            //универсальный параметр типа double
            Triangle<double> triangle3 = new Triangle<double>(5.5, 7.2, 8.9);
            triangle3.OutPut();
            Console.WriteLine($"Площадь равна: {triangle3.Area():f2}");
            Console.ReadLine();

        }
    }
}
