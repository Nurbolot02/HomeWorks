using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    internal class Task3
    {
        static void Main(string[] args)
        {
            /* Задача 72: Заданы 2 массива: info и data. В массиве info хранятся двоичные 
                представления нескольких чисел (без разделителя). В массиве data хранится 
                информация о количестве бит, которые занимают числа из массива info. 
                Напишите программу, которая составит массив десятичных представлений чисел 
                массива data с учётом информации из массива info.
                25 мин
                входные данные:
                - data = {0, 1, 1, 1, 1, 0, 0, 0, 1 }
                - info = {2, 3, 3, 1 }
                выходные данные:
                - 1, 7, 0, 1 */
            int[] info = { 2, 3, 3, 1 };
            int[] data = { 0, 1, 1, 1, 1, 0, 0, 0, 1 };
            int[] result = new int[info.Length];

            for (int i = 0, count = 0; i < info.Length; i++)
            {
                for (int j = 0; j < info[i]; j++)
                {
                    result[i] += data[count + j] * (int)Math.Pow(2, info[i] - j - 1);
                } 
                count += info[i];
                Console.Write(result[i] + " ");
            }


        }
    }
}
