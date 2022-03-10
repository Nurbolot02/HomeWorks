using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ArrayMaster.PrintArray;
using static CopyArray.CopyArray;

namespace Task4
{
    internal class Task4
    {
        static void Main(string[] args)
        {
            /* Задача 47: Написать программу копирования массива */

            int[] numbers = { 1, 2, 3, 9, 0 };
            int[] copyNumbers = copyArray(numbers);
            printArray(copyNumbers);
        }
    }
}
