using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7
{
    internal class Task7
    {
        static void Main(string[] args)
        {
            /* Задача 21: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
            A (3,6,8); B (2,1,-7), -> 15.84
            A (7,-5, 0); B (1,-1,9) -> 11.53 */

            Double x1, x2, y1, y2, c1, c2, distance;
            System.Console.Write("Enter coordinate x1: ");
            x1 = Convert.ToDouble(Console.ReadLine());
            System.Console.Write("Enter coordinate y1: ");
            y1 = Convert.ToDouble(Console.ReadLine());
            System.Console.Write("Enter coordinate c1: ");
            c1 = Convert.ToDouble(Console.ReadLine());
            System.Console.Write("Enter coordinate x2: ");
            x2 = Convert.ToDouble(Console.ReadLine());
            System.Console.Write("Enter coordinate y2: ");
            y2 = Convert.ToDouble(Console.ReadLine());
            System.Console.Write("Enter coordinate c2: ");
            c2 = Convert.ToDouble(Console.ReadLine());


            distance = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(c2 - c1, 2));
            Console.WriteLine($"distance: {Math.Round(distance, 3)}");
        }
    }
}
