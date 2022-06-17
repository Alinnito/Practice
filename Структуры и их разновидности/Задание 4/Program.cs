using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_4
{
    enum Employees
    {
        JUNIOR_DEVELOPER = 100,
        DEVELOPER = 150,
        SENIOR_DEVELOPER = 200,
        TEAM_LEADER = 250,
        PROJECT_MANAGER = 300
    }

    class Accauntant
    {
        public bool AskForBonus(Employees PostWorker, int hours)
        {
            if ((int)PostWorker < hours)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Accauntant acc = new Accauntant();
            Console.WriteLine(acc.AskForBonus(Employees.JUNIOR_DEVELOPER, 40));
            Console.WriteLine(acc.AskForBonus(Employees.DEVELOPER, 200));
            Console.WriteLine(acc.AskForBonus(Employees.SENIOR_DEVELOPER, 50));
            Console.WriteLine(acc.AskForBonus(Employees.TEAM_LEADER, 180));
            Console.WriteLine(acc.AskForBonus(Employees.PROJECT_MANAGER, 340));

            Console.Read();
        }
    }
}
