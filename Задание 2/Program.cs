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
            public int X { get; }
            public int Y { get; }
            public string name { get; }

            public Point (int x, int y, string s)
            {
                X = x;
                Y = y;
                name = s;
            }

            public Point()
            {

            }
        }

        class Figure : Point
        {
            private List<Point> points;
            private string name;
            public Figure(Point p1, Point p2, Point p3, Point p4, Point p5)
            {
                points = new List<Point> {p1, p2, p3, p4, p5 };
            }
            public Figure(Point p1, Point p2, Point p3, Point p4)
            {
                points = new List<Point> { p1, p2, p3, p4 };
            }
            public Figure(Point p1, Point p2, Point p3)
            {
                points = new List<Point> { p1, p2, p3};
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
                    name += points[i].name;
                return name;
            }
        }

        static void Main(string[] args)
        {
            Point p1 = new Point(0, 0, "a");
            Point p2 = new Point(0, 5, "b");
            Point p3 = new Point(4, 5, "c");
            Point p4 = new Point(4, 0, "d");

            Figure f = new Figure(p1, p2, p3, p4);

            Console.WriteLine("Периметр: " + f.PerimeterCalculator());
            Console.WriteLine("Имя: " + f.Name());
            Console.Read();
        }
    }
}
