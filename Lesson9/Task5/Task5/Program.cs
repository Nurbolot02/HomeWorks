using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static IsNumber.IsNumber;

namespace Task5
{
    internal class Task5
    {
        static void Main(string[] args)
        {
            /* Задача 67: Показать натуральные числа от N до 1, N задано. N = 5. -> "5, 4, 3, 2, 1"*/
            string rowString = "enter the 1-number: ";
            int n = isNumber(rowString, true);

            ShowNumberNto1(n);
        }
        static void ShowNumberNto1(int n)
        {
            if (n >= 1)
            {
                Console.Write(n + " ");
                ShowNumberNto1(n - 1);
            }
            else if (n < 0)
            {
                Console.Write(n + " ");
            }
        }
    }
}
