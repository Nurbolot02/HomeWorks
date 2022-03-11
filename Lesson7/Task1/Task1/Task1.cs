using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static FillArrayRandom.FillArrayRandom;
using static PrintArray2D.PrintArray2D;
namespace Task1
{
    internal class Task1
    {
        static void Main(string[] args)
        {
            /* Задача 48: Показать двумерный массив размером m×n
                заполненный целыми числами */
            Console.WriteLine("Показать двумерный массив размером m×n заполненный целыми числами");
            int m = 5, n = 10;
            int[,] array = new int[m, n];
            fillArrayRandom(array);
            printArray2D(array);
            Console.Write("press any key to go to the next task:");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("\nЗадача 50: В двумерном массиве n×k заменить четные элементы на противоположные.");

            /* Задача 50: В двумерном массиве n×k заменить четные
                элементы на противоположные.*/
            printArray2D(array);
            Console.WriteLine();
            Console.WriteLine("Result: ");
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if(array[i, j] % 2 == 0)
                    {
                        array[i, j] *= -1;
                    }
                }
            }
            printArray2D(array);
            Console.WriteLine();
            Console.Write("press any key to go to the next task:");
            Console.ReadKey();
            Console.Clear();

            /* Задача 52: В двумерном массиве заменить элементы, у
            которых оба индекса чётные на их квадраты.*/

            Console.WriteLine("Задача 52: В двумерном массиве заменить элементы, у  которых оба индекса чётные на их квадраты");
            fillArrayRandom(array, m);
            printArray2D(array);
            Console.WriteLine();
            for (int i = 0; i < array.GetLength(0); i++)

            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if(i % 2 == 0 && j % 2 ==0)
                    {
                        array[i, j] *= array[i,j];
                    }
                }
            }
            printArray2D(array);
            Console.WriteLine();
            Console.Write("press any key to go to the next task:");
            Console.ReadKey();
            Console.Clear();

            /* Задача 54: В матрице чисел найти сумму элементов
            главной диагонали. */
            Console.WriteLine("Задача 54: В матрице чисел найти сумму элементов главной диагонали.");
            m = 3;
            n = 2;
            int[,] array2 = new int[m, n];
            fillArrayRandom(array2, m);
            printArray2D(array2);
            Console.WriteLine();
            int sumNumbers = 0;
            for(int i = 0; i < array2.GetLength(0); i++)
            {
                for (int j = 0; j < array2.GetLength(1); j++)
                {
                    if(i == j)
                    {
                        sumNumbers += array2[i, j];
                    }
                }
            }

            Console.WriteLine();
            Console.Write($"Сумма элементов главной диогонали: {sumNumbers} \n");
            Console.Write("press any key to close program:");
            Console.ReadKey();
        }   
    }
}
