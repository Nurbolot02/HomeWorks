using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    internal class Task5
    {
        static void Main(string[] args)
        {
            /* Задача 42: Определить, сколько чисел больше 0 введено с клавиатуры. */

            Console.Write("Enter numbers separated by spaces: ");
            string numberString = Console.ReadLine();
            string[] numbers = numberString.Split(' ');
            int[] numbersInt = new int[numbers.Length];
            int count = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                numbersInt[i] = int.Parse(numbers[i]);
                if(numbersInt[i] > 0)
                {
                    count++;
                }
            }
            Console.WriteLine($"Количество чисел больше  нуля: {count}");


        }
    }
}
