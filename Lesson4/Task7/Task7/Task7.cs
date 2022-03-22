using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static IsNumber.IsNumber;

namespace Task7
{
    internal class Task7
    {
        static void Main(string[] args)
        {
            /* Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
                452 -> 11
                82 -> 10
                9012 -> 12 */
            string numString = "enter the number: ";
            int n = isNumber(numString, true), result = 0;


            while(n > 0)
            {
                result += n % 10;
                n /= 10;
            }

            Console.WriteLine(result);
        }
    }
}
