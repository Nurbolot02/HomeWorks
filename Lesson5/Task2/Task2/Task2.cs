using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static FillArrayRandom.FillArrayRandom;
using static ArrayMaster.PrintArray;

namespace Task2
{
    internal class Task2
    {
        static void Main(string[] args)
        {
            /* Задача 37: В одномерном массиве из 123 чисел найти
            количество элементов из отрезка [10,99] */
            
            int[] array = new int[41];
            int count = 0;
            array = fillArrayRandom(array);
            printArray(array);

            for (int i = 0; i < array.Length - 1; i++)
            {
                if(array[i] >= 10 && array[i] <= 99)
                {
                    count++;
                }
            }
            Console.WriteLine($"count numbers of elements from the segment 10-99: {count}");
            Console.Write("Enter key for second Task: ");
            Console.ReadKey();


            /* Задача 39: Найти произведение пар чисел в одномерном
            массиве. Парой считаем первый и последний элемент,
            второй и предпоследний и т.д.  */

            for (int i = 0; i <= array.Length / 2; i++)
            {
                Console.WriteLine($"product  {i + 1}-number: {array[i]} and {array[array.Length - i - 1]} is {array.Length - i}-number  ==  {array[i] * array[array.Length - i - 1]}");
            }
            Console.Write("Enter key for end program: ");
            Console.ReadKey(); 

        }
    }
}
