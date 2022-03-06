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
            /* Задача 19: Определить номер четверти 
            плоскости, в которой находится точка с 
            координатами Х и У, причем X ≠ 0 и Y ≠ 0 */

            System.Console.Write("Enter x coordinates: ");
            int x = Convert.ToInt32(Console.ReadLine());
            System.Console.Write("Enter y coordinates: ");
            int y = Convert.ToInt32(Console.ReadLine());

            if (x > 0 && y > 0)
            {
                System.Console.WriteLine("I-quarter");
            }
            else if (x < 0 && y > 0)
            {
                System.Console.WriteLine("II-quarter");
            }
            else if (x < 0 && y < 0)
            {
                System.Console.WriteLine("III-quarter");
            }
            else if (x > 0 && y < 0)
            {
                System.Console.WriteLine("IV-quarter");
            }
            else
            {
                System.Console.WriteLine("Zero");
            }

        }
    }
}
