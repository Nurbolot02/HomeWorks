using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ArrayMaster.PrintArray;

namespace FirstBlock_Test
{
    internal class FirstBlock_Test
    {
        static void Main(string[] args)
        {
            /* **Задача**: Написать программу, которая из имеющегося массива строк формирует массив из строк, 
             * длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, 
             * либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
             * лучше обойтись исключительно массивами.
             * 
                **Примеры**:

                ["hello", "2", "world", ":-)"] -> ["2", ":-)"]

                ["1234", "1567", "-2", "computer science"] -> ["-2"]

                ["Russia", "Denmark", "Kazan"] -> [] */
            string[] array = {"1234", "1567", "-2", "computer science", "5"};
            string temp  = "";
            int StringLength = 3;
            for (int i = 0; i < array.Length; i++)
            {
                if(array[i].Length <= StringLength)
                {
                     temp = temp + " " + array[i];
                }
            }
            string[] result = temp.Split(' ');
            printArray(result);
        }
    }
}
