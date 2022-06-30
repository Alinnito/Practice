using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] fields = new string[] { "ФИО", "Заключен", "Рост", "Вес", "Национальность" };
            List<string[]> peopleLst = new List<string[]>();

            string[] fields1 = new string[] { "Новиков Михаил Анатольевич",     "1", "180", "90", "русский" };
            string[] fields2 = new string[] { "Шашков Ян Тихонович",            "0", "185", "110", "русский" };
            string[] fields3 = new string[] { "Давыдов Герман Оскарович",       "0", "180", "98", "русский" };
            string[] fields4 = new string[] { "Рогов Влас Ефимович",            "1", "168", "95", "украинец" };
            string[] fields5 = new string[] { "Игнатов Альберт Евсеевич",       "0", "202", "95", "украинец" };
            string[] fields6 = new string[] { "Яковлев Осип Оскарович",         "0", "180", "90", "белорус" };
            string[] fields7 = new string[] { "Григорьев Остап Парфеньевич",    "0", "170", "85", "белорус" };
            peopleLst.Add(fields1);
            peopleLst.Add(fields2);
            peopleLst.Add(fields3);
            peopleLst.Add(fields4);
            peopleLst.Add(fields5);
            peopleLst.Add(fields6);
            peopleLst.Add(fields7);

            Console.WriteLine("Введите данные преступника, которого надо найти");
            Console.WriteLine("Введите рост преступника");
            string hieght = Console.ReadLine().Trim().ToLower();
            Console.WriteLine("Введите вес преступника");
            string wieght = Console.ReadLine().Trim().ToLower();
            Console.WriteLine("Введите национальность преступника");
            string country = Console.ReadLine().Trim().ToLower();

            IEnumerable<string[]> myquery = from human in peopleLst
                                            where human[2] == hieght &&
                                            human[3] == wieght &&
                                            human[4] == country &&
                                            human[1] == "0"
                                            select human;
            bool p = true;
            foreach(string[] a in myquery)
            {
                Console.WriteLine(a[0] + " ");
                p = false;
            }
            if (p)
                Console.WriteLine("Не удалось найти преступника");
           Console.ReadLine();
        }
    }
}
