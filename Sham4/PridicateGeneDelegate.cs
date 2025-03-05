using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sham4
{
    internal class PridicateGeneDelegate
    {
        public static bool Checklength(string str)
        {
            if (str.Length > 5)
                return true;

            return false;
        }
        static void Main()
        {
            Predicate<string> obj = Checklength;
            bool status = obj.Invoke("hel");
            Console.WriteLine(status);
        }
    }
}
