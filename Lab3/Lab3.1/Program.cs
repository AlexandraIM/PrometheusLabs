using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3._1
{
    class Program
    {
        static void Main(string[] args)
        {
            MultiplyMatrix();
            Console.ReadKey();

        }
        public static void MultiplyMatrix()
        {
            var a = new[,]
            {
                {5, 10, 13, -4, 10},
                {20, 2, 9, 9, -1},
                {5, 10, 4, 8, 14},
                {6, 1, 2, 6, 10},
                {95, 5, 10, 10, 2}
            };
            var b = new[,]
            {
              {5, 10, 8, -4, 62},
              {20, 2, 9, 9, -1},
              {5, 10, 1, 8, 1},
              {6, 1, 2, 6, -5},
              {95, 5, 1, 3, 2}
            };
            // призначаємо нову матрицю в якій буде результат
            int[,] c = new int[a.GetLength(a.Rank-1), a.GetLength(a.Rank - 1)];
            
            //визначаємо довжину рядка
            int length = 0;
            if (c.Rank > 1)
            {
                length = c.GetLength(c.Rank - 1);
            }
           //вираховуємо значення комірки
            for (int row = 0; row < length; row++)
            {
                for (int col = 0; col < length; col++)
                {
                    c[row, col] = 0;
                    for (int k = 0; k < length; k++)
                    {
                        c[row, col] += a[row, k] * b[k, col];
                    }
                } 
            }
            //відображення значення комірки
            for (int row = 0; row < length; row++)
            {
                for (int col = 0; col < length; col++)
                {
                    Console.Write($"|{c[row, col]}");
                    if (col == length - 1)
                    {
                        Console.Write("|");
                    }
                }
                Console.WriteLine();
            } 
        }
    }
}
