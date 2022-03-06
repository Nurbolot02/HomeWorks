using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetNumberLength
{
    static public class GetNumberLength
    {
        static public int getNumberLength(int number)
        {
            int numberLength = 0;

            if (number == 0)
            {
                return 1;
            }
            else if (number > 0)
            {
                while (number > 0)
                {
                    number /= 10;
                    numberLength++;
                }
            }
            else
            {
                number *= (-1);
                while (number > 0)
                {
                    number /= 10;
                    numberLength++;
                }
            }

            return numberLength;
        }
    }
}