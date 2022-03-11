using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestRepleceSplitAndMore
{
    internal class Class1
    {
        static void Main(string[] args)
        {
            string text = "(1,2) (3,4) (5,6)"
                .Replace("(","").Replace(")","");
            var data = text.Split(" ")
                .Select(x => x.Split(","))
                .Select(e => (x: int.Parse(e[0]), y: int.Parse(e[1])))
                .Select(num => (num.x * 2, num.y))
                .ToArray();
            for (int i = 0; i < data.Length; i++)
            {
                Console.Write(data[i] + " ");
            }

        }
    }
}
