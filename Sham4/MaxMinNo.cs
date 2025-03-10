using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sham4
{
    class MaxMinNo
    {
        public static void Main()
        {
            int[] no = { 1, 3, 4, 6, 9, 4, 98, };

            int Max = no.Max();
            int Min = no.Min();

            Console.WriteLine(+Max);
            Console.WriteLine(+Min);
        }
    }
}
