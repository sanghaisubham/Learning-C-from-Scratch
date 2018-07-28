/*~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~Delegate~~~~~~~~~~~~~~~~~~~~~~~
 * Delegate is a way in C# to handle callback functions or eventhandler.
 * By delegate we can pass a function itself as a parameter.
 * Delegate is like  a pointer to a function (refernce data type) holding reference of a method.
 * A delegate can point to any method having same return type and parameters declared within a Delgate.
 * Invoking a Delgate is the same way, we invoke a method because it is a reference to a method.
 * Delegate can be invoked by:
 * 1)using () operator/
 * 2)Using Invoke() Method of delegate.
 * A Method can have a delegate type as a parameter which can be invoked
 

 /*~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~MultiCastDelegate~~~~~~~~~~~~~~~~~~~~~~~
  * A delegate pointing to multiple methods.
  * "+"operator adds function to delegate object & '-' operator removes existing function from 
   delegate object.
  * 
 */



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
  //This delegate is compatible with all the methods having return type=>void and which is parameterless
        static void Main(string[] args)
        {
            Delegates obj = new Delegates();
            MyDelegate del = new MyDelegate(obj.Run);
            //Passing an address of method not calling the method

            // del();
            del.Invoke();
            //A delegate has an invocation list where it stores the address of invoking functions
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            /*~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~*/
            del += new MyDelegate(Delegates.Start);//Multicast delegate
            del += new MyDelegate(obj.Walk);
            del.Invoke();//Invokes all methods in the invocation List

            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            /*~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~*/
            del -= new MyDelegate(Delegates.Start);
            del.Invoke();

            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            /*~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~*/
            Delegates obj1 = new Delegates();
            MyDelegate del1 = obj1.Run;
            del += Delegates.Start;
            del += obj.Walk;
            del.Invoke();
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            /*~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~*/

           
            del = obj1.Run;
          

            
            del.Invoke();
            //A delegate has an invocation list where it stores the address of invoking functions
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            /*~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~*/
            del += Start;
            del += obj1.Walk;// Since this is non static we need obj to call this method

            del();//Directly can  Invoke all methods in the invocation List without using invoke

            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            /*~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~*/
            del -= Start;//This is non static so we need no object
            del();

            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            /*~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~*/
           
            del1 = obj1.Run;
            del += Start;
            del += obj1.Walk;
            del();
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
