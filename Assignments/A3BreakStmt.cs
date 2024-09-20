using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class A3BreakStmt
    {
        static void Main()
        {
            int sum = 0;
            while (true)
            {
                Console.WriteLine("Enter the Number");
                int value = Convert.ToInt32(Console.ReadLine());

                if (value < 0)
                {
                    break;
                }
                sum += value;
            }
            Console.WriteLine("Addition of all Entered value is :" +sum);
        }
    }
}
