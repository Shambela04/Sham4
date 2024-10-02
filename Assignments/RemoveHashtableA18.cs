using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    class RemoveHashtableA18
    {
        static void Main()
        {
            // Create a Hashtable
            Hashtable hashTable = new Hashtable();

            //  elements

            hashTable.Add("Apple", 5);
            hashTable.Add("Banana", 10);
            hashTable.Add("Cherry", 15);
            hashTable.Add("Mango", 20);
            hashTable.Add("Pineapple", 50);

            Console.WriteLine("THe Elements Data:");
            PrintHashTable(hashTable);

            // Remove an element

            hashTable.Remove("Banana");
            hashTable.Remove("Apple");
            hashTable.Remove("Pineapple");

            Console.WriteLine("After Remove Some Data :");
            PrintHashTable(hashTable);

            
        }

        static void PrintHashTable(Hashtable hashTable)
        {
            foreach (DictionaryEntry entry in hashTable)
            {
                Console.WriteLine($" Element : {entry.Key}, Value: {entry.Value}");
            }
        }
    }
}






