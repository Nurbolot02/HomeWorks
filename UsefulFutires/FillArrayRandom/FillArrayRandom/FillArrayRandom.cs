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

        static public int[,] fillArrayRandom(int[,] array)
        {
            Random random = new Random();
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = random.Next(100);
                }
            }
            return array;
        }

        static public int[,] fillArrayRandom(int[,] array, int value)
        {
            Random random = new Random();
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = random.Next(value);
                }
            }
            return array;
        }

        static public int[,] fillArrayRandom(int[,] array, int minValue, int maxValue)
        {
            Random random = new Random();
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = random.Next(minValue, maxValue);
                }
            }
            return array;
        }

        static public double[,] fillArrayRandom(double[,] array)
        {
            Random random = new Random();
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = random.NextDouble();
                }
            }
            return array;
        }
        static public int[,,] fillArrayRandom(int[,,] array)
        {
            Random random = new Random();
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    for(int k = 0; k < array.GetLength(2); k++)
                    {
                        array[i, j, k] = random.Next(100);
                    }
                }
            }
            return array;
        }

        static public int[,,] fillArrayRandom(int[,,] array, int value)
        {
            Random random = new Random();
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    for (int k = 0; k <= array.GetLength(2); k++)
                    {
                        array[i, j, k] = random.Next(value);
                    }
                }
            }
            return array;
        }

        static public int[,,] fillArrayRandom(int[,,] array, int minValue, int maxValue)
        {
            Random random = new Random();
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    for (int k = 0; k < array.GetLength(2); k++)
                    {
                        array[i, j, k] = random.Next(minValue, maxValue);
                    }
                }
            }
            return array;
        }
    }
}
