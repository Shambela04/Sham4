using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class A3ContinueStmt
    {
        static void Main()
        {
            int i = 1;
            for (i = 0; i < 20; i++) 
            {
                if (i % 3 == 0)
                {
                    continue;
                }
                Console.WriteLine("Iterations 1 to 20 :"  + i);
            }
        }
    }
}
