using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Project
{
    class baseclass
    {
        public virtual void method1(string message)
        {
            Console.WriteLine("");
        }
    }
    class child1:baseclass
    {
        public override void method1(string message)
        {
            base.method1(message);
        }
    }
    class child2:baseclass
    {
        public override void method1(string message)
        {
            base.method1(message);
        }
    }
    class Assignment2
    {
        static void Main(string[] args)
        {
            baseclass[] bc = new baseclass[6];
            bc[0] = new child1();
            bc[1] = new child1();
            bc[2] = new child1();
            bc[3] = new child2();
            bc[4] = new child2();
            bc[5] = new child2();
            for (int i = 0; i < 6; i++)
            {
                bc[i].method1("Subham");
            }

        }
    }
}
