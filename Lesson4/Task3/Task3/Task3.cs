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
            // Написать программу вычисления произведения чисел от 1 до n
            Console.Write("Enter the number: ");
            int number = int.Parse(Console.ReadLine() ?? string.Empty);
            int result = 1;
            for (int i = 1; i <= number; i++)
            {
                result *= i;
            }
            Console.Write($"{result} ");
        }
    }
}
