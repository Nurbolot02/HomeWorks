using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ArrayMaster.PrintArray;
using static FillArrayRandom.FillArrayRandom;

namespace Task5
{
    internal class Task5
    {
        static void Main(string[] args)
        {
             /* Задача 36: Задать массив, заполнить случайными положительными трёхзначными числами. 
             * Показать количество нечётных/чётных чисел.*/
            Console.WriteLine("\nЗадача 36: Задать массив, заполнить случайными положительными трёхзначными числами. Показать количество нечётных/чётных чисел.");
            int count = 0, count2 = 0;
            int[] array = new int[10];
            array = fillArrayRandom(array, 999);
            printArray(array);



            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0)
                {
                    count++;
                }
                else
                {
                    count2++;
                }
            }
            Console.WriteLine($"\nnumber of odd numbers: {count}");
            Console.WriteLine($"number of even numbers: {count2}\n");
            Console.Write("Press any key for close program:");
            Console.ReadKey();
        }
    }
}
