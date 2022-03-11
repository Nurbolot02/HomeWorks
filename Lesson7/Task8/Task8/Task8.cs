using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static PrintArray2D.PrintArray2D;
using static FillArrayRandom.FillArrayRandom;

namespace Task8
{
    internal class Task8
    {
        static void Main(string[] args)
        {
            /* Задача 55: Дан целочисленный массив. Найти среднее арифметическое каждого из столбцов. */
            Console.WriteLine("Задача 55: Дан целочисленный массив. Найти среднее арифметическое каждого из столбцов.");
            int m = 5,  n = 5;
            int[,] array2 = new int[m, n];
            int[] sumColumbArray = new int[array2.GetLength(1)];
            fillArrayRandom(array2);
            printArray2D(array2);

            Console.WriteLine();
            for (int i = 0; i < array2.GetLength(0); i++)
            {
                for (int j = 0; j < array2.GetLength(1); j++)
                {
                    sumColumbArray[j] += array2[i, j];
                }
            }
            Console.WriteLine(" Average:");
            for (int i = 0; i < sumColumbArray.Length; i++)
            {
                sumColumbArray[i] /= 2;
                Console.Write($"{sumColumbArray[i]} ");
            }
            
            Console.Write("\npress any key to close program:");
            Console.ReadKey();
        }
    }
}
