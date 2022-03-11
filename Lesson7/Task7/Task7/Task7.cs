using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static PrintArray2D.PrintArray2D;
using static FillArrayRandom.FillArrayRandom;
using static IsNumber.IsNumber;

namespace Task7
{
    internal class Task7
    {
        static void Main(string[] args)
        {
            /* Задача 53: В двумерном массиве показать позиции числа, заданного пользователем, или указать, что такого элемента нет. */
            Console.WriteLine("Задача 53: В двумерном массиве показать позиции числа, заданного пользователем, или указать, что такого элемента нет.");
            int m = 5, n = 5;
            int[,] array2 = new int[m, n];
            fillArrayRandom(array2);
            printArray2D(array2);
            Console.WriteLine();
            Console.Write("Enter the number: ");
            string num = Console.ReadLine();
            double number = 0;
            while (true)
            {
                if (isNumber(num))
                {
                    number = double.Parse(num);
                    break;
                }
                else
                {
                    Console.Write("Пожалуйста введите корректное число: ");
                    num = Console.ReadLine();
                }
            }
            int counter = 0;
            for (int i = 0; i < array2.GetLength(0); i++)
            {
                for (int j = 0; j < array2.GetLength(1); j++)
                {
                    if (number == array2[i, j])
                    {
                        Console.WriteLine($"в {i}-строке на {j}-позиции найден {array2[i, j]}");
                        counter++;
                    }
                }
            }
            if (counter == 0)
            {
                Console.WriteLine("такого элемента нет!");
            }

            Console.WriteLine();
            Console.Write("press any key to close program:");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
