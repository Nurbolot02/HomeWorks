using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    internal class Task4
    {
        static void Main(string[] args)
        {
            /* Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
            2, 3, 7 -> 7
            44 5 78 -> 78
            22 3 9 -> 22  */
            int[] numbers = { 0, 0, 0 };
            Console.Write("Enter 1-number: ");
            numbers[0] = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter 2-number: ");
            numbers[1] = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter 3-number: ");
            numbers[2] = Convert.ToInt32(Console.ReadLine());
            int max = numbers[0];
            for (int i = 1; i < numbers.Length; i++)
            {
                if (max < numbers[i])
                {
                    max = numbers[i];
                }
            }
            System.Console.WriteLine("max = " + max);
        }
    }
}
