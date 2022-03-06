using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    internal class Task5
    {
        static void Main(string[] args)
        {
            /* Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
            6 -> да
            7 -> да
            1 -> нет */

            Console.Write("Write day:");
            int day = Convert.ToInt32(Console.ReadLine());

            if (day > 0 && day <= 7)
            {
                if (day < 6)
                {
                    System.Console.WriteLine("No");
                }
                else
                {
                    System.Console.WriteLine("Yes");
                }

            }
            else
            {
                System.Console.WriteLine("There is no such day of the week!");
            }
        }
    }
}
