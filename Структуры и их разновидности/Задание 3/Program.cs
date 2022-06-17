using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_3
{
    public static class ColorType
    {
        enum Colors
        {
            WHITE = 1,
            RED = 2,
            GREEN = 3,
            BLUE = 4,
            YELLOW = 5
        }
        public static void Print(string stroka, int color)
        {
            switch (color)
            {
                case 1:
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine(stroka);
                    Console.ResetColor();
                    break;
                case 2:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(stroka);
                    Console.ResetColor();
                    break;
                case 3:
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(stroka);
                    Console.ResetColor();
                    break;
                case 4:
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine(stroka);
                    Console.ResetColor();
                    break;
                case 5:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine(stroka);
                    Console.ResetColor();
                    break;
                default:
                    Console.WriteLine("Цвета с таким номером нет");
                    break;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите цифру от 1 до 5 для выбора цвета: \n1 - Белый, \n2 - Красный,\n3 - Зелёный,\n4 - Синий,\n5 - Жёлтый");
            int numColor = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите строку: ");
            string str = Console.ReadLine();

            ColorType.Print(str, numColor);
            Console.ReadKey();
        }
    }
}