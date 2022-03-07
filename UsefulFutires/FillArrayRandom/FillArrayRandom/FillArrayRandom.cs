using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FillArrayRandom
{
    public class FillArrayRandom
    {
        static public int[] fillArrayRandom(int[] array)
        {
            Random random = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(100);
            }
            return array;
        }

        static public int[] fillArrayRandom(int[] array, int value)
        {
            Random random = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(value);
            }
            return array;
        }

        static public int[] fillArrayRandom(int[] array, int minValue, int maxValue)
        {
            Random random = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(minValue, maxValue);
            }
            return array;
        }
    }
}
