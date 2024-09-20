using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net.Security;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class A6StringBuilder
    {
        static void Main()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("My");
            sb.Append(" Name ");
            sb.Append(" is ");
            sb.Append("Rose");

            string str1 = sb.ToString();
            Console.WriteLine(str1);

            sb.Replace("Rose", "Sara");
            string str2 = sb.ToString();
            Console.WriteLine(str2);

            sb.Remove(0, 2);
            string str3 = sb.ToString();
            Console.WriteLine(str3);

            // find min & max no

                int[] arr = { 50, 30, 80, 10, 40 };


                int min = arr[0];
                int max = arr[0];
                for (int i = 1; i < arr.Length-1; i++)
                {
                    if (arr[i] > min)
                    {
                        min = arr[i];
                    }

                    if (arr[i] < max)
                    {
                        max = arr[i];
                    }
                }
                // search array




                    
                    
                       
                









                



            







        }
    }
}
