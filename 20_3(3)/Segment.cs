using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_3_3_
{
    /// <summary>
    /// Класс описывающий отрезок
    /// </summary>
    /// <typeparam name="P"></typeparam>
    class Segment <P>
    {
       /// <summary>
       /// Поля класса
       /// </summary>
        P x1;
        P y1;
        P x2;
        P y2;
        /// <summary>
        /// Конструкторы класса
        /// </summary>
        /// <param name="x1"></param>
        /// <param name="y1"></param>
        /// <param name="x2"></param>
        /// <param name="y2"></param>
        public Segment(P x1, P y1, P x2, P y2)
        {
           
            X1 = x1;
            Y1 = y1;
            X2 = x2;
            Y2 = y2;
        }
        public Segment() { }
        /// <summary>
        /// Свойства класса
        /// </summary>
        public P X1 { get => x1; set => x1 = value; }
        public P Y1 { get => y1; set => y1 = value; }
        public P X2 { get => x2; set => x2 = value; }
        public P Y2 { get => y2; set => y2 = value; }
        /// <summary>
        /// Метод вывода информации
        /// </summary>
        public void OutPut()
        {
            Console.WriteLine($"Координаты точки A: ({x1}:{y1})\nКоординаты точки B: ({x2}:{y2}) ");
        }
        /// <summary>
        /// Метод вычисляющий длину отрезка
        /// </summary>
        /// <returns></returns>
        public dynamic LengthOfTheSegment()
        {
            return $"{Math.Sqrt(Math.Pow((dynamic)X2 - (dynamic)X1, 2) + Math.Pow((dynamic)Y2 - (dynamic)Y1, 2)):f2}";
        }
    }
}
