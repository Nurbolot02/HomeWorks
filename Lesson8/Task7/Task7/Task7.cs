using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static FillArrayRandom.FillArrayRandom;
using static PrintArray2D.PrintArray2D;
using static PrintArray3D.PrintArray3D;
using static IsNumber.IsNumber;

namespace Task7
{
    internal class Task7
    {
        static void Main(string[] args)
        {
            /* Задача 61: Сформировать трехмерный массив не повторяющимися двузначными
            числами показать его построчно на экран выводя индексы соответствующего
            элемента*/
            Console.WriteLine("Сформировать трехмерный массив не повторяющимися двузначными " +
                "числами показать его построчно на экран выводя индексы соответствующего элемента");
            string threeDString = "enter the number of threeD in the array: ";
            int threeD = isNumber(threeDString, true);
            string rowString = "enter the number of rows in the array: ";
            int row = isNumber(rowString, true);
            string columnsString = "enter the number of columns in the array: ";
            int columns = isNumber(columnsString, true);
            
            int[,,] array = new int[threeD, row, columns];
            fillArrayRandom(array, 10, 100);
            printArray3D(array);
            Console.Write("enter any key to close program: ");
            Console.ReadKey();
        }
    }
}
