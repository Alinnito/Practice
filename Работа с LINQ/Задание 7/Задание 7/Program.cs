using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_7
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
            List<Soldier> lstSoldier1 = new List<Soldier>()   {
                new Soldier("Новиков Михаил Анатольевич", "Cтрелковое", "Лейтенант", 18),
                new Soldier("Шашков Ян Тихонович", "Cтрелковое", "Рядовой", 12),
                new Soldier("Быков Герман Оскарович", "Авиация", "Старший прапорщик", 20),
                new Soldier("Рогов Влас Ефимович", "Танки", "Генерал армии", 36),
                new Soldier("Игнатов Альберт Евсеевич", "Авиация", "Полковник", 18),
                new Soldier("Баврин Осип Оскарович", "Артиллерия", "Сержант", 12)};

            List<Soldier> lstSoldier2 = new List<Soldier>()   {
                new Soldier("Лаврентьев Арсений Максович", "Cтрелковое", "Лейтенант", 18),
                new Soldier("Цветков Арсений Христофорович", "Cтрелковое", "Рядовой", 12),
                new Soldier("Николаев Игнат Пётрович", "Авиация", "Старший прапорщик", 20),
                new Soldier("Шаров Леонид Германович", "Танки", "Генерал армии", 36)
            };

            Console.WriteLine("Первый отряд до изменений:");
            foreach (Soldier a in lstSoldier1)
            {
                Console.WriteLine(a.name);
            }
            Console.WriteLine("\nВторой отряд до изменений:");
            foreach (Soldier a in lstSoldier2)
            {
                Console.WriteLine(a.name);
            }

            IEnumerable<Soldier> myquery = from soldier in lstSoldier1
                                           where soldier.name[0] == 'Б'
                                           select soldier;

            List<Soldier> query = new List<Soldier>();
            foreach (Soldier a in myquery)
            {
                query.Add(a);
            }

            foreach (Soldier a in query)
            {
                lstSoldier2.Add(a);
                lstSoldier1.Remove(a);
            }
            

            Console.WriteLine("\n\nПервый отряд после изменений:");
            foreach (Soldier a in lstSoldier1)
            {
                Console.WriteLine(a.name);
            }
            Console.WriteLine("\nВторой отряд после изменений:");
            foreach (Soldier a in lstSoldier2)
            {
                Console.WriteLine(a.name);
            }
            Console.ReadLine();
        }
    }
}
