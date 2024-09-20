using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sham4
{
    internal class Operators
    {
        public static void Main()
        {
            int a = 4;
            int b = 5;
            Console.WriteLine("Arithmetic Operators");
            Console.WriteLine($"a+b { a + b}");
            Console.WriteLine($"b-a {b - a}");
            Console.WriteLine($"a*b {a * b}");
            Console.WriteLine($"a/b {a / b}");
            Console.WriteLine($"a%b {a % b}");


            Console.WriteLine("Relational Operators");
            Console.WriteLine($"a==b {a == b}");
            Console.WriteLine($"a!=b {a != b}");
            Console.WriteLine($" a < b  {a < b}");
            Console.WriteLine($" a > b  {a > b}");
            Console.WriteLine($" a <= b  {a <= b}");
            Console.WriteLine($" a >= b  {a >= b}");

            bool x = true;
            bool y = false;

            Console.WriteLine("Logical Operations");
            Console.WriteLine($"x && y {x && y}");
            Console.WriteLine($"x || y {x || y}");
            Console.WriteLine($"!x {!x}");
            Console.WriteLine($"!y {!y}");


        }
    }
}
