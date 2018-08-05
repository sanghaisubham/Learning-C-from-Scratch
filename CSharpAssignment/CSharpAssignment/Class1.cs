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
            obj.ContainedString = "Abhishek";
            Console.WriteLine("String is :: {0}", obj.GetString());

            MyDerivedClass obj2 = new MyDerivedClass("Chaudhary");
            Console.WriteLine(obj2.GetString());
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
        public virtual string GetString()
        {
            return ContainedString;
        }
    }
    class MyDerivedClass : MyClass
    {
        public MyDerivedClass(string str)
        {
            ContainedString = str;
        }

        public override string GetString()
        {
            string str = "String from derived class :: " + ContainedString;
            return str;
        }
    }
}
