using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class A27GenericDelegateFunc
    {
        public static string Concatenates(string w1, string w2, string w3)
        {
            string str = w1.ToString() + w2.ToString() + w3.ToString();
            return str;
        }
        public static void Main()
        {
            Func<string, string, string, string> obj = Concatenates;
           string result = obj.Invoke("Good", "   ", "Morning");
            Console.WriteLine(result);
        }


        

    
    }
}
