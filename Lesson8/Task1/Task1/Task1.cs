using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static PrintArray2D.PrintArray2D;
using static FillArrayRandom.FillArrayRandom;

namespace Task1
{
    internal class Task1
    {
        static void Main(string[] args)
        {
            /* Задача 56: Написать программу, которая обменивает
        элементы первой строки и последней строки */
            int sizeArray = 5;
            int[,] array = new int[sizeArray, sizeArray];
            fillArrayRandom(array);
            printArray2D(array);
            Console.WriteLine();
            int buffer = 0;
            for (int i = 0; i < sizeArray; i++)
            {
                buffer = array[array.GetLength(0) - 1, i];
                array[array.GetLength(0) - 1, i] = array[0, i];
                array[0, i] = buffer;
            }
            printArray2D(array);
            Console.Write("enter any key to close program:");
            Console.ReadKey();
            Console.Clear();

            /* Задача 56_1: Написать программу, которая обменивает
            элементы первой строки и последней строки без дополнительной переменной */
            /*  a += b; //a = 18, b = 7
                b -= a; // b = 7 - 18 = -11 a = 18
                b =- b; // b = 11, a = 18
                a -= b; // a = 7, b = 11
            */
            Console.WriteLine("Задача 56_1: Написать программу, которая обменивает " +
                "элементы первой строки и последней строки без дополнительной переменной");
            fillArrayRandom(array);
            printArray2D(array);
            Console.WriteLine();
            for (int i = 0; i < sizeArray; i++)
            {
                array[0, i] += array[array.GetLength(0) - 1, i];
                array[array.GetLength(0) - 1, i] -= array[0, i];
                array[array.GetLength(0) - 1, i] = -array[array.GetLength(0) - 1, i];
                array[0, i] -= array[array.GetLength(0) - 1, i];
            }
            printArray2D(array);
            Console.Write("enter any key to close program:");
            Console.ReadKey();
        }
    }
}
