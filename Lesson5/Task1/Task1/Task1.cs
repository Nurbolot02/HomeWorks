using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ArrayMaster.PrintArray;
using static System.Console;
using static FillArrayRandom.FillArrayRandom;

namespace Task1
{
    public class Task1
    {
        static void Main(string[] args)
        {
            /* Задача 33: Задать массив из 12 элементов, заполненных  числами из [0,9]. 
             * Найти сумму положительных/отрицательных элементов массива. */

            int[] array = new int[12];
            int negativeNumber = 0, number = 0;
            array = fillArrayRandom(array, -10, 10);
            printArray(array);
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > 0)
                {
                    number += array[i];
                }
                else
                {
                    negativeNumber += array[i];
                }
            }
            Console.WriteLine($"negative numbers sum: {negativeNumber} \nnumbers sum : {number}");
            
        }
    }
}
