using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    public class Person
    {
        protected int Id;
        protected string Name;
        protected string Add;

    }
    public class Employee : Person
    {
        public Employee(int Id, string Name, string Add)
        {
            this.Id = Id;
            this.Name = Name;
            this.Add = Add;

        }
        public void display()
        {
            Console.WriteLine("Employee Id :" + Id );
            Console.WriteLine("Employee Name :" + Name );
            Console.WriteLine("Employee Add :" + Add );
        }
        

    }
    internal class AccessModifier
    {
        static void Main(String[] arg)
        {
            Employee e = new Employee(111,"Shambela","india");
            e.display();
            
            

            
            
        }
        
    }
}
