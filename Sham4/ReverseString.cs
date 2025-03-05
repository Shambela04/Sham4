using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sham4
{
    public class ReverseString
    {
        static void Main()
        {
            string d = "RAj";
            for (int i = d.Length - 1; i >= 0; i--) 
            {
                Console.Write(d[i]);
            }
            
        }
    }
}
