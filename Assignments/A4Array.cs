using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class A4Array
    {
        static void Main()
        {
            int[] arr = { 1, 2, 3, 4, 5, 6,7,8,9 };

            int sum = 0;
            for (int i = 0; i < arr.Length; i++) 
            {
                sum += arr[i];
            }
            Console.WriteLine("sum is :" + sum);
            Console.WriteLine("Average is :" + sum / arr.Length);
        }


    }  

}
