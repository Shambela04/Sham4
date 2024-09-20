using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class A7enum
    {
        enum Year
        { 
            January,
            February,
            March,
            April,
            May,
            June,
            July,
            Augest,
            September,
            Octomber,
            November,
            December,

        }
        static void Main()
        {
            Year months = Year.January;
            
            switch (months)
            {
                case Year.January:
                    Console.WriteLine("Its January");
                    break;
                case Year.February:
                    Console.WriteLine("Its February");
                    break;
                case Year.March:
                    Console.WriteLine("Its March");
                    break;
                case Year.April:
                    Console.WriteLine("Its April");
                    break;
                case Year.May:
                    Console.WriteLine("Its May");
                    break;
                case Year.June:
                    Console.WriteLine("Its June");
                    break;
                case Year.July:
                    Console.WriteLine("Its July");
                    break;
                case Year.Augest:
                    Console.WriteLine("Its Augest");
                    break;
                case Year.September:
                    Console.WriteLine("Its September");
                    break;
                case Year.Octomber:
                    Console.WriteLine("Its Octomber");
                    break;
                case Year.November:
                    Console.WriteLine("Its November");
                    break;
                case Year.December:
                    Console.WriteLine("Its December");
                    break;


            }
            if ((months == Year.January ) || (months==Year.December))
                
            {
                Console.WriteLine(" Starting Month  of the Year");
                
            }
            else
            {
                Console.WriteLine("Its Other Month");
            }
            
        }
    }
}
