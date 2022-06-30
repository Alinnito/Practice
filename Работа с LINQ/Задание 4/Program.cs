using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_4
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] fields = new string[] { "ФИО", "Уровень", "Сила" };
            List<string[]> peopleLst = new List<string[]>();

            string[] fields1 = new string[] { "Новиков Михаил Анатольевич", "1", "149"};
            string[] fields2 = new string[] { "Кириллов Валерий Робертович", "2", "165"};
            string[] fields3 = new string[] { "Давыдов Герман Оскарович", "3", "154" };
            string[] fields4 = new string[] { "Ефремов Вольдемар Валентинович", "1", "168" };
            string[] fields5 = new string[] { "Игнатов Альберт Евсеевич", "2", "156" };
            string[] fields6 = new string[] { "Яковлев Осип Оскарович", "3", "154" };
            string[] fields7 = new string[] { "Михеев Валентин Тимурович", "2", "170" };
            string[] fields8 = new string[] { "Ширяев Николай Михайлович", "5", "154"};
            string[] fields9 = new string[] { "Кузнецов Рудольф Русланович", "4", "165" };
            string[] fields10 = new string[] { "Калинин Орест Дмитриевич", "5", "143" };
            peopleLst.Add(fields1);
            peopleLst.Add(fields2);
            peopleLst.Add(fields3);
            peopleLst.Add(fields4);
            peopleLst.Add(fields5);
            peopleLst.Add(fields6);
            peopleLst.Add(fields7);
            peopleLst.Add(fields8);
            peopleLst.Add(fields9);
            peopleLst.Add(fields10);

            Console.WriteLine("Топ 3 игроков по уровню");

            IEnumerable<string[]> myquery = from human in peopleLst
                                            orderby human[1] descending
                                            select human ;
            foreach (string[] a in myquery.Take(3))
            {
                Console.WriteLine(a[0] + "\t" + a[1] + "\t" + a[2]);
            }

            Console.WriteLine("\nТоп 3 игроков по силе");

            myquery = from human in peopleLst
                      orderby human[2] descending
                      select human;

            foreach (string[] a in myquery.Take(3))
            {
                Console.WriteLine(a[0] + "\t" + a[1] + "\t" + a[2]);
            }

            Console.ReadLine();
        }
    }
}
