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
