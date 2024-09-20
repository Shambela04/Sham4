using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class A3GoToStmt
    {
        static void Main()
        {

        
         repeat:
            Console.WriteLine("Enter age between 1 to 120");
            int age = Convert.ToInt32(Console.ReadLine());

            if (age >= 1 && age <= 120)
            {
                Console.WriteLine("age is :" +age);

            }
            else
            {
                Console.WriteLine("Please try again");
                goto repeat;
            }
                

            
            
        }
    }
}