using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static FillArrayRandom.FillArrayRandom;
using static PrintArray2D.PrintArray2D;
using static IsNumber.IsNumber;

namespace Task4
{
    internal class Task4
    {
        static void Main(string[] args)
        {
            /* Задача 62: В двумерном массиве
            целых чисел. Удалить строку и
            столбец, на пересечении которых
            расположен наименьший элемент. */

            Console.WriteLine("Задача 62: В двумерном массиве  целых чисел.Удалить строку и столбец, " +
                "\nна пересечении которых расположен наименьший элемент.");
            string rowString = "enter the number of rows in the array: ";
            int row = isNumber(rowString, true);
            string columnsString = "enter the number of columns in the array: ";
            int columns = isNumber(columnsString, true);
            int[,] array = new int[row, columns];
            fillArrayRandom(array, 10, 100);
            printArray2D(array);
            int minNumber = array[0,0];
            row = 0;
            columns = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if(array[i,j] < minNumber)
                    {
                        minNumber = array[i,j];
                        row = i;
                        columns = j;
                    }
                }
            }
            Console.WriteLine($"\nminNum: {minNumber} index: {row} {columns}");
            int[,] array2 = new int[array.GetLength(0) - 1, array.GetLength(1) - 1];
            for (int i = 0, count1 = 0; i < array2.GetLength(0) + 1; i++)
            {
                if (i == row) ;
                else
                {
                    for (int j = 0, count2 = 0; j <= array2.GetLength(1); j++)
                    {
                        if (j == columns) ;
                        else
                        {
                            array2[count1, count2] = array[i, j];
                            count2++;
                        }
                    }
                    count1++;
                }
                
            }
            Console.WriteLine();
            printArray2D(array2);
            Console.Write("enter any key to close program: ");
            Console.ReadKey();
        }
    }
}
