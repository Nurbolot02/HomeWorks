using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorial
{
    public class Factorial
    {
        public static int getFactorial(int number)
        {
            if (number == 0)

            {
                return 1;
            }
            return number * getFactorial(number - 1);
        }
    }
}
