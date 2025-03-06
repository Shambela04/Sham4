using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sham4
{
    // Step 1: Declare a delegate (signature must match the target method)
    public delegate int Show(int a1);
    public delegate string Low(string s);
    class FuncDelegate
    {
        public static int show1(int a1)
        {
            // Step 2: Create a method that matches the delegate signature
            Console.WriteLine(" Display Value: " + a1);

            return a1;
        }
        public static string low1(string s)
        {
            Console.WriteLine("Display String : " + s);
            return s;
        }

        public static void Main()
        {
            // Step 3: Instantiate the delegate

             Show delInstance = new Show(show1);
            
            // Invoke the delegate
            int result = delInstance(2);
           
           Console.WriteLine("Returned Value: " + result);


            Low dele = new Low(low1);
            string results = dele("Shambela");

            Console.WriteLine("Return String :  " + results);



            //Func<int> d = show1;
            //int resu = d.Invoke(6);
            //Console.WriteLine(resu);
            
      
        }
    }

}
