using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class A30GenericDelegateAction
    {
        public static void Messege(string m)
        {
            Console.WriteLine(m);
        }
        static void Main()
        {
            Action<string> l = Messege;
             l.Invoke("Hello World");
           
        }

    }
}
