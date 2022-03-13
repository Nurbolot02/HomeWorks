using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static SortMinMax.SortMinMax;
using static ArrayMaster.PrintArray;

namespace Task5
{
    internal class Task5
    {
        static void Main(string[] args)
        {
            // Отсортировать массив 
            Console.WriteLine("Отсортировать массив ");
            int[] array = { 9, 5, 4, 10, 7, 2, 54, 1, 0 };
            printArray(array);
            array = sortMinMax(array);
            printArray(array);
            ReadKey();
        }
    }
}
