using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    class A28GenericDelegatefunc2
    {
        public static string checknumber(int i)
        {
            if (i < 0)
            {
                return  "Negative Number !!!";
            }
            else if (i > 0)
            {
                return "Positive Number !!!";
            }
            else
            {
                return "Zero";
            }
            
        }

        static void Main()
        {
            Func<int, string> obj1 = checknumber;
            string result = obj1.Invoke(-5);
            Console.WriteLine(result);
        }
    }
}
