using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sham4
{
    internal class NonGenericQueue
    {
        static void Main()
        {
            Queue qu = new Queue();
            // FIFO - first in first out
            //enqueue - it is basically used to add the elements in to the queue

            qu.Enqueue("Hi");
            qu.Enqueue(2024);
            qu.Enqueue(true);


            //deque - to remove elements
            object name1 = qu.Dequeue();
            object name2 = qu.Dequeue();
            object name3 = qu.Dequeue();


            //DIsplay the items 

            Console.WriteLine("Dequeued Elements");
            Console.WriteLine(name1);
            Console.WriteLine(name2);
            Console.WriteLine(name3);





        }

    }
}
