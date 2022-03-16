using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static IsNumber.IsNumber;

namespace Task6
{
    internal class Task6
    {
        static void Main(string[] args)
        {
            /* Задача 69: Задайте значения M и N. Напишите программу, которая найдёт сумму элементов в промежутке от M до N.
            M = 1; N = 4 -> 10
            M = 4; N = 8. -> 30 */
            Console.WriteLine("Задача 69: Задайте значения M и N. Напишите программу, которая найдёт сумму элементов в промежутке от M до N." +
                "M = 1; N = 4 -> 10" +
                "M = 4; N = 8. -> 30");
            string rowString = "enter the 1-number: ";
            int m = isNumber(rowString, true);
            string columnsString = "enter the 2-number: ";
            int n = isNumber(columnsString, true);
            int result  = FindSumMtoN(m, n);
            Console.WriteLine($"sum of numbers from {m} to {n} == {result}");
        }

        static int FindSumMtoN(int m, int n)
        {
            if(m != n)
            {
                return m + FindSumMtoN(m + 1, n);
            }
            return m;
        }
    }
}
