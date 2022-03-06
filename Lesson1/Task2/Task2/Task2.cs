using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class Task2
    {
        static void Main(string[] args)
        {
            /* Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
            a = 5; b = 7 -> max = 7
            a = 2 b = 10 -> max = 10
            a = -9 b = -3 -> max = -3  */
            Console.Write("Enter 1-number: ");
            int number1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter 2-number: ");
            int number2 = Convert.ToInt32(Console.ReadLine());

            if (number1 > number2)
            {
                System.Console.WriteLine("max = " + number1);
            }
            else if (number1 == number2)
            {
                System.Console.WriteLine(number1 + " equals (==) " + number2);
            }
            else
            {
                System.Console.WriteLine("max = " + number2);
            }

        }
    }
}
