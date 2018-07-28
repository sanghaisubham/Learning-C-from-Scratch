using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Project
{
    //Delegates hold reference of one method or more than one method
    //Used to create call back methods

    class Delegates
    {
        public delegate void MyDelegate();//void shows return type of referenced method
        //This delegate is compatible with all the methods(return type=>void,parameterless)
        static void Main(string[] args)
        {
            Delegates obj = new Delegates();
            MyDelegate del = new MyDelegate(obj.Run);//Passing an address of method not calling the method

            // del();
            del.Invoke();
            //A delegate has an invocation list where it stores the address of invoking functions
            del += new MyDelegate(Delegates.Start);//Multicasr delegate
            del += new MyDelegate(obj.Walk);
            del.Invoke();//Invokes all methods in the invocation List
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            del -= new MyDelegate(Delegates.Start);
            del.Invoke();


            /*~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~*/
            Delegates obj1 = new Delegates();
            MyDelegate del1 = obj1.Run;
            del += Delegates.Start;
            del += obj.Walk;
            del.Invoke();
        }
        public void Run()
        {
            Console.WriteLine("Run Method");
        }
        public static void Start()
        {
            Console.WriteLine("Start Method");
        }
        public void Walk()
        {
            Console.WriteLine("Walk Method.");
        }

    }
}
