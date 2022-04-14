using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static IsNumber.IsNumber;

namespace Task1
{
    public class Task1
    {
        static void Main(string[] args)
        {
            /* Задача 70: Напишите программу, которая на вход принимает два числа и выдаёт
            первые N чисел, для которых каждое следующее равно сумме двух предыдущих.
            3 и 4, N = 5 -> 3 4 7 11 18
            6 и 10, N = 4 -> 6 10 16 26 */
            Console.WriteLine("Задача 70: Напишите программу, которая на вход принимает два числа и выдаёт" +
                "первые N чисел, для которых каждое следующее равно сумме двух предыдущих." +
                "3 и 4, N = 5 -> 3 4 7 11 18" +
                "6 и 10, N = 4 -> 6 10 16 26" +
                "");
            string rowString = "enter the 1-number: ";
            int n1 = isNumber(rowString, true);
            string columnsString = "enter the 2-number: ";
            int n2 = isNumber(columnsString, true);
            string str = "enter the n: ";
            int n = isNumber(str, true);


            ShowNumber(n1, n2, n);

        }

        static void ShowNumber( int n1, int n2, int n)
        {
            if(n >= 1)
            {
                Console.Write(n1 + " ");
                ShowNumber(n1, n1 + n2, n - 1);
            }
        }
    }
}
