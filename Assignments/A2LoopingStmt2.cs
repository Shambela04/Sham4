using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Assignments
{
    internal class A2LoopingStmt2
    {
        static void Main()
        {
            
            Console.WriteLine("Food Menu");
            Console.WriteLine("1: Pizza\n2: Pasta\n3: Chicken\n4: Burger\n5: Exit");
            Console.WriteLine("Enter your choice :");
            int item = Convert.ToInt32(Console.ReadLine());
            
            switch(item)
            {
                case 1:
                    Console.WriteLine("your item is Pizza - 100rs");
                    break;
                case 2:
                    Console.WriteLine("your choice is Pasta - 120rs");
                    break;
                case 3:
                    Console.WriteLine("your choice is Chicken - 200rs");
                    break;
                case 4:
                    Console.WriteLine("your choice is Burger -130");
                    break;

                default:Console.WriteLine("Not Available");
                    break;



            }
        }
    }
}
