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
            Console.WriteLine("Задача 66: Задайте значение N. Напишите программу, которая выведет"+
            "все натуральные числа в промежутке от 1 до N."+
            "N = 5-> 1, 2, 3, 4, 5"+
            "N = 6-> 1, 2, 3, 4, 5, 6");
            string rowString = "enter the number  n: ";
            int n = isNumber(rowString, true);
            ShowNumberN(n);

        }

        static void ShowNumberN(int n)
        {
            if(n < 1)
            {
                ShowNumberN(n);
            }
            else if(n > 1)
            {
                ShowNumberN(n - 1);
            }
            Console.Write(n + " ");
        }
    }
}
