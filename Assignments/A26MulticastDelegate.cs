using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    public delegate void BasicOperations();

    public class MultiDelegate
    {
        
        public void Add1(int a,int b)
        {
            
            Console.WriteLine($"Addition of Two Numbers : {a+b}");
        }

        public  void Sub(int c,int d)
        {
            Console.WriteLine($"Substraction of Two Numbers : {c-d} ");
        }

        public void Mult(int m,int n)
        {
            Console.WriteLine($"Multiplication of Two Numbers : {m*n}");
        }


    }

    internal class A26MulticastDelegate
    {
        public static void Main()
        {
            MultiDelegate Md = new MultiDelegate();

            

            Md.Add1(10, 10);
            Md.Sub(50, 10);
            Md.Mult(6, 3);

            Console.ReadKey();

        }
    }
}
