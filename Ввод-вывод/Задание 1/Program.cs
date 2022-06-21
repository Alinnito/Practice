using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Задание_1
{
    class Program
    {
        static string path = @"C:\Users\user\source\repos\Спасова\-\Ввод-вывод\Для задания 1\";
        static void Main(string[] args)
        {
            DirectoryInfo directoryinfo = new DirectoryInfo("папка");

            for (int i = 1; i <= 100; i++)
                if(!directoryinfo.Exists)
                    Directory.CreateDirectory(path+i);

            Console.WriteLine("Enter для удаления");
            Console.ReadLine();

            for (int i = 1; i <= 100; i++)
                if (!directoryinfo.Exists)
                    Directory.Delete(path + i);
        }
    }
}
