using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class q1
    {
        static void Main(string[] args)
        {
            MyClass obj = new MyClass();
            obj.ContainedString = "Subham";
            Console.WriteLine("String is :: {0}", obj.GetString());
        }
    }
    class MyClass
    {
        string st;
        public string ContainedString
        {
            get
            {
                return this.st;
            }
            set
            {
                this.st = value;
            }
        }
        public string GetString()
        {
            return ContainedString;
        }
    }
}
