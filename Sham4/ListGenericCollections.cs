using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sham4
{
    internal class ListGenericCollections
    {
        static void Main()
        {
            List<int> list = new List<int>();

            list.Add(10);
            list.Add(20);
            list.Add(30);

            foreach (var a in list)
            {
                Console.WriteLine(a);
            }

        }
    }
}
