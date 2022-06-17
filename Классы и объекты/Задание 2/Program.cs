using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_2
{
    class Program
    {
        class Point
        {
            private int _x;
            private int _y;
            private string _name;

            public int X
            {
                get
                {
                    return _x;
                }
            }

            public int Y
            {
                get
                {
                    return _y;
                }
            }

            public string Name
            {
                get
                {
                    return _name;
                }
            }

            public Point(int x, int y, string s)
            {
                _x = x;
                _y = y;
                _name = s;
            }

            public Point()
            {

            }
        }

        class Figure
        {
            private List<Point> points;
            private string name;
            public Figure() { }
            public Figure(Point p1, Point p2, Point p3, Point p4, Point p5)
            {
                points = new List<Point> { p1, p2, p3, p4, p5 };
            }
            public Figure(Point p1, Point p2, Point p3, Point p4)
            {
                points = new List<Point> { p1, p2, p3, p4 };
            }
            public Figure(Point p1, Point p2, Point p3)
            {
                points = new List<Point> { p1, p2, p3 };
            }

            private double LengthSide(Point A, Point B)
            {
                return Math.Sqrt((A.X - B.X) * (A.X - B.X) + (A.Y - B.Y) * (A.Y - B.Y));
            }

            public double PerimeterCalculator()
            {
                double perimeter = 0;
                for (int i = 0; i < points.Count - 1; i++)
                    perimeter += LengthSide(points[i], points[i + 1]);
                perimeter += LengthSide(points[0], points[points.Count - 1]);
                return Math.Round(perimeter, 2);
            }

            public string Name()
            {
                for (int i = 0; i < points.Count; i++)
                    name += points[i].Name;
                return name;
            }
        }

        static void Main(string[] args)
        {
            Figure f = new Figure();
            Console.WriteLine("Введите количество углов фигуры от 3 до 5");
            int count = Convert.ToInt32(Console.ReadLine());
            List<Point> points = new List<Point>();
            if (count == 3)
            {
                for (int i = 1; i <= count; i++)
                {
                    Console.WriteLine("Введите координаты " + i + "-й точки");
                    Console.WriteLine("Координата X:");
                    int x = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Координата Y:");
                    int y = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Введите название точки:");
                    string name = Console.ReadLine();
                    Point p = new Point(x, y, name);
                    points.Add(p);
                }
                f = new Figure(points[0], points[1], points[2]);
            }
            else if (count == 4)
            {
                for (int i = 1; i <= count; i++)
                {
                    Console.WriteLine("Введите координаты " + i + "-й точки");
                    Console.WriteLine("Координата X:");
                    int x = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Координата Y:");
                    int y = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Введите название точки:");
                    string name = Console.ReadLine();
                    Point p = new Point(x, y, name);
                    points.Add(p);
                }
                f = new Figure(points[0], points[1], points[2], points[3]);
            }
            else if (count == 5)
            {
                for (int i = 1; i <= count; i++)
                {
                    Console.WriteLine("Введите координаты " + i + "-й точки");
                    Console.WriteLine("Координата X:");
                    int x = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Координата Y:");
                    int y = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Введите название точки:");
                    string name = Console.ReadLine();
                    Point p = new Point(x, y, name);
                    points.Add(p);
                }
                f = new Figure(points[0], points[1], points[2], points[3], points[4]);
            }


            Console.WriteLine("Периметр: " + f.PerimeterCalculator());
            Console.WriteLine("Имя: " + f.Name());
            Console.Read();
        }
    }
}
