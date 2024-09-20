using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class A3ForeachLoop
    {
        static void Main()
        {
            string[] mobDevices = { "Realme", "Vivo", "Apple", "Oppo", "Oneplus","Redmi","Moto","Samsung","Nothing","Xiaomi" };

            foreach (string mobile in mobDevices) 
            {
                Console.WriteLine("The Types of MobilePhones : "+mobile);
            }
        }
    }
}
