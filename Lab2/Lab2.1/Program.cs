///Напишіть програму, яка виведе всі цілі числа від 0(включно) до 999(включно). 
///Кожне число виведіть в новому рядку без інших розділових знаків.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 1000; i++)
            {
                Console.WriteLine(i);
                
            }
            Console.ReadKey();
        }
    }
}
