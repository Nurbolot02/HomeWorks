using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static PrintArray2D.PrintArray2D;
using static FillArrayRandom.FillArrayRandom;

namespace Task5
{
    internal class Task5
    {
        static void Main(string[] args)
        {
            /* Задача 49: Показать двумерный массив размером m×n, заполненный вещественными числами.*/
            int m = 3, n = 3;
            double[,] array = new double[m, n];
            fillArrayRandom(array);
            printArray2D(array);
            Console.WriteLine();
            Console.Write("press any key to close program:");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
