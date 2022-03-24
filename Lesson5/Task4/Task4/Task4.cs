using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ArrayMaster.PrintArray;
using static FillArrayRandom.FillArrayRandom;

namespace Task4
{
    internal class Task4
    {
        static void Main(string[] args)
        {
            /* Задача 38: Найти сумму чисел одномерного массива, стоящих на нечётной позиции. */

            Console.WriteLine("\nЗадача 38: Найти сумму чисел одномерного массива, стоящих на нечётной позиции.");
            int sumNumbers = 0;
            int[] array = new int[10];
            array = fillArrayRandom(array, 999);
            printArray(array);
            for (int i = 1; i < array.Length; i += 2)
            {
                sumNumbers += array[i];
            }
            Console.WriteLine($"\nthe sum of the numbers of a one-dimensional array in an odd position: {sumNumbers}\n");
            Console.Write("Press any key for close program:");
            Console.ReadKey();
        }
    }
}
