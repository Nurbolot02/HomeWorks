using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ArrayMaster.PrintArray;
using static FillArrayRandom.FillArrayRandom;

namespace Task3
{
    public class Task3
    {
        static void Main(string[] args)
        {
            /* Задача 34: Написать программу для замены элементов массива на противоположные. */
            Console.WriteLine("\nЗадача 34: Написать программу для замены элементов массива на противоположные. ");
            int[] array = new int[10];
            array = fillArrayRandom(array, 999);
            printArray(array);
            for (int i = 0; i < array.Length; i++)
            {
                array[i] *= -1;
            }
            printArray(array);
            Console.Write("Press enter for second task:");
            Console.ReadKey();
            Console.Clear();

            /* Задача 36: Задать массив, заполнить случайными положительными трёхзначными числами. 
             * Показать количество нечётных/чётных чисел.*/
            Console.WriteLine("\nЗадача 36: Задать массив, заполнить случайными положительными трёхзначными числами. Показать количество нечётных/чётных чисел.");
            int count = 0, count2 = 0;
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write((array[i] *= -1) + " ");
                if (array[i] %2 == 0)
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
            Console.Write("Press enter for third task:");
            Console.ReadKey();
            Console.Clear();

            /* Задача 38: Найти сумму чисел одномерного массива, стоящих на нечётной позиции. */

            Console.WriteLine("\nЗадача 38: Найти сумму чисел одномерного массива, стоящих на нечётной позиции.");
            int sumNumbers = 0;
            printArray(array);
            for (int i = 1; i < array.Length; i += 2)
            {
                sumNumbers += array[i];
            }
            Console.WriteLine($"\nthe sum of the numbers of a one-dimensional array in an odd position: {sumNumbers}\n");
            Console.Write("Press enter for four task:");
            Console.ReadKey();
            Console.Clear();

            /* Задача 40: В указанном массиве вещественных чисел найти разницу между максимальным и минимальным элементами. */
            Console.WriteLine("\nЗадача 40: В указанном массиве вещественных чисел найти разницу между максимальным и минимальным элементами.");
            double[] array2 = { 56.7, 12,  0, 1242342345345246, -23456.43, 5.0, 5, -23};
            double diff, minNumber, maxNumber;   
            minNumber = array2[0];
            maxNumber = array2[0];
            for (int i = 1; i < array2.Length; i++)
            {
                if (array2[i] > maxNumber)
                {
                    maxNumber = array2[i];
                }
                else if(array2[i] < minNumber) 
                {
                    minNumber = array2[i];
                }
            }
            printArray(array2);
            Console.WriteLine($"different {maxNumber} and {minNumber} == {maxNumber - minNumber}");
            Console.Write("Press enter for end program:");
            Console.ReadKey();
        }
    }
}
