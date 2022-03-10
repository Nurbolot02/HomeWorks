using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class Task2
    {
        static void Main(string[] args)
        {
            /* Задача 43: Написать программу преобразования
            десятичного числа в двоичное. */
            Console.WriteLine("Задача 43: Написать программу преобразования десятичного числа в двоичное.");
            Console.Write("Enter the number: ");
            int number = int.Parse(Console.ReadLine()), buffer = number;
            string result ="";
            for (; number > 0;)
            {
                result = number % 2 + result;
                number /= 2;
            }
            Console.WriteLine($"двоичный код {buffer} == {result}");
            Console.WriteLine("Enter key for end program!");
            Console.ReadKey();  
        }
    }
}
