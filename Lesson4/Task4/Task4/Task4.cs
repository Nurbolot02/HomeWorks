using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    internal class Task4
    {
        static void Main(string[] args)
        {
            // Задать массив из 8 элементов и вывести их на экран
            int[] numbers = new int[8];
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = new Random().Next(100);
            }
            PrintArray(numbers);

            void PrintArray(int[] numbers)
            {
                for (int i = 0; i < numbers.Length; i++)
                {
                    System.Console.Write(numbers[i] + " ");
                }
            }
        }
    }
}
