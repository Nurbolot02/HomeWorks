using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static GetNumberLength.GetNumberLength;
using static CheckPolindrom.CheckPolindrom;

namespace Task3
{
    internal class Task3
    {
        static void Main(string[] args)
        {
            /* Задача 21: Программа проверяет 
            число на палиндромом.
            Палиндром - слово или фраза (или число в нашем случае), 
            которые одинаково читаются слева направо и справа 
            налево.
            Примеры: 545, 67876, 3443 */

            System.Console.Write("Enter the number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            int length = getNumberLength(number);
            
            checkPolindrom(number, length);
        }
    }
}
