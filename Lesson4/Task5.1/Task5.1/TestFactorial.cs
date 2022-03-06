using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Factorial.Factorial;

namespace Task5._1
{
    internal class TestFactorial
    {
        static void Main(string[] args)
        {
            int num = 6;
            int result = getFactorial(num);
            Console.WriteLine(result);
        }
    }
}
