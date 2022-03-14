using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintArray3D
{
    public class PrintArray3D
    {
        static public void printArray3D(int[,,] array)
        {
            int[] position = new int[2];
            int position2 = 0;
            Console.WriteLine();
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int l = 0; l <= array.GetLength(2); l++)
                {
                    Console.Write(l + "  ");
                }
                position2 = position[0] + 2;
                (position[0], position[1]) = Console.GetCursorPosition();
                Console.WriteLine();
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if(i > 0)
                    {
                        Console.SetCursorPosition(position2, position[1] + j + 1);
                    }
                    if(j >= 9)
                    {
                        Console.Write(j + 1 + " ");
                    }
                    else
                    {
                        Console.Write(j + 1 + "  ");
                    }
                    for(int k = 0; k < array.GetLength(2); k++)
                    {
                        System.Console.Write(array[i, j, k] + " ");
                    }
                    Console.WriteLine();
                    
                }
                Console.SetCursorPosition(position[0] + 2, position[1]);
            }
            Console.SetCursorPosition(0, position[1] + array.GetLength(1) + 1);
            Console.WriteLine();
        }
    }
}
