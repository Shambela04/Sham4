using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    public delegate void Add(int a, int b);
    public delegate void Sub(int i, int j);

    public class Delegate
    {
        public void Addition(int a, int b)
        {
            Console.WriteLine(a + b);

        }

        public void Substraction(int i, int j)
        {
            Console.WriteLine(i - j);
            
        }

    }

    internal class A25SinglecastDelegate
    {
        static void Main()
        {
            Delegate dg = new Delegate();
            Add ad = new Add(dg.Addition);
            Console.WriteLine("The Adiition is :");
            ad(10,20);
            

            Delegate Dg = new Delegate();
            Sub sb = new Sub(Dg.Substraction);
            Console.WriteLine("The Substraction is :");
            sb(20, 20);

        }
    }
}
