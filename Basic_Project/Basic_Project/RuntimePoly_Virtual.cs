/*~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~Polymorphism~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
 * In OOP's polymorphism allows one interface to be used for multiple functions.
 * It reduces complexity within functions of a class of a program.
 * It can be either static or dynamic.
 */

/*~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~Static Polymorphism~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
 
 * Function/Constructor Overloading=> Same name of 2 or more func with redefinition of a function with diff types of parameters,sql
  of parameter or no. of parameter.

 * Operator Overloading=> Allows user-defined types such as structures and classes, to use overloaded operators for easy
   manipulation of their objects.
 
 */


/*~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~Runtime Polymorphism~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
 
 * In dynamic polymorphism ,the decision about function execution is made at run time.
 * It is helpful than dynamic polymorphism because it provides more flexibility for manipulating objects.
 * It is implemented by 2 approaches:
 * =>Abstract Class.
 * =>Virtual Class.
 
 */
/*~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~Virtual~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
* Virtual Function is used when we want to allow a dunction defined in a base class to be implemented by child class
* This function can be implemented in its own way and the call to the method is decided at the runtime.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Project
{
   //sealed class Parent 
   //sealed class cant be inherited , so virtual function also cant be created in such class
   //virtual function is not necessary to be overriden in child class always
   //virtual function is like a normal method only that a child class can legally override(modify) it.
   class Parent
   {
       //public void Message()
       //{
       //    Console.WriteLine("Parent Class");
       //}
       public virtual void Message()
       {
           Console.WriteLine("Parent Class");
       }
   }
   class child1 : Parent
   {
       //public new void Message()//check the error
       //    //Child Message func is hiding parent Message func
       //{
       //    Console.WriteLine("Child Class");
       //}

       public override void Message()//check the error when override keyword is not used(Child Message func is hiding parent Message func)
       {
           Console.WriteLine("Child Class");
       }
   }
   class child2 : Parent
   {
        public new void Message()//check the error
                                //Child Message func is hiding parent Message func
       {
           Console.WriteLine("Child Class");
       }
   }

   //Multi Level Inheritance is possible but multiple inheritance in Not possible

   /*MultiLevel Inheritance*/
class ChildChild2 : child1
    {
        public override void Message()
        {
            Console.WriteLine("ChildChild1 Class");
        }
    }
    class RuntimePoly_Virtual
    {
        static void Main(string[] args)
        {
            Parent p1 = new child1();//upcasting

            /* upcasting is done so that one parent obj can hold reference of any child classs obj,
             so we dont need to create more than one variable to hold references of more than one child class */

            p1.Message();
            //variable of parent can hold ref of child class objects but reverse is not true 
            //In overriding, system looks at the refernce type of p

            Parent p2 = new child2();
            //In hiding, system looks only at the type of p
            p2.Message();

            //child2 obj = p1;//Not possible ,child class obj cant hold ref of parent class

            child1 obj = (child1)p1;//downcasting
            obj.Message();

            p1 = new ChildChild2();
            p1.Message();
        }


    }
}
//Child class overrides virtual function of base  class .
//By declaring a method as virtual , parent class gives access to child class to override its member function
//sealed with  class =>inheritance is stopped
//sealed with a function =>stops further overriding