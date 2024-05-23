using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_3_1_
{
    /// <summary>
    /// Класс описывающий точку
    /// </summary>
    /// <typeparam name="T"></typeparam>
    class Point <T>
    {
        /// <summary>
        /// Поля
        /// </summary>
        T x, y;
        /// <summary>
        /// конструкторы
        /// </summary>
        /// <param name="x">x</param>
        /// <param name="y">y</param>
        public Point(T x, T y)
        {
            X = x;
            Y = y;
        }
        public Point() { }
        /// <summary>
        /// Свойства
        /// </summary>
        public T X { get => x; set => x = value; }
        public T Y { get => y; set => y = value; }
        /// <summary>
        /// Метод вывода инфы
        /// </summary>
        /// <returns></returns>
        public string OutPut()
        {
            return $"X = {x}; Y = {y}\n";
        }
    }
 
}
