using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ArrayMaster.PrintArray;
using static FillArrayRandom.FillArrayRandom;

namespace Task6
{
    internal class Task6
    {
        static void Main(string[] args)
        {
            /* Задача 32: Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
                [-4, -8, 8, 2] -> [4, 8, -8, -2]
                Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
                4; массив [6, 7, 19, 345, 3] -> нет
                -3; массив [6, 7, 19, 345, 3] -> да */
            Console.WriteLine("\nЗадача 34: Написать программу для замены элементов массива на противоположные. ");
            int[] array = new int[10];
            array = fillArrayRandom(array,-99, 99);
            printArray(array);
            for (int i = 0; i < array.Length; i++)
            {
                array[i] *= -1;
            }
            printArray(array);
            Console.Write("Press  any key for end program:");
            Console.ReadKey();
        }
    }
}
