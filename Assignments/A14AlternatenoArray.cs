using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    class A14AlternatenoArray
    {
        static void Main()
        {
            Console.WriteLine("Enter The Numbers");
            int size=int.Parse(Console.ReadLine());
            int[] arr = new int[size];

            for (int n=0; n<size;n++)
            {
                arr[n] = int.Parse(Console.ReadLine());
            }
            int Count = 0;
            Console.WriteLine("Alternate Numbers Are :" );

            for (int i=0; i<arr.Length; i = i+2)
            {
                Console.WriteLine(arr[i]+"");
                
            }
            Console.WriteLine("\n");
            int minimum = arr[0];
            int maximum = arr[0];
            for (int j = 0; j < arr.Length; j++)
            {
                Count++;
                if (minimum > arr[j]) ;
                {
                    minimum = arr[j];

                }
                if (maximum < arr[j]) ;
                {
                    maximum = arr[j];
                }
            }
            Console.WriteLine("Total Elements in an Array :" + Count + "\n");
            Console.WriteLine("Small Elements in an Array :" + minimum + "\n");
            Console.WriteLine("Large Elements in an Array :" + maximum );
        }
       

    }
}
