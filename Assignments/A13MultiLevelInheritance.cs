using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{

    public class person1 //base class
    {
        public int id;
        public string name;
    }
    class Teacher : person1 //child class (person1)
    {
        public string Education;
        
    }
    class Principal : Teacher  //child class (Teacher)
    {
        public Principal(int id, string name, string Education)
        {
            this.id = id;
            this.name = name;
            this.Education = Education;

        }

        public void Show()
        {
            Console.WriteLine(" The Candidate's ID : " + id);
            Console.WriteLine(" The Candidate's Name : " + name);
            Console.WriteLine(" The Candidate's Qualification : " + Education);
        }
        
    }
    internal class A13MultiLevelInheritance
    {
        static void Main()
        {
            Principal info = new Principal(104, "Seeta", "B.ED");
                 info.Show();

        }
    }
}
