using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static FillArrayRandom.FillArrayRandom;
using static ArrayMaster.PrintArray;

namespace Task8
{
    internal class Task8
    {
        static void Main(string[] args)
        {
            /*Задача 37: Найдите произведение пар чисел в одномерном массиве. 
             * Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
             * Результат запишите в новом массиве.
                [1 2 3 4 5] -> 5 8 3
                [6 7 3 6] -> 12 10 */
            int flag = 0, flag2 = 1;
            int[] array = new int[5];
            if(array.Length % 2 != 0)
            {
                flag = 1;
                flag2 = 0;
            }
            int[] arrayResult = new int[(array.Length / 2) + flag];
            int count = 0;
            array = fillArrayRandom(array);
            printArray(array);


            for (int i = 0; i <= array.Length / 2 - flag2; i++)
            {
                Console.WriteLine($"product  {i + 1}-number: {array[i]} and {array[array.Length - i - 1]} is {array.Length - i}-number  ==  {array[i] * array[array.Length - i - 1]}");
                arrayResult[i] = array[i] * array[array.Length - i - 1];
            }
            Console.WriteLine();
            printArray(arrayResult);
            Console.Write("Enter key for end program: ");
            Console.ReadKey();
        }
    }
}
