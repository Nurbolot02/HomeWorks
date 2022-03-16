using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static IsNumber.IsNumber;

namespace Task3
{
    internal class Task3
    {
        static public int result = 0;
        static void Main(string[] args)
        {
            /* Задача 70: Напишите программу, которая будет принимать на вход число и
            возвращать сумму его цифр.
            453 -> 12
            45 -> 9 */
            Console.WriteLine("Задача 70: Напишите программу, которая будет принимать на вход число и" +
                "возвращать сумму его цифр." +
                "453 -> 12");
            string columnsString = "Enter the number: ";
            int number = isNumber(columnsString, true);
            int sumNumbers = SumNumbersRecurse(number);
            Console.WriteLine(sumNumbers);
        }

        static int SumNumbersRecurse(int number)
        {
            if(number > 0)
            {
                result +=  number % 10;
                number /= 10;
                SumNumbersRecurse(number);
            }
            return result;
        }
    }
}
