using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_3_2_
{
    /// <summary>
    ///Класс описывающий треугольник
    /// </summary>
    class Triangle<N>
    {
        /// <summary>
        /// Поля треугольника
        /// </summary>
        N a, b, c;
        public N A { get; set; }
        public N B { get; set; }
        public N C { get; set; }
        /// <summary>
        /// Конмтруктор треугольника
        /// </summary>
        /// <param name="a">А</param>
        /// <param name="b">B</param>
        /// <param name="c">C</param>
        public Triangle(N a, N b, N c)
        {
            if ((dynamic)a + b > c && (dynamic)a + c > b && (dynamic)b + c > a)
            {
                A = a;
                B = b;
                C = c;
            }
            else { Console.WriteLine("Треугольник с такими сторонами не существет"); }
        }
        public Triangle() { }
        /// <summary>
        /// Метод вывода
        /// </summary>
        /// <returns></returns>
        public void OutPut()
        {
            Console.WriteLine($"Треугольник имеет стороны: A - {A}; B - {B}; C - {C}.");
        }
        /// <summary>
        /// метод вычислсяющий площадь треугольника
        /// </summary>
        /// <returns>площадь</returns>
        public double Area()
        {
            double a = Convert.ToDouble(A);
            double b = Convert.ToDouble(B);
            double c = Convert.ToDouble(C);
            double p = (a + b + c) / 2;
            double area = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            return area;

        }
    }
}
