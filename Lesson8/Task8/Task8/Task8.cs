using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static PrintArray2D.PrintArray2D;
using static IsNumber.IsNumber;
using static FillArraySpiral.FillArraySpiral;

namespace Task8
{
    internal class Task8
    {
        static void Main(string[] args)
        {
            /* Задача 65: Спирально заполнить двумерный массив: */
            Console.WriteLine("Задача 65: Спирально заполнить двумерный массив:");
            string rowString = "enter the number of rows in the array: ";
            int row = isNumber(rowString, true);
            string columnsString = "enter the number of columns in the array: ";
            int columns = isNumber(columnsString, true);
            int[,] array = new int[row, columns];

            fillArraySpiral(array);
            printArray2D(array);
            Console.Write("enter any key to close program: ");
            Console.ReadKey();
        }
    }
}
