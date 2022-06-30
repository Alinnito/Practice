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
            string[] fields = new string[] { "ФИО", "Преступление"};
            List<string[]> peopleLst = new List<string[]>();

            string[] fields1 = new string[] { "Новиков Михаил Анатольевич", "Антиправительственное" };
            string[] fields2 = new string[] { "Шашков Ян Тихонович", "Антиправительственное" };
            string[] fields3 = new string[] { "Давыдов Герман Оскарович", "Воинское"};
            string[] fields4 = new string[] { "Рогов Влас Ефимович", "Экономическое" };
            string[] fields5 = new string[] { "Игнатов Альберт Евсеевич", "Антиправительственное" };
            string[] fields6 = new string[] { "Яковлев Осип Оскарович", "Экономическое"};
            string[] fields7 = new string[] { "Григорьев Остап Парфеньевич", "Воинское" };
            peopleLst.Add(fields1);
            peopleLst.Add(fields2);
            peopleLst.Add(fields3);
            peopleLst.Add(fields4);
            peopleLst.Add(fields5);
            peopleLst.Add(fields6);
            peopleLst.Add(fields7);

            IEnumerable<string[]> myquery = from human in peopleLst
                                            where human[1] != "Антиправительственное"
                                            select human;

            Console.WriteLine("Список до амнистии:");
            foreach (string[] a in peopleLst)
            {
                Console.WriteLine(a[0] + " - " + a[1]);
            }

            Console.WriteLine("\nСписок после амнистии:");
            foreach (string[] a in myquery)
            {
                Console.WriteLine(a[0] + " - " + a[1]);
            }

            Console.ReadLine();
        }
    }
}
