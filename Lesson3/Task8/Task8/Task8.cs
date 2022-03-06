using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task8
{
    internal class Task8
    {
        static void Main(string[] args)
        {
            /* Задача 23: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
            3 -> 1, 4, 9.
            5 -> 1, 8, 27, 64, 125
            3 -> 1, 8, 27
            5 -> 1, 8, 27, 64, 125 */

            System.Console.Write("Enter the number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= number; i++)
            {
                System.Console.Write(i + " ");
            }
            System.Console.WriteLine();
            for (int i = 1; i <= number; i++)
            {
                System.Console.Write((i * i * i) + " ");
            }

        }
    }
}
