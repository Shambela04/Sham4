using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class A32ExtensionMethod3
    {
        static void Main()
        {
            A32ExtensionMethod1 basicOP = new A32ExtensionMethod1();

            basicOP.Addition();
            basicOP.Substraction();
            basicOP.Multiplication(2,0);
            basicOP.Division(50,5);

            
        }
    }
}
