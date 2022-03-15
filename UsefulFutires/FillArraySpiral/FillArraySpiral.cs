using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FillArraySpiral
{
    public class FillArraySpiral
    {
        static public int[,] fillArraySpiral(int[,] array)
        {
            array[0, 0] = 1;
            for(int i = 2, x = 0, y = 0; i <= array.Length; )
            {
                while (y + 1 < array.GetLength(0) && array[x, y + 1] == 0) array[x, ++y] = i++;
                while (x + 1 < array.GetLength(0) && array[x + 1, y] == 0) array[++x, y] = i++;
                while (y - 1 > -1 && array[x, y - 1] == 0) array[x, --y] = i++;
                while (x - 1 > -1 && array[x - 1, y] == 0) array[--x, y] = i++;
            }

            return array;
        }
    }
}
