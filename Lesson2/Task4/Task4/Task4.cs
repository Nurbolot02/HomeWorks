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
            /* Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
            645 -> 5
            78 -> третьей цифры нет
            32679 -> 6 */

            System.Console.Write("Enter the number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            if (number > 99)
            {
                Console.WriteLine(number.ToString()[2]);
            }
            else if (number < -99)
            {
                Console.WriteLine(number.ToString()[3]);
            }
            else
            {
                System.Console.WriteLine("No third digit");
            }
        }
    }
}
