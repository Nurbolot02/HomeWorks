using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckPolindrom
{
    static public class CheckPolindrom
    {
        static public void checkPolindrom(int number, int length)
        {
            int result = 0;
            for (int i = 0; i < length; i++)
            {
                if (number.ToString()[i] == number.ToString()[length - i - 1] && number > 0)
                {
                    System.Console.Write((i + 1) + "-number " + number.ToString()[i] + " == " + number.ToString()[length - i - 1] + " " + (length - i) + "-number");
                    System.Console.WriteLine();
                    result++;
                }
                else if (number.ToString()[i+1] == number.ToString()[length - i]&& number < 0)
                {
                    System.Console.Write((i + 1) + "-number " + number.ToString()[i + 1] + " == " + number.ToString()[length - i] + " " + (length - i) + "-number");
                    System.Console.WriteLine();
                    result++;
                }
                else
                {
                    System.Console.WriteLine("False!");
                    break;
                }
            }
            if (result == length)
            {
                System.Console.WriteLine($"{number} is polindrom!");
            }
        }
    }
}
