using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class NegativeNumberException : Exception
    {
        public NegativeNumberException(string? message) : base(message)
        {

        }
    }


    internal class A23CustomException
    {
        static void Main()
        {
            try
            {
                Console.WriteLine("Enter possitive number");
                int i = Convert.ToInt32(Console.ReadLine());
                if (i < 0)
                {
                    throw new NegativeNumberException("You Are Entered Negative Number ");
                    
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
            catch (NegativeNumberException ex)
            {
                Console.WriteLine(ex.Message);

                Console.WriteLine("Please Enter Positive Number : ");
            }
        }
    }
}
