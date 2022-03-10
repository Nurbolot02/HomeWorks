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
            /* Задача 45: Показать числа Фибоначчи
            Числа Фибоначчи - последовательность чисел, каждый член
            которой равен сумме двух предыдущих */

            Console.WriteLine("Задача 45: Показать числа Фибоначчи Числа Фибоначчи - последовательность чисел, " +
                "\nкаждый член которой равен сумме двух предыдущих");
            Console.Write("Enter the number: ");
            int number = int.Parse(Console.ReadLine());
            for (int i = 1; i <= number; i++)
            {
                Console.Write(Fibonacci(i) + " ");
            }
            Console.Write( "\nPress enter for end programm:");
            Console.ReadKey();
        }

        static int Fibonacci(int value)
        {
            if (value == 1 || value == 2)
            {
                return 1;
            }
            else
            {
                return Fibonacci(value - 1) + Fibonacci(value - 2);
            }
            return value;
        }
    }
}
