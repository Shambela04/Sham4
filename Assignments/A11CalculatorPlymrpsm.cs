using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    class Calculator
    {
        public int Add(int a, int b)
        {
            return a + b;
        }

        public double Multiplication(double a, double b)
        {
            return a * b;
        }

        public double Substraction(double a, double b)
        {
            return a - b;
        }

        public int Divide(int a, int b)
        {
            return a / b;
        }


    }



    class A11CalculatorPlymrpsm
    {
        static void Main()
        {
            Calculator cal = new Calculator();

            int sum = cal.Add(5, 5);
            double mul = cal.Multiplication(1.2, 1.2);
            double sub = cal.Substraction(5.8, 3.2);
            int div = cal.Divide(10, 3);

            Console.WriteLine("The Addition :" + sum);
            Console.WriteLine("The Multiplication :" + mul);
            Console.WriteLine("The Substraction :" + sub);
            Console.WriteLine("The Division:" + div);


        }


    }
}
