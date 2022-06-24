using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_1
{
    class Program
    {

        public static void Pull()
        {
            Dictionary<string, string> lst2 = new Dictionary<string, string>();
            lst.Add("Математика", "Наука о структурах, порядке и отношениях, которая исторически сложилась на основе операций подсчёта, измерения и описания форм реальных объектов.");
            lst.Add("Алгебра", "Это часть математики, развивающаяся в связи с задачей о решении алгебраических уравнений.");
            lst.Add("Бином", "Это сумма или разность двух чисел или алгебраических выражений, называемых членами бинома.");
            lst.Add("Биссектриса", "Это прямая, проходящая через вершину угла и делящая его пополам.");
            lst.Add("Вектор", "Это направленный отрезок прямой, у которой один конец называют началом вектора, другой конец – концом вектора.");
            lst.Add("Геометрия", "Часть математики, изучающая пространственные отношения и формы.");
            lst.Add("Гипербола", "Это незамкнутая кривая из двух неограниченно простирающихся ветвей.");
            lst.Add("Гипотенуза", "Сторона прямоугольного треугольника, лежащая против прямого угла.");
            lst.Add("График", "Это график функции – кривая на плоскости, изображаемая зависимость функции от аргумента.");
            lst.Add("Диагональ", "Это отрезок прямой, соединяющий две вершины многоугольника, не лежащие на одной стороне.");
            lst.Add("Дискретность", "Это прерывность; противопоставляется непрерывности.");
            lst.Add("Дискриминант", "Это составленное из величин, определенных заданную функцию, выражение, обращением которого в нуль характеризуется то или иное отклонение функции от нормы.");
            lst.Add("Индекс", "Числовой или буквенный указатель, которым снабжаются математические выражения для того, чтобы отличать их друг от друга.");
            lst.Add("Интервал", "Множество действительных чисел, удовлетворяющее неравенству a < x < b.");
            lst.Add("Катет", "Сторона прямоугольного треугольника, прилежащая к прямому углу.");
            lst.Add("Квадрат", "Прямоугольник, у которого все стороны равны, или, что равносильно, ромб, у которого все углы равны.");
            lst.Add("Константа", "Постоянная величина при рассмотрении математических и др. процессов.");
            lst.Add("Линия", "Один из основных геометрических образов. Представлением о ней может служить нить или образ, описываемый движением точки в плоскости или пространстве.");
            lst.Add("Медиана", "Это отрезок, соединяющий вершину треугольника с серединой противоположной стороны.");
            lst.Add("Минута", "Это единица измерения плоских углов, равная 1/60 градуса.");
        }

        public static Dictionary<string, string> lst = new Dictionary<string, string>();

        public static string Prov(string str)
        {
            int k = 0;
            string near = null;
            int count = str.Length;

            IDictionaryEnumerator myEnumerator = lst.GetEnumerator();

            while (myEnumerator.MoveNext())
            {
                string word = Convert.ToString(myEnumerator.Key);
                if (str.Length != word.Length)
                    continue;

                for (int i = 0; i < str.Length; i++)
                {
                    string a1 = Convert.ToString(str[i]);
                    string a2 = Convert.ToString(word[i]);
                    if (a1.ToLower() == a2.ToLower())
                    {
                        k++;
                    }
                }
                if (count - 1 <= k)
                {
                    near = word;
                }
                k = 0;
            }
                return near;
        }

        static void Main(string[] args)
        {
            Pull();
            Console.WriteLine("Введите слово");
            string text = Console.ReadLine().ToLower().Trim();
            while (text != "0")
            {
                string word;
                string opr;

                if (lst.TryGetValue(text, out opr))
                    Console.WriteLine(opr);
                else
                {
                    word = Prov(text);
                    if (word == null)
                        Console.WriteLine("Такое слово не найдено");
                    else
                    {
                        Console.WriteLine("Найдено слово: \"" + word + "\"");
                        lst.TryGetValue(word, out opr);
                        Console.WriteLine(opr);
                    }
                }
                Console.WriteLine("Для выхода нажмите 0 или введите слово");
                text = Console.ReadLine().ToLower().Trim();
            }
        }
    }
}
