using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAssignment
{
    class Class3
    {
        static void Main(string[] args)
        {
            baseclass[] arr = new baseclass[6];
            int i = 0;
            for(i = 0; i < 3; i++)
            {
                arr[i] = new child1();
            }
            for (i = 3; i < 6; i++)
            {
                arr[i] = new child2();
            }

            foreach(baseclass obj in arr)
            {
                obj.method1("Hello World !!");
            }
        }
    }
    class baseclass
    {
        public virtual void method1(string message)
        {
            Console.WriteLine("From baseclass :: " + message);
        }
    }
    class child1 : baseclass
    {
        public override void method1(string message)
        {
            Console.WriteLine("From child 1 :: " + message);
        }
    }
    class child2 : baseclass
    {
        public override void method1(string message)
        {
            Console.WriteLine("From child 2 :: " + message);
        }
    }
}
