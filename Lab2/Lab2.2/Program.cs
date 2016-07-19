///Напишіть програму, яка виведе всі ПАРНІ цілі числа в діапазоні від 2(включно) до 998(включно) у спадному порядку(998 996 ...). 
///Кожне число виведіть в новому рядку.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 999; i > 0; i--)
            {
                if (i%2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadKey();
        }
    }
}
