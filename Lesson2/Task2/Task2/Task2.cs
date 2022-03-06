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
            /* 12. Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. Если число 2 не кратно числу 1, то программа выводит остаток от деление.
            34, 5 -> не кратно, остаток 4 
            16, 4 -> кратно */

            System.Console.Write("Enter 1-number: ");
            int number1 = Convert.ToInt32(Console.ReadLine());
            System.Console.Write("Enter 2-number: ");
            int number2 = Convert.ToInt32(Console.ReadLine());
            checkMultiplicity(number1, number2);

            void checkMultiplicity(int number1, int number2)
            {
                if (number1 % number2 == 0)
                {
                    System.Console.WriteLine("Multiplicity");
                }
                else
                {
                    System.Console.WriteLine($"Not multiple, reminder {number1 % number2}");
                }
            }

        }
    }
}
