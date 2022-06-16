using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_1
{
    class Program
    {
        class Rectangle
        {
            private double _side1;
            private double _side2;
            public double Area
            {
                get
                {
                    return AreaCalculator();
                }
            }
            public double Perimeter
            {
                get
                {
                    return PerimeterCalculator();
                }
            }

            public Rectangle(double side1, double side2)
            {
                _side1 = side1;
                _side2 = side2;
            }

            private double AreaCalculator()
            {

                return _side1 * _side2;
            }

            private double PerimeterCalculator()
            {
                return (_side1 + _side2) * 2;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите длину первой стороны прямоугольника: ");
            double s1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите длину второй стороны прямоугольника: ");
            double s2 = Convert.ToDouble(Console.ReadLine());
            Rectangle rect = new Rectangle(s1, s2);
            Console.WriteLine("Площадь: " + rect.Area + "\nПериметр: " + rect.Perimeter);
            Console.ReadLine();
        }
    }
}
