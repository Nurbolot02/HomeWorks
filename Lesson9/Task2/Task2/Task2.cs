using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static IsNumber.IsNumber;


namespace Task2
{
    internal class Task2
    {
        static void Main(string[] args)
        {
            /* Задача 68: Задайте значения M и N. Напишите программу, которая
            выведет все натуральные числа в промежутке от M до N.
            M = 1; N = 5 -> "1, 2, 3, 4, 5"
            M = 4; N = 8 -> "4, 6, 7, 8" */
            Console.WriteLine(" Задача 68: Задайте значения M и N. Напишите программу, которая" +
                "выведет все натуральные числа в промежутке от M до N" +
                " M = 1; N = 5 -> 1, 2, 3, 4, 5" +
                "M = 4; N = 8 -> 4, 6, 7, 8");
            string mString = "enter the number m: ";
            int m = isNumber(mString, true);
            string nString = "enter the number n: ";
            int n = isNumber(nString, true);
            PrintMNRecurse(m, n);

            void PrintMNRecurse(int m, int n)
            {
                if(n > m)
                {
                    PrintMNRecurse(m, n - 1);
                }
                Console.Write(n + " ");
            }
        }
    }
}
