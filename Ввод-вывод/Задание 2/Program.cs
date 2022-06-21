using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Задание_2
{
    class Program
    {
        static string path = @"C:\Users\user\source\repos\Спасова\-\Ввод-вывод\1.txt";
        static void Main(string[] args)
        {
            using (FileStream fs = File.Create(path)) { }
                using (StreamWriter sw = new StreamWriter(path))
                {
                    for(int i = 0; i < 5; i++)
                        sw.WriteLine(i);
                }

            using (StreamReader sr = new StreamReader(path))
            {
                while (!sr.EndOfStream)
                    Console.WriteLine(sr.ReadLine());
            }
            Console.ReadLine();
        }
    }
}
