///У цьому завданні необхідно написати програму, 
///що оголосить дві змінні: перша змінна - змінна цілочисельного(int) типу зі значенням 99,
///друга змінна - змінна дійсного(double) типу зі значенням 0.3525. 
///Перемножте ці дві змінні та результат виконання призначте двом новим змінним: цілочисельного та дійсного типу. 
///Виведіть ці дві останні змінні окремо в новому рядку в такому порядку: 
///цілочисельна змінна, дійсна змінна (кожне значення повинне бути написане в новому рядку без розділових знаків).
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1 = 99;
            double number2 = 0.3525;
            int finalNum1 = (int)(number1 * number2);
            double finalNum2 = number1 * number2;
            WriteLine(finalNum1);
            WriteLine(finalNum2);
            ReadKey();
        }
    }
}
