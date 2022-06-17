using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_1
{
    public struct Train
    {
        private string name;
        public int number;
        private DateTime time;

        public Train(string name, int number, DateTime time)
        {
            this.name = name;
            this.number = number;
            this.time = time;
        }
        public void Info()
        {
            Console.WriteLine("Название: " + name + "\nНомер поезда: " + number + "\nВремя отправления: " + time);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Train[] train = new Train[8];

            for (int i = 0; i < train.Length; i++)
            {
                Console.WriteLine("Введите название поезда: ");
                string name = Console.ReadLine();
                Console.WriteLine("Введите номер поезда: ");
                int number = int.Parse(Console.ReadLine());
                Console.WriteLine("Введите время отправления (в формате чч:мм:сс): ");
                DateTime time = DateTime.Parse(Console.ReadLine());

                train[i] = new Train(name, number, time);
            }

            for (int i = 0; i < train.Length - 1; i++)
            {
                for (int j = i + 1; j < train.Length; j++)
                {
                    if (train[i].number > train[j].number)
                    {
                        Train sort = train[i];
                        train[i] = train[j];
                        train[j] = sort;
                    }
                }
            }
            for (int i = 0; i < train.Length; i++)
            {
                train[i].Info();
                Console.WriteLine();
            }

            Console.WriteLine("Введите номер поезда для поиска: ");
            int input = Convert.ToInt32((Console.ReadLine()));
            bool prov = true;
            for (int i = 0; i < train.Length; i++)
            {
                if (train[i].number == input)
                {
                    train[i].Info();
                    prov = false;
                }
            }
            if (prov)
            {
                Console.WriteLine("Поезд с таким номером не найден");
            }
            Console.ReadKey();
        }
    }
}