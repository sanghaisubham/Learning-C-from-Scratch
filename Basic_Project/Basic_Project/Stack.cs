using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Project
{
    class Stack
    {
        static void Main(string[] args)
        {
            Stack<string> stack = new Stack<string>();
            stack.Push("One");
            stack.Push("Two");
            stack.Push("Three");
            string droppedObj=stack.Pop();
            Console.WriteLine("Removed:{0}", droppedObj);

            string LastObj = stack.Peek();
            Console.WriteLine("Last in Line:{0}", LastObj);


            foreach (string str in stack)
                Console.WriteLine(str);
        }
    }
}
