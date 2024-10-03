using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Assignments
{
    class NonGenericStackA19
    {
        static void Main()
        {
            Stack st = new Stack();

            st.Push("hi");
            st.Push(12);
            st.Push(false);
            st.Push(04.5);
            st.Push("S");



            //Print All elements Pushed In Stack

            Console.WriteLine("Data Elements In Stack:-");
            foreach (var n in st)
            {
                Console.WriteLine(n);
            }

            //Remove(POP) Elements From Stack LIFO

            st.Pop();
            st.Pop();
            st.Pop();

            //Aftre Remove Elements From Stack Print The Values

            Console.WriteLine("\n Remaining Element In The Data Stack :- ");
            foreach (var n in st)
            {
                Console.WriteLine(n);
            }


        }
    }
}
