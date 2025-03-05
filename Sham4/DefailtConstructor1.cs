using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sham4
{
    public class DefaultConstructorExample
    {

        public int value;
        //default constructor 
        public DefaultConstructorExample()
        {
            value = 0;
        }
        //create another metod that we need to call

        //public void Test()
        //{
        //    Console.WriteLine("Test" + value);
        //}

    }

    internal class DefaultConstructor1
    {
        static void Main()
        {
            DefaultConstructorExample obj = new DefaultConstructorExample();
            Console.WriteLine(obj.value);
            //obj.Test();

        }
    }
    //class DefailtConstructor1
    //{
    //}
}
