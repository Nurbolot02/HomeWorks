using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IgnoreElement
{
    public class IgnoreElement
    {
        static public bool ignoreElement(int[,] array, int element, int counter)
        {
            bool result = false;
            for (int i = 0; i < counter; i++)
            {
                if (array[i, 0] == element)
                {
                    array[i, 1] += 1;
                    return true;
                }
            }
            return result;
        }
    }
}
