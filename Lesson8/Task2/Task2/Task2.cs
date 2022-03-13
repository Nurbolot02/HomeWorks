using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static FillArrayRandom.FillArrayRandom;
using static PrintArray2D.PrintArray2D;
using static IsNumber.IsNumber;

namespace Task2
{
    internal class Task2
    {
        static void Main(string[] args)
        {
            /* Задача 58: Написать программу, которая в двумерном
            массиве заменяет строки на столбцы или сообщить, что это
            невозможно (в случае, если матрица не квадратная). */

            Console.WriteLine("Задача 58: Написать программу, которая в двумерном\n" +
            "массиве заменяет строки на столбцы или сообщить, что это\n" + 
            "невозможно(в случае, если матрица не квадратная).");
            string rowString = "enter the number of rows in the array: ";
            int row = isNumber(rowString, true);
            string columnsString = "enter the number of columns in the array: ";
            int columns = isNumber(columnsString, true);
            int[,] array = new int[row, columns];
            fillArrayRandom(array, 10, 100);
            printArray2D(array);

            if(row != columns)
            {
                Console.WriteLine("матрица не квадратная!");
            }
            else
            {
                Console.WriteLine();
                int buffer = 0;
                for (int i = 0; i < array.GetLength(0); i++)
                {
                    for (int j = i + 1; j < array.GetLength(1); j++)
                    {
                        buffer = array[j, i];
                        array[j, i] = array[i, j];
                        array[i, j] = buffer;
                    }
                }
                printArray2D(array);
            }
            Console.Write("press any key to close program: ");
            Console.ReadKey();
        }
    }
}
