using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class A35RefExample
    {
        public static void IncrementValue(ref int i)
        {
             i++;

        }
        static void Main()
        {
            int I = 34;

            Console.WriteLine($"Before increment : {I}");

            IncrementValue(ref I);
            
            Console.WriteLine($"After increment :{I}");

        }
    }
}
