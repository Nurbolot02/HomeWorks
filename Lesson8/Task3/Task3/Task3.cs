using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static FillArrayRandom.FillArrayRandom;
using static PrintArray2D.PrintArray2D;
using static IsNumber.IsNumber;
using static IgnoreElement.IgnoreElement;

namespace Task3
{
    internal class Task3
    {
        static void Main(string[] args)
        {
            /* Задача 60: Составить частотный словарь элементов двумерного массива.  */

            Console.WriteLine("Задача 60: Составить частотный словарь элементов двумерного массива. ");
            string rowString = "enter the number of rows in the array: ";
            int row = isNumber(rowString, true);
            string columnsString = "enter the number of columns in the array: ";
            int columns = isNumber(columnsString, true);
            int[,] array = new int[row, columns];
            int minNumber = 10, maxNumber = 30;
            fillArrayRandom(array, minNumber, maxNumber);
            printArray2D(array);
            Console.WriteLine();
            int[,] diction = new int[array.Length, 2];
            int counter = 0;

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (!ignoreElement(diction, array[i, j], counter)) 
                    {
                        diction[counter, 0] = array[i, j];
                        diction[counter, 1] ++;
                        counter++;
                    }
                }
            }
            printArray2D(diction, counter, true);
            Console.Write("enter any key to close program: ");
            Console.ReadKey();  
        }
    }
}
