using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static FillArrayRandom.FillArrayRandom;
using static PrintArray2D.PrintArray2D;
using static IsNumber.IsNumber;
namespace Task6
{
    internal class Task6
    {
        static void Main(string[] args)
        {
            /* Задача 59: В прямоугольной матрице найти строку с наименьшей суммой элементов. */
            Console.WriteLine("Задача 59: В прямоугольной матрице найти строку с наименьшей суммой элементов.");
            string rowString = "enter the number of rows in the array: ";
            int row = isNumber(rowString, true);
            string columnsString = "enter the number of columns in the array: ";
            int columns = isNumber(columnsString, true);
            int[,] array = new int[row, columns];
            fillArrayRandom(array, 10, 100);
            printArray2D(array);
            int[] numberSum = new int [array.GetLength(0)];

            for (int i = 0; i < array.GetLength(0); i++) 
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    numberSum[i] += array[i, j];
                }
            }
            int minSum = numberSum[0], minSumIndex = 0;

            for (int i = 1; i < numberSum.Length; i++)
            {
                if(numberSum[i] < minSum)
                {
                    minSum = numberSum[i];
                    minSumIndex = i;
                }
            }
            Console.WriteLine($"строка с наименшей суммой элементов: {minSumIndex} сумма {minSum}");
        }
    }
}
