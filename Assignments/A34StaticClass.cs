using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{

    static class Catworld
    {
        public static int NumberOfCats { get; private set; }
        public static int TotalCatNaps { get; private set; }

        static Catworld()
        {
            NumberOfCats = 20;
        }
        public static void AddCat()
        {
            NumberOfCats++;
            Console.WriteLine($"Some cats are joined, Available cats are : {NumberOfCats}");
        }
        public static void AddCatNaps(int naps)
        {
            TotalCatNaps += naps;
            Console.WriteLine($"Added {naps} cat naps, Total cat naps : {TotalCatNaps}");
        }

    }
    internal class A34StaticClass
    {

        public static void Main()
        {
            Catworld.AddCat();
            Catworld.AddCat();

            Catworld.AddCatNaps(5);
            Catworld.AddCatNaps(10);

        }
    }
}
