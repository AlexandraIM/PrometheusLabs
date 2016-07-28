///Напишіть програму, яка виведе всі цілі числа в діапазоні від 0(включно) до 999(включно) сума цифр яких дорівнює 15 
///(наприклад, 717 має бути виведене, адже 7 + 1 + 7 = 15, 556 - ні, бо 5 + 5 + 6 = 16) у порядку зростання(69 78 87 96 159 ...). 
///Кожне число виведіть в новому рядку.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2._3
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 1000; i++)
            {
                //якщо число більше або дорівнює 100
                if (i >= 100)
                {
                    int hundr = i / 100; //відібрати соті
                    int dec = (i - hundr * 100) / 10;// відібрати десяті
                    int num = (i - hundr * 100) % 10;// залишок
                    if (hundr + dec + num == 15)
                    {
                        Console.WriteLine(i);
                    }
                }
                //якщо число більше 10 але меньше 100
                if(i >= 10 && i < 100)
                {
                    if ((i / 10) + (i % 10) == 15)
                    {
                        Console.WriteLine(i);
                    }
                }
            }
            
            
            Console.ReadKey();
        }
    }
}
