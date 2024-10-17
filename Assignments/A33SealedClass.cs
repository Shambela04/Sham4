using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{

    class Baseclass
    {
        public void display()
        {
            Console.WriteLine("This is Base class");
        }
    }
    sealed class DerivedClass : Baseclass
    {
        public void show()
        {
            Console.WriteLine("This is derived class : with Sealed class ");
        }
    }
    class A33SealedClass
    {
        
        static void Main()
        {
            DerivedClass sc = new DerivedClass();
            sc.display();
            sc.show();
        }
    }
}

