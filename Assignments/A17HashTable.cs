using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    class A17HashTable
    {
        static void Main()
        {
            Hashtable ht = new Hashtable();


            ht.Add(1630, "SQL");
            ht.Add(1674, "Angular");
            ht.Add(1680, "DOT NET");
            ht.Add(1631, 1680);
            ht.Add(1675, true);

            string value1 = (string)ht[1630];

            string value2 = (string)ht[1674];

            string value3 = (string)ht[1680];

            string value4 = Convert.ToString((int)ht[1631]);

            bool value5 = (bool)ht[1675];


            //


            Console.WriteLine($"1630: {value1}");

            Console.WriteLine($"1674 :{value2}");

            Console.WriteLine($"1680 :{value3}");

            Console.WriteLine($"1631 :{value4}");

            Console.WriteLine($"1675 : {value5}");



            //ht.Remove(1630);
            //Console.WriteLine(" After Removal:" );
            //PrintHashtable( Hashtable ht);

            //private static void printht (Hashtable ht)
            //{
            //    foreach (DictionaryEntry entry in ht)
            //    {
            //        Console.WriteLine($" key :{entry.Key},Value:{entry.Value}");
            //    }
            //}


            //ht.Clear();


            //{
            //    return;
            //    ht.Remove(value2);
            //}
              
        }
    }
}
