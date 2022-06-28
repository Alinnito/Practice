using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_2
{
    class Model
    {
        public double firstnum;
        public double secondnum;
        public string oper;

        public double Res()
        {
            switch (oper)
            {
                case "+":
                    return firstnum + secondnum;
                case "-":
                    return firstnum - secondnum;
                case "*":
                    return firstnum * secondnum;
                case "/":
                    return Math.Round(firstnum / secondnum, 2);
                default:
                    return 0;
            }
        }

    }
}
