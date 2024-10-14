using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    class A31GenericDelegateAction2
    {
        public static void ErrorMessege(string e)
        {
            string str = $" {e} Time: {DateTime.Now}";
            Console.WriteLine(str);
        }
        static void Main()
        {
            Action<string> logs = ErrorMessege;
            logs.Invoke("Error Occured ...");
        }
    }
}
