using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    public abstract class Shape
    {

        public abstract double calculateArea(double a, double b);
        

        public void show()
        {
            Console.WriteLine("Shape Types");
        }

       

    }
    public class Rectangle1 : Shape
    {
        public override double calculateArea(double a, double b)
        {
            return a * b;
         
        }
    }
    public class Circle1: Shape
    {
        public override double  calculateArea(double a,double b)
        {
            return Math.PI * Math.Pow(a, 2);
        }

    }
    
    internal class A12Abstract
    {
        static void Main()
        {
            Rectangle1 obj1 = new Rectangle1();
            Circle1 obj2 = new Circle1();

            double rect = obj1.calculateArea(10.2, 10.1);
            double cir = obj2.calculateArea(10, 1);
            
            Console.WriteLine("Area of Rectangle:" + rect);
            Console.WriteLine("Area of Circle:" + cir);

            
        }
    }
}
