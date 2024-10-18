using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sham4
{
    internal class HashSetGeneric
    {
        static void Main()
        {
            HashSet <bool> hs= new HashSet<bool>();

            hs.Add(true);
            hs.Add(false);

            Console.WriteLine("Hashset :");
            foreach (var a in hs)
            {
                Console.WriteLine(a);
            }
        }
    }
}
