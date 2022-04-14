using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ListMaster;

namespace TestLibrary
{
    internal class TestLibrary
    {
        static void Main(string[] args)
        {
            bool printType = true;
            ArrayMaster createdArray = new ArrayMaster();
            createdArray.SetSize(10);
            createdArray.FillRandom(10, 50);
            createdArray.Print(printType);
            createdArray.SortBuble();
            createdArray.Print(printType);
            Console.WriteLine();

            ArrayMaster2D array2D = new ArrayMaster2D();
            array2D.SetSize(3,4);
            array2D.Print();
            array2D.FillRandom(50, 85);
            array2D.Print();

        }
    }
}
