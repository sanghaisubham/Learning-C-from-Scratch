using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Project
{
    class Collection_Queue
    {
        static void Main(string[] args)
        {
            Queue queue = new Queue();
            queue.Enqueue("One");
            queue.Enqueue("Two");
            queue.Enqueue("Three");
            Console.WriteLine("Size is:{0}", queue.Count);

            object obj=queue.Dequeue();
            Console.WriteLine("Removed:{0} ",obj);
            string s = (string)obj;

            Console.WriteLine("At Front: {0}",queue.Peek());

            bool cont = queue.Contains("Two");
            Console.WriteLine("Is Two Present in Queue : {0}", cont);

            queue.Clear();

            string[] arr = new string[queue.Count];
            queue.CopyTo(arr, 0);

            foreach(string str in queue)
            {
                Console.WriteLine(str);
            }
            //Generic Queue
            Queue<int> q = new Queue<int>();
        }
    }
}
