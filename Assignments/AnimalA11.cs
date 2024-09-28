using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    class Animal
    {
        public virtual void Draw()
        {
            Console.WriteLine("Drawing a shape");
        }
    }
    //deriverd clas 1
    class Circle : Animal
    {
        //override draw method
        public override void Draw()
        {
            Console.WriteLine("Driwing a circle");
        }
    }

    //derived class 2

    class Rectangle : Animal

    {
        //override draw method
        public override void Draw()
        {
            Console.WriteLine("Drawing a Rectangle");
        }
    }



    internal class AnimalA11
    {
        static void Main()
        {
            //creating object of different classess

            Animal shape1 = new Animal();
            Animal shape2 = new Circle();
            Animal shape3 = new Rectangle();

            //calling the draw method on each object

            shape1.Draw();
            shape2.Draw();
            shape3.Draw();
        }
    }












}


