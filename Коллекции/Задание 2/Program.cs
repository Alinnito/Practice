using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            int sum = 0;
            int count = r.Next(5, 10);
            List<int> Arr = new List<int>();
            Console.WriteLine("Количество клиентов: " + count);
            Console.WriteLine("Суммы покупок: ");
            for (int i = 0; i < count; i++)
            {
                Arr.Add(r.Next(1, 10));
            }
            while (Arr.Count != 0)
            {
                for (int i = 0; i < Arr.Count; i++)
                {
                    Console.WriteLine(Arr[i]);
                }
                Console.WriteLine("Ваш счет: " + sum);
                sum += Arr.First();
                Arr.RemoveAt(0);
                Console.ReadKey();
                Console.Clear();
            }
            Console.WriteLine("Ваш счет: " + sum);
            Console.ReadKey();
        }
    }
}
