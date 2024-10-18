using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Sham4
{
    internal class NonGenericStack
    {
        static void Main()
        {
            Stack st = new Stack();

            st.Push("Hi");
            st.Push(04.5);
            st.Push(true);

            Console.WriteLine("Stack Elements:");
            foreach (var n in st)
            {
                Console.WriteLine(n);
            }
        }

    }
}
