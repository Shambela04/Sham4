using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sham4
{
    internal class ReverseString2
    {

        static void Main(string[] args)
        {
            string s = "Sham";
            string b = "";


            reverseString(s, b);

            static void reverseString(string s, string b)
            {
                for (int i = s.Length - 1; i >= 0; i--) 
                {
                    b = b + s[i];
                }
                Console.WriteLine("reverse :"+b);
            }




            //// second simple code of reverse String

            string c = "Bela";
            for (int i = c.Length - 1; i >= 0; i--)
            {
                Console.Write(c[i]);
            }

        }
    }
}
