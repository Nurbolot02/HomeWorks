using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static IsNumber.IsNumber;
using static Exponentiation.Exponentiation;

namespace Task6
{
    internal class Task6
    {
        static void Main(string[] args)
        {
            /* Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
                3, 5 -> 243 (3⁵)
                2, 4 -> 16 */
            Console.WriteLine("Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B." +
                "\n3, 5-> 243(3⁵)" +
                "\n2, 4-> 16");

            string aStr = "enter number a: ";
            int a  = isNumber(aStr, true);
            string bStr = "enter number b: ";
            int b = isNumber(bStr, true);
            int result = a;
            for (int i = 1; i < b; i++)
            {
                result *= a; 
            }
            Console.WriteLine($"{a} to the {b} power == {result}");
            Console.Write("Нажмите любую клавишу чтобы перейти к решения при помоши рекурсии: ");
            Console.ReadKey();
            Console.Clear();

            a = isNumber(aStr, true);
            b = isNumber(bStr, true);
            result = exponentiation(a, b);
            Console.WriteLine($"{a} to the {b} power == {result}");
        }


    }
}
