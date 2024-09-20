using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class A2LoopingStmt
    {
        static void Main()
        {
            int j = 1;
            Console.WriteLine("While Loop");
            while (10 >= j) 
            {
                Console.WriteLine(j++);             
            }

            Console.WriteLine("Do While Loop");
            int num = 1;
            do
            {
                Console.WriteLine(num);
                num++;
            }
            while (num <= 10);

            Console.WriteLine("For Loop");
            for (j = 1; j <= 10; j++) 
            {
                Console.WriteLine(j);
            }
        }
    }
}
