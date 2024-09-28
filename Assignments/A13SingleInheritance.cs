using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    public class person
    {
       public int age;
        public String name;

    }
    public class Student : person
    {
        public Student(int age,String name)
        {
            this.age = age;
            this.name = name;
            
        }
        public void Show()
        {
            Console.WriteLine(" The Age : " + age);
            Console.WriteLine("The Name : " + name);
        }

    }
    class A13SingleInheritance
    {
        public static void Main()
        {
            Student id = new Student(111, "Shambela");
            id.Show();
        }
    }
}
