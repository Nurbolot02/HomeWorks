using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static PrintArray2D.PrintArray2D;

namespace Task6
{
    internal class Task6
    {
        static void Main(string[] args)
        {
            /* Задача 51: Задать двумерный массив следующим правилом: Aₘₙ = m+n.*/
            Console.WriteLine("Задача 51: Задать двумерный массив следующим правилом: Aₘₙ = m+n.");
            int m = 5, n = 5;
            int[,] array2 = new int[m, n];
            for (int i = 0; i < array2.GetLength(0); i++)
            {
                for (int j = 0; j < array2.GetLength(1); j++)
                {
                    array2[i, j] = i + j;
                }
            }
            printArray2D(array2);

            Console.WriteLine();
            Console.Write("press any key to close program:");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
