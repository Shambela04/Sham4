using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    class DictionaryGenA20
    {
        static void Main()
        {
            Dictionary<int, string> dict = new Dictionary<int, string>();


            dict.Add(11, "Sunflower");
            dict.Add(12, "Jasmine");
            dict.Add(13, "Rose");
            dict.Add(14, "Lily");
            dict.Add(15, "Orchid");
            dict.Add(16, "Marigold");
            dict.Add(17, "Hibiscus");
            dict.Add(18, "Aster");
            dict.Add(19, "Lotus");
            dict.Add(20, "Cosmos");

            Console.WriteLine("All Elements : ");

            foreach (KeyValuePair<int, string> kvp in dict)
            {
                Console.WriteLine($"No :{kvp.Key} Name :{kvp.Value}" );
            }

            // modify element

            dict[16] = "Apple";
            dict[17] = "Mango";
            dict[18] = "Pineapple";
            dict[19] = "Watermelon";
            dict[20] = "Banana";

            Console.WriteLine("Modified Elements From The Given Data : ");

            foreach (KeyValuePair<int, string> kvp in dict)
            {
                Console.WriteLine($"No :{kvp.Key} Name :{kvp.Value}" );
            }

            // Remove some elements

            dict.Remove(11);
            dict.Remove(12);
            dict.Remove(13);
            dict.Remove(14);
            dict.Remove(15);

            Console.WriteLine("After Removing Elements :: Remaining Elements ");

            foreach (KeyValuePair<int, string> kvp in dict)
            {
                Console.WriteLine($"No :{kvp.Key} Name :{kvp.Value}");
            }

            // filtered Elements

            var filteredElements = dict.Where(kvp => kvp.Value.Contains("Modified"));


            Console.WriteLine("Filtered Elements:");
            foreach (var kvp in filteredElements)
            {
                Console.WriteLine($"No: {kvp.Key}, Name: {kvp.Value}");
            }




        }
    }
}
