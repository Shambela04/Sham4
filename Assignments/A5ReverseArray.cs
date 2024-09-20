using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class A5ReverseArray
    {
        static void Main(string[] arg)
        {
            string a = "CODEMIND TECHNOLOGY";
            string rev = "";

            reverseString(a, rev);

            static void reverseString(string a, string rev)
            {

                for (int i = a.Length-1; i>=0; i--)
                {
                    rev = rev + a[i];

                }
                Console.Write("Reverse Name :" + rev);
            }


            // odd even numbers

            int[] value = [1, 2, 3, 4, 5, 6, 7, 8, 9];
            foreach (int i in value) 
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(" Even Value is :" +i);
                }
                else 
                {
                    Console.WriteLine(" Odd Value is :" +i);
                }
            }








        }


    }
}
