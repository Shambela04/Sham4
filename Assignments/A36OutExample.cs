using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class A36OutExample
    {
        public static void Main()
        {
            
            InitializeValue(out int a , out string b);

            Console.WriteLine($"Year : {a}");
            Console.WriteLine($"Organization : {b}");

        }

        static void InitializeValue(out int Value, out string Name)
        {
            Value = 2024;
            Name = "CODEMIND TECHNOLOGY";
        }
    }
}
