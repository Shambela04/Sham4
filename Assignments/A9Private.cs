using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class A9Private
    {
        private string FirstName = "";
        private string LastName = "";
        public void set(string FirstName,string LastName)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;

        }
        public void display()
        {
            Console.WriteLine("Initial Name:" + FirstName);
            Console.WriteLine("Last Name:" + LastName);
            
        }
        public static void Main()
        {
            A9Private obj = new A9Private();
            obj.set("Shambela", "Sawant");
            obj.display();
        }
    }
}
