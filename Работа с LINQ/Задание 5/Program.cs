using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_5
{
    class Program
    {
        class Tush
        {
            public string name;
            public int year;
            public int time;

            public Tush(string n, int y, int t)
            {
                name = n;
                year = y;
                time = t;
            }
        }
        static void Main(string[] args)
        {
            List<Tush> lstTush = new List<Tush>()   {
                new Tush("Гродфуд", 2019, 2),
                new Tush("Барс", 2020, 1),
                new Tush("Совок", 2019, 1),
                new Tush("Йошкар-Олинский мясокомбинат", 2021, 2),
                new Tush("Вкусвилл", 2019, 2),
                new Tush("Микоян", 2021, 2)};

            IEnumerable<Tush> myquery = from tush in lstTush
                                            where tush.year + tush.time < 2022
                                            select tush;

            foreach (Tush a in myquery)
            {
                Console.WriteLine(a.name);
            }
            Console.ReadLine();
        }
    }
}
