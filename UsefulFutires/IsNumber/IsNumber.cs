using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsNumber
{
    public class IsNumber
    {
        static public int isNumber(string str, bool isBool)
        {
            int result = 0;
            while (true)
            {
                Console.Write(str);
                string number = Console.ReadLine();
                bool isNumber = false;
                foreach (char c in number)
                {
                    if (!char.IsDigit(c))
                    {
                        isNumber = false;
                        break;
                    }
                    else
                        isNumber = true;
                }
                if (isNumber)
                {
                    result = int.Parse(number);
                    break;
                }
            }
            return result;
        }

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
