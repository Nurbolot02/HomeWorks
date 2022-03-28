using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ArrayMaster.PrintArray;
using static FlipArray.FlipArray;

namespace Task7
{
    internal class Task7
    {
        static void Main(string[] args)
        {
            /* перевернуть массив [1,5,6,8] [8,6,5,1] */
            Console.WriteLine("перевернуть массив [1,5,6,8] [8,6,5,1] ");
            int[] array = { 1, 5, 6, 8 };
            printArray(array);
            array = flipArray(array);
            printArray(array);
            Console.ReadKey();  
        }
    }
}
