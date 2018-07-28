using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Project
{
    class MyClass
    {
        protected string myString;
        public virtual string GetString()
        {
            return myString;
        }
        public  string ContainedString
        {
            set
            {
                myString = value;
            }
        }
    }
    class MyDerivedClass:MyClass
    {
        public override string GetString()
        {
            return (myString+"output from derived class");
        }
    }
}
