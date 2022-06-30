using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_6
{
    class Program
    {
        class Soldier
        {
            public string name;
            public string armament;
            public string rank;
            public int time;

            public Soldier(string n, string a, string r, int t)
            {
                name = n;
                armament = a;
                rank = r;
                time = t;
            }
        }
        static void Main(string[] args)
        {
            List<Soldier> lstSoldier = new List<Soldier>()   {
                new Soldier("Новиков Михаил Анатольевич", "Cтрелковое", "Лейтенант", 18),
                new Soldier("Шашков Ян Тихонович", "Cтрелковое", "Рядовой", 12),
                new Soldier("Давыдов Герман Оскарович", "Авиация", "Старший прапорщик", 20),
                new Soldier("Рогов Влас Ефимович", "Танки", "Генерал армии", 36),
                new Soldier("Игнатов Альберт Евсеевич", "Авиация", "Полковник", 18),
                new Soldier("Яковлев Осип Оскарович", "Артиллерия", "Сержант", 12)};

            IEnumerable<string> myquery = from soldier in lstSoldier
                                        select soldier.name + " - " + soldier.rank;

            foreach (string a in myquery)
            {
                Console.WriteLine(a);
            }
            Console.Read();
        }
    }
}
