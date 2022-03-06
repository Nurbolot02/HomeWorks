using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static PrintArray2D.PrintArray2D;

namespace FillImage
{
    public class FillImage
    {
        static public int[,] fillImage(int[,] pic, int row, int col)
        {
            if(pic[row, col] == 0)
            {
                pic[row, col] = 1;
                fillImage(pic, row - 1, col);
                fillImage(pic, row, col - 1);
                fillImage(pic, row + 1, col);   
                fillImage(pic, row, col + 1);   
            }
            return pic;
        }
    }
}
