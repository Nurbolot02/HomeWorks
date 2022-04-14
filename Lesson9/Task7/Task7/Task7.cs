using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static IsNumber.IsNumber;

namespace Task7
{
    internal class Task7
    {
        static void Main(string[] args)
        {
            /* Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
                m = 2, n = 3 -> A(m,n) = 29 */
            string mString = "Enter m:";
            long m = isNumber(mString, true);
            string nString = "Enter n:";
            long n = isNumber(nString, true);

            Scanner con = new Scanner(System.in);

            long res;

            while (con.hasNextLong())

            {

                long m = con.nextLong();

                long n = con.nextLong();

                if (m == 0) res = n + 1;
                else

                if (m == 1) res = n + 2;
                else

                if (m == 2) res = 2 * n + 3;
                else

                    res = (1 << (n + 3)) - 3;

                System.out.println(res);

            }

            con.close();


        }
    }
}
