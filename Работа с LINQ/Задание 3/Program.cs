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
            string[] fields = new string[] { "ФИО", "Возраст", "Заболевание"};
            List<string[]> peopleLst = new List<string[]>();

            string[] fields1 = new string[] { "Новиков Михаил Анатольевич", "17", "Гастрит" };
            string[] fields2 = new string[] { "Шашков Ян Тихонович", "43", "Ожирение" };
            string[] fields3 = new string[] { "Давыдов Герман Оскарович", "23", "Гастрит" };
            string[] fields4 = new string[] { "Рогов Влас Ефимович", "39", "Мигрень" };
            string[] fields5 = new string[] { "Игнатов Альберт Евсеевич", "24", "Мигрень" };
            string[] fields6 = new string[] { "Яковлев Осип Оскарович", "45", "Мигрень" };
            string[] fields7 = new string[] { "Григорьев Остап Парфеньевич", "57", "Ожирение" };
            peopleLst.Add(fields1);
            peopleLst.Add(fields2);
            peopleLst.Add(fields3);
            peopleLst.Add(fields4);
            peopleLst.Add(fields5);
            peopleLst.Add(fields6);
            peopleLst.Add(fields7);

            int res = 5;
            IEnumerable<string[]> myquery;
            while (res != 0)
            {
                Console.WriteLine("Выберите действие \n1 - Отсортировать всех больных по фио \n2 - Отсортировать всех больных по возрасту \n3 - Вывести больных с определенным заболеванием \n0 - Выйти");
                res = Convert.ToInt32(Console.ReadLine());
                if (res == 1)
                {
                    myquery = from human in peopleLst
                              orderby human[0]
                              select human;
                }
                else if (res == 2)
                {
                    myquery = from human in peopleLst
                              orderby human[1]
                              select human;
                }
                else if (res == 3)
                {
                    Console.WriteLine("Введите название заболевания");
                    string name = Console.ReadLine().Trim();
                    myquery = from human in peopleLst
                              where human[2] == name
                              select human;
                }
                else
                    continue;
                foreach (string[] a in myquery)
                {
                    Console.WriteLine(a[0] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
