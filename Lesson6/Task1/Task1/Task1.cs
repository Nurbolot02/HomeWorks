using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Task1
{
    internal class Task1
    {
        static void Main(string[] args)
        {
            /* Задача 41: Выяснить являются ли три числа сторонами
            треугольника.
            Теорема о неравенстве треугольника: каждая сторона треугольника
            меньше суммы двух других сторон.*/
            Console.WriteLine("Задача 41: Выяснить являются ли три числа сторонами треугольника.");
            System.Console.Write("Введите сторону A: ");
            double a = int.Parse(Console.ReadLine());
            System.Console.Write("Введите сторону B: ");
            double b = int.Parse(Console.ReadLine());
            System.Console.Write("Введите сторону C: ");
            double c = int.Parse(Console.ReadLine());
            bool result = IsTriangleSides(a, b, c);   
            Console.WriteLine(result);
            Console.WriteLine("Нажмите любую кнопку чтобы завершить программу! ");
            Console.ReadKey();
        }

        static bool IsTriangleSides (double A, double B, double C)
        {
            return A < C + B && C < A + B && B < A + C;
        }
    }
}
