using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static FillArrayRandom.FillArrayRandom;
using static IsNumber.IsNumber;

namespace Task9
{
    internal class Task9
    {
        static void Main(string[] args)
        {
            /* Задача 61: Найти произведение двух матриц. */
            Console.WriteLine("Задача 61: Найти произведение двух матриц.");
            string rowString = "enter the number of rows in the array: ";
            int row = isNumber(rowString, true);
            string columnsString = "enter the number of columns in the array: ";
            int columns = isNumber(columnsString, true);
            int[,] array = new int[row, columns];
            int[] colRow = new int[3];

            fillArrayRandom(array, 10, 100);
            printArray2D(array, colRow);
            colRow[2] = colRow[0];  
            Console.SetCursorPosition(colRow[0] + 2,  colRow[1]);

            int[,] array2 = new int[row, columns];
            fillArrayRandom(array2, 10, 100);
            printArray2D(array2, colRow);
            colRow[2] = colRow[0];
            Console.SetCursorPosition(colRow[0] + 2, colRow[1]);

            int[,] array3 = new int[array.GetLength(0), array.GetLength(1)];
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array3[i,j] = array[i,j] * array2[i, j];
                }
            }
            printArray2D(array3, colRow);
        }

        static public void printArray2D(int[,] array, int[] colRow)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    System.Console.Write(array[i, j] + " ");
                }
                if(i == 0)
                {
                    (colRow[0], colRow[1]) = Console.GetCursorPosition();
                }
                if(colRow[2] > 0 && colRow[0] > colRow[2])
                {
                    Console.SetCursorPosition(colRow[2] + 2, colRow[1] + i + 1);
                }
                else
                {
                    Console.WriteLine();
                }
            }
        }
    }
}
