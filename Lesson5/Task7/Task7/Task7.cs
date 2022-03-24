using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static FillArrayRandom.FillArrayRandom;
using static ArrayMaster.PrintArray;

namespace Task7
{
    internal class Task7
    {
        static void Main(string[] args)
        {
            /* Задача 35: Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99].
                Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
                [5, 18, 123, 6, 2] -> 1
                [1, 2, 3, 6, 2] -> 0
                [10, 11, 12, 13, 14] -> 5 */
            int[] array = new int[123];
            int count = 0;
            array = fillArrayRandom(array);
            printArray(array);

            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i] >= 10 && array[i] <= 99)
                {
                    count++;
                }
            }
            Console.WriteLine($"count numbers of elements from the segment 10-99: {count}");
            Console.Write("Enter key for end program: ");
            Console.ReadKey();

        }
    }
}
