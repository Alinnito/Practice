using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_4
{
    class Program
    {
        class Human
        {
            public string name;
            public int level;
            public int force;


            public Human(string name, int level, int force)
            {
                this.name = name;
                this.level = level;
                this.force = force;
            }
        }
        static void Main(string[] args)
        {
            List<Human> peopleLst = new List<Human>() {
            new Human("Новиков Михаил Анатольевич", 1, 149 ),
            new Human("Кириллов Валерий Робертович", 2, 165 ),
            new Human("Давыдов Герман Оскарович", 3, 154 ),
            new Human("Ефремов Вольдемар Валентинович", 1, 168 ),
            new Human("Игнатов Альберт Евсеевич", 2, 156 ),
            new Human("Яковлев Осип Оскарович", 3, 154 ),
            new Human("Михеев Валентин Тимурович", 2, 170 ),
            new Human("Ширяев Николай Михайлович", 5, 154 ),
            new Human("Кузнецов Рудольф Русланович", 4, 165 ),
            new Human( "Калинин Орест Дмитриевич", 5, 143 )
            };


            Console.WriteLine("Топ 3 игроков по уровню");

            IEnumerable<Human> myquery = from human in peopleLst
                                            orderby human.level descending
                                            select human;
            foreach (Human a in myquery.Take(3))
            {
                Console.WriteLine(a.name + "\t" + a.level + "\t" + a.force);
            }

            Console.WriteLine("\nТоп 3 игроков по силе");

            myquery = from human in peopleLst
                      orderby human.force descending
                      select human;

            foreach (Human a in myquery.Take(3))
            {
                Console.WriteLine(a.name + "\t" + a.level + "\t" + a.force);
            }

            Console.ReadLine();
        }
    }
}