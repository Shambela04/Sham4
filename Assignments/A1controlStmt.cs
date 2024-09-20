using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class A1controlStmt
    {
        static void Main()
        {
            Console.WriteLine("Enter Number");
            int num = int.Parse(Console.ReadLine());

            if (num > 0)
            {
                Console.WriteLine("The number is Positive");
            }
            else if (num < 0)
            {
                Console.WriteLine("The number is Negative");
            }
            else 
            {
                Console.WriteLine("The number is Zero ");
            }

        }
    }
}
