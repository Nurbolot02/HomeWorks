using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ArrayMaster.PrintArray;
using static FillArrayRandom.FillArrayRandom;

namespace Task3
{
    public class Task3
    {
        static void Main(string[] args)
        {
            /* Задача 40: В указанном массиве вещественных чисел найти разницу между максимальным и минимальным элементами. */
            Console.WriteLine("\nЗадача 40: В указанном массиве вещественных чисел найти разницу между максимальным и минимальным элементами.");
            double[] array2 = { 56.7, 12,  0, 1242342345345246, -23456.43, 5.0, 5, -23};
            double diff, minNumber, maxNumber;   
            minNumber = array2[0];
            maxNumber = array2[0];
            for (int i = 1; i < array2.Length; i++)
            {
                if (array2[i] > maxNumber)
                {
                    maxNumber = array2[i];
                }
                else if(array2[i] < minNumber) 
                {
                    minNumber = array2[i];
                }
            }
            printArray(array2);
            Console.WriteLine($"different {maxNumber} and {minNumber} == {maxNumber - minNumber}");
            Console.Write("Press enter for end program:");
            Console.ReadKey();
        }
    }
}
