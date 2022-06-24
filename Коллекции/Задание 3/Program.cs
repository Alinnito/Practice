using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> lst = new List<int>();
            int a;
            int sum = 0;
            string res = "";
            Console.WriteLine("Введите число");
            while (!res.Contains("exit"))
            {
                res = Console.ReadLine();
                if (res == "sum")
                {
                    for (int i = 0; i < lst.Count; i++)
                    {
                        sum += lst[i];
                    }
                    Console.WriteLine("Сумма: " + sum);
                    sum = 0;
                }
                else if (res == "" || !int.TryParse(res, out a))
                {
                    Console.WriteLine("Введите число");
                }
                else if (res == "exit")
                    break;
                else
                {
                    a = Convert.ToInt32(res);
                    lst.Add(a);
                }
            } 
        }
    }
}
