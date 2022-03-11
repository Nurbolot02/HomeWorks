using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintArray2D
{
    public class PrintArray2D
    {
        static public void printArray2D(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    System.Console.Write(array[i, j] + " ");
                }
                System.Console.WriteLine();
            }
        }
        static public void printArray2D(int[,] array, int value)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if(array[i, j] == value)
                    {
                        System.Console.Write(" ");
                    }
                    else
                    {
                        System.Console.Write("+");
                    }
                }
                System.Console.WriteLine();
            }
        }

        static public void printArray2D(double[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    System.Console.Write(array[i, j] + "\t");
                }
                System.Console.WriteLine();
            }
        }

    }
}
