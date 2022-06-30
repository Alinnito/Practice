using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_2
{
    class Program
    {

        class Human
        {
            public string name;
            public string сrime;

            public Human(string name, string сrime)
            {
                this.name = name;
                this.сrime = сrime;
            }
        }

        static void Main(string[] args)
        {
            List<Human> peopleLst = new List<Human>() { 
            new Human("Новиков Михаил Анатольевич", "Антиправительственное"),
            new Human("Шашков Ян Тихонович", "Антиправительственное"),
            new Human("Давыдов Герман Оскарович", "Воинское"),
            new Human("Рогов Влас Ефимович", "Экономическое"),
            new Human("Игнатов Альберт Евсеевич", "Антиправительственное"),
            new Human("Яковлев Осип Оскарович", "Экономическое"),
            new Human("Григорьев Остап Парфеньевич", "Воинское"),
            };


            IEnumerable<Human> myquery = from human in peopleLst
                                            where human.сrime != "Антиправительственное"
                                            select human;

            Console.WriteLine("Список до амнистии:");
            foreach (Human a in peopleLst)
            {
                Console.WriteLine(a.name + " - " + a.сrime);
            }

            Console.WriteLine("\nСписок после амнистии:");
            foreach (Human a in myquery)
            {
                Console.WriteLine(a.name + " - " + a.сrime);
            }

            Console.ReadLine();
        }
    }
}