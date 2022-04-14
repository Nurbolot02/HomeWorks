using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace ListMaster
{
    public class ArrayMaster
    {
        int[] array = new int[0];
        int count = 0;

        public void SetSize(int size)
        {
            Array.Resize(ref array, size);
        }
        public void Add(int item)
        {
            Array.Resize(ref array, count + 1);
            array[count++] = item;
        }
        public int GetValue(int index)
        {
            return array[index];
        }
        public void Print(bool flag = false)
        {
            int arrayLength = array.Length;
            if (flag)
            {
                for (int i = 0; i < arrayLength; i++)
                {
                    Console.Write(array[i] + " ");
                }
                Console.WriteLine();
            }
            else
            {
                for (int i = 0; i < arrayLength; i++)
                {
                    Console.WriteLine(array[i]);
                }
                Console.WriteLine();
            }
            
        }
        public void FillRandom(int minNumber = 0, int maxNumber = 10)
        {
            for(int i = 0; i < array.Length; i++)
            {
                array[i] = new Random().Next(minNumber, maxNumber);
            }
        }

        public void SortBuble()
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
        }
    }
    public class ArrayMaster2D
    {
        int [,] array;

        public void SetSize(int sizeRow = 5, int sizeCol = 5)
        {
            array = new int[sizeRow, sizeCol];
        }
        public void Print()
        {
            int rowLength = array.GetLength(0);
            int colLength = array.GetLength(1); 
            for (int i = 0; i < rowLength; i++)
            {
                for (int j = 0; j < colLength; j++)
                {
                    Console.Write(array[i,j] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
        public void FillRandom(int minValue = 0, int maxValue = 10)
        {
            int rowLength = array.GetLength(0);
            int colLength = array.GetLength(1);
            for (int i = 0; i < rowLength; i++)
            {
                for (int j = 0; j < colLength; j++)
                {
                    array[i,j] = new Random().Next(minValue, maxValue);
                }
            }
        }
        public int Length()
        {
            return array.Length;
        }

        public void FillSpiral()
        {
            array[0, 0] = 1;
            int rowLength = array.GetLength(0);
            for (int i = 2, x = 0, y = 0; i <= array.Length;)
            {
                while (y + 1 < rowLength && array[x, y + 1] == 0) array[x, ++y] = i++;
                while (x + 1 < rowLength && array[x + 1, y] == 0) array[++x, y] = i++;
                while (y - 1 > -1 && array[x, y - 1] == 0) array[x, --y] = i++;
                while (x - 1 > -1 && array[x - 1, y] == 0) array[--x, y] = i++;
            }
        }
    }
}
