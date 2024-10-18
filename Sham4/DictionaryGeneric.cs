using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sham4
{
    internal class DictionaryGeneric
    {
        static void Main()
        {
            Dictionary<int, string> dc = new Dictionary<int, string>();

            dc.Add(11,"Sham");
            dc.Add(12, "Bela");
            dc.Add(13, "Sawant");

            Console.WriteLine("Dictionary Elements :");
            foreach (var a in dc)
            {
                Console.WriteLine(a);
            }

        }
    }
}
