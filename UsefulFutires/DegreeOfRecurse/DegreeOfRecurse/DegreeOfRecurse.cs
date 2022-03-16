using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DegreeOfRecurse
{
    public class DegreeOfRecurse
    {
        /// <summary>
        /// принимает на вход а и б  возводить А в степень Б с помощю рекурсии
        /// </summary>
        /// <param name="a">число</param>
        /// <param name="b">степень</param>
        /// <returns></returns>
        static public int DegreeAToBRecurse(int a, int b)
        {
            if (b == 1)
            {
                return a;
            }
            return a * DegreeAToBRecurse(a, b - 1); ;
        }
    }
}
