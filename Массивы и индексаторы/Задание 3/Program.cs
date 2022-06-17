using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_3
{
    class Matrix
    {
        private int[] array;

        public Matrix() { }
        public Matrix(int[] a) 
        {
            array = a;
        }

        public void Print()
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
        }

        public void Sort()
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        int x = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = x;
                    }
                }
            }
        }

        static void Main()
        {
            Console.WriteLine("Введите количество элементов массива");
            int count = Convert.ToInt32(Console.ReadLine());
            Random r = new Random();
            int[] Arr = new int[count];
            Console.WriteLine("Исходный массив:");
            for (int i = 0; i < Arr.Length; i++)
            {
                Arr[i] = r.Next(1, 100);
                Console.Write(Arr[i] + " ");
            }
            Console.WriteLine();

            Matrix matrix = new Matrix(Arr);
            Console.WriteLine("Отсортированный массив:");

            matrix.Sort();
            matrix.Print();

            Console.Read();
        }
    }
}