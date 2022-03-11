using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsNumber
{
    public class IsNumber
    {
        static public bool isNumber(string stringNumber)
        {
            if (stringNumber == null || stringNumber == "") { return false; }
            bool isNumber = true;
            foreach (char c in stringNumber)
            {
                if (!char.IsDigit(c)) 
                {
                    isNumber = false;
                    break; 
                }
                else
                    isNumber = true;
            }
            return isNumber;
        }
    }
}
