using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ArrayMaster.PrintArray;
using static FillArrayRandom.FillArrayRandom;

namespace Task2
{
    internal class Task2
    {
        static void Main(string[] args)
        {
            //Задача 35: Определить, присутствует ли в заданном массиве, некоторое число 
            int[] array = new int[12];
            int negativeNumber = 0, number = 0;
            array = fillArrayRandom(array, -10, 10);
            printArray(array);
            Console.Write("Enter the number: ");
            number = int.Parse(Console.ReadLine());
            for (int i = 0; i < array.Length; i++)
            {
                if (i == array.Length - 1)
                {
                    Console.WriteLine(false);
                }
                else if (array[i] == number)
                {
                    Console.WriteLine(true);
                    break;
                }
            }
        }
    }
}
