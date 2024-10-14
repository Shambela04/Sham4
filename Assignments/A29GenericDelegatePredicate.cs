using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    class A29GenericDelegatePredicate
    {
        public static bool CheckLetter(string str)
        {
            if (str.ToUpper().StartsWith('B') || str.ToLower().StartsWith('b') == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static void Main()
        {
            Predicate<string> c = CheckLetter;
            bool result = c.Invoke("Ram");
            Console.WriteLine(result);
        }



    }
    
}
