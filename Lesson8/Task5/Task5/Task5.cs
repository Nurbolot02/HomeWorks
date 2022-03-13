using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static FillArrayRandom.FillArrayRandom;
using static PrintArray2D.PrintArray2D;
using static IsNumber.IsNumber;
using static SortMinMax.SortMinMax;

namespace Task5
{
    internal class Task5
    {
        static void Main(string[] args)
        {
            /* Задача 57: Написать программу, упорядочивания по убыванию элементы каждой
            строки двумерной массива. */

            Console.WriteLine("\nЗадача 57: Написать программу, упорядочивания по убыванию " +
                "элементы каждой  строки двумерной массива.");
            string rowString = "enter the number of rows in the array: ";
            int row = isNumber(rowString, true);
            string columnsString = "enter the number of columns in the array: ";
            int columns = isNumber(columnsString, true);
            int[,] array = new int[row, columns];
            fillArrayRandom(array, 10, 100);
            printArray2D(array);
            sortMinMax(array);
            Console.WriteLine();
            printArray2D(array);
        }
    }
}
