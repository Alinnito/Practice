using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_3
{
    class Program
    {
        class Human
        {
            public string name;
            public int age;
            public string illness;

            public Human(string name, int age, string illness)
            {
                this.name = name;
                this.age = age;
                this.illness = illness;
            }
        }

        static void Main(string[] args)
        {
            List<Human> peopleLst = new List<Human>() {
            new Human("Новиков Михаил Анатольевич", 17, "Гастрит"),
            new Human("Шашков Ян Тихонович", 43, "Ожирение"),
            new Human("Давыдов Герман Оскарович", 23, "Гастрит"),
            new Human("Рогов Влас Ефимович", 39, "Мигрень"),
            new Human("Игнатов Альберт Евсеевич", 24, "Мигрень"),
            new Human("Яковлев Осип Оскарович", 45, "Мигрень"),
            new Human("Григорьев Остап Парфеньевич", 57, "Ожирение")
            };

            int res = 5;
            IEnumerable<Human> myquery;
            while (res != 0)
            {
                Console.WriteLine("Выберите действие \n1 - Отсортировать всех больных по фио \n2 - Отсортировать всех больных по возрасту \n3 - Вывести больных с определенным заболеванием \n0 - Выйти");
                res = Convert.ToInt32(Console.ReadLine());
                if (res == 1)
                {
                    myquery = from human in peopleLst
                              orderby human.name
                              select human;
                }
                else if (res == 2)
                {
                    myquery = from human in peopleLst
                              orderby human.age
                              select human;
                }
                else if (res == 3)
                {
                    Console.WriteLine("Введите название заболевания");
                    string name = Console.ReadLine().Trim();
                    myquery = from human in peopleLst
                              where human.illness == name
                              select human;
                }
                else
                    continue;
                foreach (Human a in myquery)
                {
                    Console.WriteLine(a.name + " - " + a.age + " - " + a.illness);
                }
                Console.WriteLine();
            }
        }
    }
}