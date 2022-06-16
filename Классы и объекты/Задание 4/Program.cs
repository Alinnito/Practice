using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_4
{
    class Employee
    {
        public string name { get; }
        public string surname { get; }
        public double guardian { get; set; }

        private string post;
        public static List<string> ListPost
        {
            get
            {
                return new List<string> { "Junior Developer", "Developer", "Senior Developer" };
            }
        }

        public Employee(string n, string s)
        {
            name = n;
            surname = s;
        }

        public string Post
        {
            get
            {
                return post;
            }
            set
            {
                post = ListPost[Convert.ToInt32(value) - 1];
            }
        }


        public double salary
        {
            get 
            {
                switch (post)
                {
                    case "Junior Developer":
                        return guardian * 30000;
                    case "Developer":
                        return guardian * 100000;
                    case "Senior Developer":
                        return guardian * 300000;
                    default:
                        return 0;
                }
            }
        }

        public double Tax_collection(double percent)
        {
            return salary * percent / 100;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите имя сотрудника");
            string name = Console.ReadLine();
            Console.WriteLine("Введите фамилию сотрудника");
            string surname = Console.ReadLine();

            Employee emp = new Employee(name, surname);

            Console.WriteLine("Введите цифру, соответствующую должности сотрудника");
            for (int i = 0; i < Employee.ListPost.Count; i++)
                Console.WriteLine(i + 1 + " - " + Employee.ListPost[i]);
            emp.Post = Console.ReadLine();

            Console.WriteLine("Введите стаж сотрудника");
            emp.guardian = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите процент налога");
            double pr = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Фамилия и имя сотрудника: " + emp.surname + " " +  emp.name + "\nДолжность: " + emp.Post + "\nОклад: " + emp.salary + "\nНалоговый сбор: " + emp.Tax_collection(pr));
            Console.Read();
        }
    }
}
