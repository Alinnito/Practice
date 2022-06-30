using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_1
{
    class Program
    {
        class Human
        {
            public string name;
            public bool concluded;
            public int height;
            public int weight;
            public string nationality;

            public Human(string name, bool concluded, int height, int weight, string nationality)
            {
                this.name = name;
                this.concluded = concluded;
                this.height = height;
                this.weight = weight;
                this.nationality = nationality;
            }
        }

        
        static void Main(string[] args)
        {
            List<Human> peopleLst = new List<Human>()
            {new Human("Новиков Михаил Анатольевич", false, 180, 110, "русский"),
            new Human("Шашков Ян Тихонович", false, 185, 90, "русский"),
            new Human("Давыдов Герман Оскарович", true, 180, 130, "русский"),
            new Human("Рогов Влас Ефимович", false, 180, 90, "украинец"),
            new Human("Игнатов Альберт Евсеевич", false, 185, 140, "украинец"),
            new Human("Яковлев Осип Оскарович", false, 190, 90, "белорус"),
            new Human("Григорьев Остап Парфеньевичч", true, 180, 85, "белорус")
            };


            Console.WriteLine("Введите данные преступника, которого надо найти");
            Console.WriteLine("Введите рост преступника");
            int hieght = Convert.ToInt32(Console.ReadLine().Trim().ToLower());
            Console.WriteLine("Введите вес преступника");
            int wieght = Convert.ToInt32(Console.ReadLine().Trim().ToLower());
            Console.WriteLine("Введите национальность преступника");
            string country = Console.ReadLine().Trim().ToLower();

            IEnumerable<Human> myquery = from human in peopleLst
                                            where human.height == hieght &&
                                            human.weight == wieght &&
                                            human.nationality == country &&
                                            human.concluded == false
                                            select human;
            bool p = true;
            foreach (Human a in myquery)
            {
                Console.WriteLine(a.name);
                p = false;
            }
            if (p)
                Console.WriteLine("Не удалось найти преступника");
            Console.ReadLine();
        }
    }
}
