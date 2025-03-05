using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sham4
{
    using System;

    // Sealed class cannot be inherited
    sealed class BaseClass
    {
        // Addition Method
        public int Add(int a, int b)
        {
            return a + b;
        }
    }
      
    //******* we cannot inherite from the sealed class******
    
    //public class secondMethod:BaseClass;
    // {
    //       // return a + b;
    // }

class SealedClass
    {
        static void Main()
        {
            // Create an instance of the sealed class
            BaseClass slc = new BaseClass();

            // Call the Add method
            Console.WriteLine($"Addition: {slc.Add(2, 3)}");
        }
    }


}

