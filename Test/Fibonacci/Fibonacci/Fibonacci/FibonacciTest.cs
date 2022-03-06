using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Fibonacci.Fibonacci;

namespace FibonacciTest
{
    public class FibonacciTest
    {
        static void Main(string[] args)
        {
            for (int i = 1; i < 20; i++)
            {
                Console.WriteLine(fibonacci(i));
                Console.ReadKey();
            }
        }
    }
}
