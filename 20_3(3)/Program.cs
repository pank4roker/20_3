using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_3_3_
{
    class Program
    {
        static void Main(string[] args)
        {
            //универсальный параметр типа int
            Segment<int> segment1 = new Segment<int>(1, 2, 4, -5);
            segment1.OutPut();
            Console.WriteLine(segment1.LengthOfTheSegment());
            //универсальный параметр типа long
            Segment<long> segment2 = new Segment<long>(1, 2, 4, -5);
            segment2.OutPut();
            Console.WriteLine(segment2.LengthOfTheSegment());
            //универсальный параметр типа double
            Segment<double> segment3 = new Segment<double>(4.4, 5.5, -2.2, -3.5);
            segment3.OutPut();
            Console.WriteLine(segment2.LengthOfTheSegment());
            Console.ReadLine();
        }
    }
}
