﻿//Напишіть програму, що відсортує заданий масив у порядку спадання за допомогою алгоритму сортування вибором.
//Алгоритм сортування вибором працює таким чином: 
//0. "індекс" = 0 
//1. Знаходить у списку найбільше значення таке, що його позиція дорівнює або більша за "index"(справа від елемента на позиції "індекс") 
//2. Міняє його місцями з елементом масиву на позиції "індекс"
//3. Збільшує "індекс" на 1
//4. Повторює три попередніх кроки, доки масив не завершиться
//Завдання:В першому рядку виведіть всі позиції максимального елемента, які Ви отримали на кроці 1. (Використовуйте такий запис для виведення Console.Write($"{maxPos} ");).
//В другому рядку виведіть всі елементи відсортованого масиву. (Використовуйте такий запис для виведення Console.Write($"{a[i]} ");)
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
