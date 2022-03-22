using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exponentiation
{
    public class Exponentiation
    {
        static public int exponentiation(int a, int b)
        {
            if (b == 1)
            {
                return a;
            }
            return a * exponentiation(a, b - 1); ;
        }
    }
}
