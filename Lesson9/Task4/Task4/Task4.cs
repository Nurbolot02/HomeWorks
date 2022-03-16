using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static IsNumber.IsNumber;

namespace Task4
{
    internal class Task4
    {
        static void Main(string[] args)
        {
            /* Задача 72: Напишите программу, которая на вход принимает два числа A и
            B, и возводит число А в целую степень B с помощью рекурсии.
            A = 3; B = 5 -> 243 (3⁵)
            A = 2; B = 3 -> 8 */
            Console.WriteLine("Задача 72: Напишите программу, которая на вход принимает два числа A и" +
                "B, и возводит число А в целую степень B с помощью рекурсии." +
                "A = 3; B = 5 -> 243 (3⁵)" +
                "A = 2; B = 3 -> 8");
            string rowString = "enter the 1-number: ";
            int a = isNumber(rowString, true);
            string columnsString = "enter the 2-number: ";
            int b = isNumber(columnsString, true);

            int result  = DegreeAToBRecurse(a, b);
            Console.WriteLine($"{a} to the {b} power == {result}");

        }

        /// <summary>
        /// принимает на вход а и б  возводить А в степень Б с помощю рекурсии
        /// </summary>
        /// <param name="a">число</param>
        /// <param name="b">степень</param>
        /// <returns></returns>
        static int DegreeAToBRecurse(int a, int b)
        {
            if(b == 1)
            {
                return a;
            }
            return a * DegreeAToBRecurse(a, b - 1); ;
        }
    }
}
