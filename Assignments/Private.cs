using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    class PrivateClass
    {
        private int Privatefeild;
        public void setfeild(int value)
        {
            Privatefeild = value;
        }
        public void show()
        {
            Console.WriteLine("Private field value" + Privatefeild);
        }
    }
    class Private
    {
        static void Main()
        {
            PrivateClass obj = new PrivateClass();
            obj.setfeild(5);
            obj.show();
        }
    }
}
