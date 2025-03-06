using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sham4
{
    class PredcateDelegate
    {
        public static bool word(string s)
        {
            if(s.Length>5)
            {
                return true;
                

            }
            else
            {
                return false;
            }
        }
        static void Main()
        {
            Predicate<string> st = word;
            bool status = st.Invoke("Shambela");
            Console.WriteLine(status);
        }
    }
}
