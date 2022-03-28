using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlipArray
{
    public class FlipArray
    {
        static public int[] flipArray(int[] array)
        {
            for (int i = 0; i < array.Length / 2; i++)
            {
                array[i] += array[array.Length - 1 - i];
                array[array.Length - 1 - i] -= array[i];
                array[array.Length - 1 - i] *= -1;
                array[i] -= array[array.Length - 1 - i];
            }
            return array;
        }
    }
}
