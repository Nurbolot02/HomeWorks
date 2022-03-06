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
            /* Задача 23: Показать таблицу 
            квадратов чисел от 1 до N */
            System.Console.Write("Enter the number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= number; i++)
            {
                System.Console.Write(i + " " + (i * i));
                System.Console.WriteLine();
            }
        }
    }
}
