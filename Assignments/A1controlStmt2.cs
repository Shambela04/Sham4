using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class A1controlStmt2
    {
        public static void Main()
        {
            Console.WriteLine("Enter the marks 0 to 100");
            int grade = int.Parse(Console.ReadLine());

            if (grade >= 75)
            {
                Console.WriteLine("Grade is A");
            }
            else if (grade >= 60)
            {
                Console.WriteLine("Grade is B");
            }
            else if (grade >= 50)
            {
                Console.WriteLine("Grade is C");
            }
            else if (grade >= 40)
            {
                Console.WriteLine("Grade is D");
            }
            else if (grade >= 35)
            {
                Console.WriteLine("Grade is E");
            }
            else
            {
                Console.WriteLine("Fail");
            }
        }
    }
}
