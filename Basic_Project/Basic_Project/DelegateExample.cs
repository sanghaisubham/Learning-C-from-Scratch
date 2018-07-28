using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Project
{
    delegate void strdel(string str);//Compatible with Length method //1
    class DelegateExample
    { 
    static void Main(string[] args)
    {
            strdel del = Length;//3(Here del has address of func)
            Run(del);//Registering Call Back //5//the address is sent to run method so that it invokes the delegate
            Console.WriteLine("===="); //6
    }
        public static void Length(string str)//2
        {
            Console.WriteLine(str.Length);
        }
        public static void Run(strdel del)//4
        {
            del.Invoke("Hello");
        }
    }
}
