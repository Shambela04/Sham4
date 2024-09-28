using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    public class shape  //base class or parent class
    {
        public string colour;
        public void DisplayDetails()
        {
            Console.WriteLine(colour);
        }

    }
    class circle : shape
    {
        public circle(string colour)
        {
            this.colour = colour;
        }
       
    }
    class rectangle2 : shape
    {
        public  rectangle2(string colour)
        {
            this.colour = colour;
        }
        
    }
    internal class A13HierarchicalInheritance
    {
        static void Main()
        {
            circle shapetype = new circle("Black" );
            Console.WriteLine("Circle Colour :");
            shapetype.DisplayDetails();
            rectangle2 shapetype1 = new rectangle2("White");
            Console.WriteLine("Rectangle Colour:");
            shapetype1.DisplayDetails();
            
            


        }
    }
}
