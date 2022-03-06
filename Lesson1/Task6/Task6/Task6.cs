using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    internal class Task6
    {
        static void Main(string[] args)
        {
            /* Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
            4 -> да
            -3 -> нет
            7 -> нет */
            Console.Write("Enter the number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            if (number % 2 == 0)
            {
                System.Console.WriteLine("True");
            }
            else
            {
                System.Console.WriteLine("False");
            }
        }
    }
}
