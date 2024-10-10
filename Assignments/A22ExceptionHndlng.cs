using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class A22ExceptionHndlng
    {
        public static void Main()
        {
            
            
                try
                {
                    Console.Write("Enter the first number: ");
                    int a = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Enter the Second  number: ");
                    int b = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine($"Addition of Two Numbers = {a + b}");
                    Console.WriteLine($"Substraction of Two Numbers = {a - b}");
                    Console.WriteLine($"Multiplication of Two Numbers = {a + b}");
                    Console.WriteLine($"Divided of Two Numbers = {a / b}");
                }
                catch (DivideByZeroException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch (OverflowException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch (ArithmeticException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch (FormatException ex)
                {
                    Console.WriteLine(ex.Message);
                }

            
        }
    }
}
