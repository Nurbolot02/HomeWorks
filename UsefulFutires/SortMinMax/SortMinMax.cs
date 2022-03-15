using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortMinMax
{
    static public class SortMinMax
    {
        static public int[] sortMinMax(int[] array)
        {
            int minNumber, minNumberIndex,
                maxNumber, maxNumberIndex;

            for (int i = 0; i < array.Length / 2; i++)
            {
                minNumber = array[i];
                minNumberIndex = i;
                maxNumber = array[i];
                maxNumberIndex = i;
                for (int j = 1 + i; j < array.Length - i; j++)
                {
                    if (array[j] < minNumber)
                    {
                        minNumber = array[j];
                        minNumberIndex = j;
                    }
                    else if (array[j] > maxNumber)
                    {
                        maxNumber = array[j];
                        maxNumberIndex = j;
                    }
                }
                if (array[i] > minNumber)
                {
                    array[minNumberIndex] = array[i];
                    array[i] = minNumber;
                }
                if (array[array.Length - i - 1] < maxNumber)
                {
                    array[maxNumberIndex] = array[array.Length - i - 1];
                    array[array.Length - i - 1] = maxNumber;
                }
            }
            return array;
        }

        static public int[,] sortMinMax(int[,] array)
        {
            int buffer, count = 0; ;
            for (int k = 0; k < array.GetLength(0) * array.GetLength(1); k++)
            {
                for (int i = 0; i < array.GetLength(0); i++)
                {
                    for (int j = 0; j < array.GetLength(1) - 1; j++)
                    {
                        if (array[i, j] > array[i, j + 1])
                        {
                            buffer = array[i, j];
                            array[i, j] = array[i, j + 1];
                            array[i, j + 1] = buffer;
                        }
                    }
                }
            }

            return array;
        }
    }
}
