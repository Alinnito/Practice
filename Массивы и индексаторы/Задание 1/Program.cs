using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_1
{
    class MyMatrix
    {
        private int[,] matrix = null;

        private int columns;
        private int rows;

        public MyMatrix()
        {
        }

        public MyMatrix(int columns, int rows)
        {
            this.columns = columns;
            this.rows = rows;
            matrix = new int[columns, rows];
        }

        public void ChangeMatrix(int columns, int rows)
        {
            int[,] oldMatrix = matrix;
            int mincols = this.columns < columns ? this.columns : columns;
            int minrows = this.rows < rows ? this.rows : rows;

            this.columns = columns;
            this.rows = rows;
            matrix = new int[columns, rows];

            for (int i = 0; i < mincols; i++)
                for (int j = 0; j < minrows; j++)
                    matrix[i, j] = oldMatrix[i, j];
        }

        public void FeedMatrix()
        {
            Random r = new Random();
            for (int i = 0; i < columns; i++)
            {
                for (int j = 0; j < rows; j++)
                {
                    matrix[i, j] = r.Next(1, 100);
                }
            }
        }
        public void Show()
        {
            for (int i = 0; i < columns; i++)
            {
                for (int j = 0; j < rows; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }


    class MainMainov
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Введите количество колонок матрицы");
            int columns = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите количество строк матрицы");
            int rows = Convert.ToInt32(Console.ReadLine());

            MyMatrix matrix = new MyMatrix(columns, rows);

            matrix.FeedMatrix();
            matrix.Show();

            Console.WriteLine("\nВведите количество колонок, на которое хотите изменить матрицу");
            columns = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите количество строк, на которое хотите изменить матрицу");
            rows = Convert.ToInt32(Console.ReadLine());
            matrix.ChangeMatrix(columns, rows);
            Console.WriteLine("Новая матрица:");
            matrix.Show();

            Console.ReadLine();
        }
    }
}