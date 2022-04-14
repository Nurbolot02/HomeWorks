using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static IsNumber.IsNumber;

namespace Task1
{
    internal class Task1
    {
        static void Main(string[] args)
        {
            /* Задача 66: Задайте значение N. Напишите программу, которая выведет
            все натуральные числа в промежутке от 1 до N.
            N = 5 -> "1, 2, 3, 4, 5"
            N = 6 -> "1, 2, 3, 4, 5, 6"
             */
            Console.WriteLine("Задача 66: Задайте значение N. Напишите программу, которая выведет" +
            "все натуральные числа в промежутке от 1 до N." +
            "N = 5-> 1, 2, 3, 4, 5" +
            "N = 6-> 1, 2, 3, 4, 5, 6");
            string rowString = "enter 1- number : ";
            int n = isNumber(rowString, true);
            string rowString2 = "enter 2- number : ";
            int n2 = isNumber(rowString2, true);
            ShowNumberN(n, 2);

        }

        static void ShowNumberN(int min, int max)
        {
            if (max >= min)
            {
                Console.Write(min + " ");
                ShowNumberN(++min, max);
            }
        }
    }
}
