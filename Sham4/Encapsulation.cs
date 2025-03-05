using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sham4
{

    class Abc
    {
        private int atmPIN;

        public int getReturn()
        {
            return atmPIN;
        }
        public void Setvalue(int pin)
        {
            atmPIN = pin;
        }
    }
    public class Encapsulation
    {
        public static void Main()
        {
            Abc r = new Abc();
            r.Setvalue(1234);
            Console.WriteLine("ATMPIN" + r.getReturn);
            //Console.ReadLine();
        }
    }
}
