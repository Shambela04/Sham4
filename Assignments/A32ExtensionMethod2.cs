using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    static class A32ExtensionMethod2
    {
       
        public static void Substraction(this A32ExtensionMethod1 s )
        {
            int k = s.i - s.j;
            Console.WriteLine("The Substraction of two Numbers :"+k);
        }

        public static void Multiplication(this A32ExtensionMethod1 s,int i,int j)
        {
            int k = s.i * s.j;
            Console.WriteLine("The Multiplication of two Numbers :"+k);
        }

        public static void Division(this A32ExtensionMethod1 s,int i,int j)
        {
            int k = s.i / s.j;
            Console.WriteLine("The Devision of two numbers :"+k);
        }
    }
}
