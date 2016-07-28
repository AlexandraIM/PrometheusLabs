using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Sort();
            Console.ReadKey();
        }

        public static void Sort()
        {
            var a = new[]
            {
              10, 10, 5, 2, 2, 5, 6, 7, 8, 15, 4, 4, 4, 2, 3, 5, 5, 36, 32, 623, 7, 475, 7, 2, 2, 44, 5, 6, 7, 71, 2
            };
            //перебір масиву
            for (int i = 0, l = a.Length; i < l; i++)
            {
                //оголошення змінної для максимального значення
                int maxPos = i;
                for (int j = i+1; j < l; j++)
                {
                    if (a[j] > a[maxPos])
                    {
                        maxPos = j;
                    }  
                }
                Console.Write($"{maxPos} ");
                //переміщення максимального значення
                int temp = a[i];
                a[i] = a[maxPos];
                a[maxPos] = temp;
            }
            Console.WriteLine();
            //виведення зміненого масиву
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write($"{a[i]} ");
            }
        }
    }
}
