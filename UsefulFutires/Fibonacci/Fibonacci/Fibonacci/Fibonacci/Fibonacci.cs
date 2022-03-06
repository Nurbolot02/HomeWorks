using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    public class Fibonacci
    {
        static public int fibonacci(int value)
        {
            if (value == 1 || value == 2)
            {
                return 1;
            }
            else
            {
                return fibonacci(value - 1) + fibonacci(value - 2);
            }
            return value;
        }
    }
}
