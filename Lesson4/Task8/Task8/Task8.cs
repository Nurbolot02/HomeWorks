using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static IsNumber.IsNumber;
using static FillArrayRandom.FillArrayRandom;
using static ArrayMaster.PrintArray;


namespace Task8
{
    internal class Task8
    {
        static void Main(string[] args)
        {
            /* Задача 29: Напишите программу, которая задаёт массив из N(-100 100) рандомных элементов и выводит их на экран.
                1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
                6, 1, 33 -> [6, 1, 33] */
            string rowString = "enter the N: ";
            int size = isNumber(rowString, true);
            int[] array = new int[size];   
            fillArrayRandom(array, -100, 100);
            printArray(array);
            Console.Write("Нажмите любую клавишу чтобы завершит работу программы: ");
            Console.ReadKey();
        }
    }
}
