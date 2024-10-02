using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    class A16ArrayList
    {
        static void Main()
        {



            ArrayList Lst = new ArrayList();

            ///adding elements in to array list

            Lst.Add("Hello");
            Lst.Add("EveryOne");
            Lst.Add("Shambela");
            Lst.Add(04.05);
            Lst.Add(22);
            Lst.Add("B.tech");
            Lst.Add(2024);
            Lst.Add("CODEMIND TECHNOLOGY");
            Lst.Add("Dot Net");
            Lst.Add(true);

            Console.WriteLine(" # # # # # # # # # # # : Student Information : # # # # # # # # # # #");
            foreach (var element in Lst)
            {
                Console.WriteLine(element);
            }


            Lst.Reverse();

            Console.WriteLine("<<<<<<<<<<<<<< : Reverse Information : >>>>>>>>>>>>>>> ");
            foreach (var element in Lst)
            {
                Console.WriteLine(element);
            }

            Lst.Remove("Hello");
            Lst.Remove("B.tech");
            Lst.Remove(true);
            Lst.Remove("Shambela");
            Lst.Remove("CODEMIND TECHNOLOGY");
            Lst.Remove("EveryOne");
            Lst.Remove("Dot Net");

            Console.WriteLine("!!!!!!!!!!! : Missing Information:  !!!!!!!!!!!!");
            foreach (var element in Lst )
            {
                Console.WriteLine(element);
            }





        }
    }
}
