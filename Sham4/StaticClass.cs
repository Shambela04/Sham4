using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sham4
{
    public static class Math
    {
        public static string add(string a)
        {
            return a ;

        }
        public static string Sub(string a, string b)
        {
            return a + b;
        }

    }
    class StaticClass
    {
        static void Main()
        {
            string sum = Math.add("Sa want");
            string diff = Math.Sub("sham","Bela");

            Console.WriteLine($"Additoin :{sum}");
            Console.WriteLine($"Join :{diff}");

           
        }
    }
}
