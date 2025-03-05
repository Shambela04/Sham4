using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sham4
{
    class OddEven
    {
       public static void Main()
        {
            Console.WriteLine("Enter The Number");
            int num = Convert.ToInt32(Console.ReadLine());

            if (num % 2 == 0) 
            {
                Console.WriteLine("The Number is Even : " + num);

            }
            else
            {
                Console.WriteLine("The Number is Odd :" + num);
            }

        }
    }
}
