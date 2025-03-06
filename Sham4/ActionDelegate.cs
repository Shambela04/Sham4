using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sham4
{
    // 
    public delegate void Action(int i);
    class ActionDelegate
    {
        public static void Action1(int i)
        {
            Console.WriteLine(i);
        }
        public static void Main()
        {
            //** 1 method  *********** to call and create obj

            //DelegateName->obj =  new DN(MN)
            Action adele = new Action(Action1);
            int result = (4);
            Console.WriteLine("Result is :"+result);



            //************ 2 Method ************ 
            Action<int> t = Action1;
            t.Invoke(5);
        }
    }
}
