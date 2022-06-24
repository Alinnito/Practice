using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_4
{
    class Program
    {
        static Dictionary<string, string> dosye = new Dictionary<string, string>();
        static void Put()
        {
            Console.WriteLine("Введите ФИО");
            string name = Console.ReadLine();
            for (int i = 0; i < name.Length; i++)
                name = name.Replace("  ", " ").Trim();

            Console.WriteLine("Введите должность");
            string job = Console.ReadLine();
            for (int i = 0; i < job.Length; i++)
                job = job.Replace("  ", " ").Trim();
            dosye.Add(name, job);
        }

        static void ShowAll()
        {
            IDictionaryEnumerator myEnumerator = dosye.GetEnumerator();
            int k = 1;
            while (myEnumerator.MoveNext())
            {
                Console.WriteLine(k + " - " + Convert.ToString(myEnumerator.Key).Replace(" ", " - ") + " - " + myEnumerator.Value);
                k++;
            }
        }

        static void Delete()
        {
            ShowAll();
            Console.WriteLine("Введите номер досье, которого хотите удалить");
            int nok = Convert.ToInt32(Console.ReadLine());
            IDictionaryEnumerator myEnumerator = dosye.GetEnumerator();
            int k = 1;
            while (myEnumerator.MoveNext() && k != nok)
            {
                k++;
            }
            dosye.Remove(Convert.ToString(myEnumerator.Key));
        }

        static void Search()
        {
            IDictionaryEnumerator myEnumerator = dosye.GetEnumerator();
            Console.WriteLine("Введите фамилию");
            string surname = Console.ReadLine();
            bool prov = true;
            while (myEnumerator.MoveNext())
            {
                string word = Convert.ToString(myEnumerator.Key);
                if (word.Contains(surname))
                {
                    Console.WriteLine(word);
                    prov = false;
                }
            }
            if(prov)
                Console.WriteLine("Человека с такой фамилией нет");
        }
        static void Main(string[] args)
        {
            int res = 0;
            while (res != 5)
            {
                Console.WriteLine("Веберите одно из следующих действий: \n1 - Добавить досье\n2 - Вывести все досье\n3 - Удалить досье\n4 - Поиск по фамилии\n5 - Выход");
                try
                {
                    res = Convert.ToInt32(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Ошибка, такого дйствия нет. Введите цифру от 1 до 5");
                    continue;
                }
                try
                {
                    switch (res)
                    {
                        case 1:
                            Put();
                            break;
                        case 2:
                            ShowAll();
                            break;
                        case 3:
                            Delete();
                            break;
                        case 4:
                            Search();
                            break;
                        case 5:
                            break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Ошибка\n" + ex.Message);
                }
            }
        }
    }
}
