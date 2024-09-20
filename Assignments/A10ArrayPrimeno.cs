using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class A10ArrayPrimeno
    {
        static void Main()
        {
            int[] num = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13 };
            Console.WriteLine("PRIME NUMBERS ARE :");
           
            for (int i = 0; i < num.Length; i++)
            {
                bool isPrime = true;
                if (num[i] <= 1)
                {
                    isPrime = false;
                }
                else
                {
                    for (int j = 2; j<= Math.Sqrt(num[i]); j++)
                    {
                        if (num[i] % j == 0)
                        {
                            isPrime = false;
                            break;

                        }
                        j++;
                    }
                }
                if(isPrime)
                {
                    Console.WriteLine(num[i]);
                }

            }
            
        }
    }    
}






                