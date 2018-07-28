/*~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~Static~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~*/
/*
 * To retain the value of a variable we can declare the variable as static variable.
 * To manipulate and use the value of  a static variable , we can define a function as static function.
 * Used to refer common property of all obj.
 */

/*~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~Static Variable ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~*/
/*
 * Keyword 'static' means that only one instance(copy) of given variable exists for all class and objects.
 * Used to define constants bcz their values can be invoked without creating an instance .
 * Can be initialized outside member func of class definition.
 */

/*~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~Static Function ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~*/
/*
 * Exist even before object creation.
 * 
 */

/*~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~Static Class ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~*/
/*
 * Cant be instantiated.
 * Can only have static members.
 * Static Class is sealed(no inheritance possible)
 * Cant contan Default Constructors
 */

/*~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~Static Constructor ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~*/
/*
 * Used to initialize static fields.
 * Used to perform action that is to be performed only once.
 * Invoked automatically before first instance is created or any static member is refernced.
 * Cant have any modifier/parameter.
 * Cant be called explicitly.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Project
{
    class StaticConcept
    {
        public int nonstatvar;
        public static int statvar;

        //static variable has only one copy

        public StaticConcept() 
        {
            nonstatvar = 10;
            //  statvar = 0; not error
        }
        // Static constructor cant be overloaded
        // Best place to initialize a static data member is a static constructor
        // we cant pass any parameter in a static constructor
        static StaticConcept()
        {
            statvar = 0;
           // nonstatvar = 5; error
        }
        public void Increment()
        {
            nonstatvar++;
            statvar++;
            Console.WriteLine("statvar: {0} nonstatvar:{1}", statvar, nonstatvar);
        }
    }
    class Static_Check
    {
        public int price;
        public static void Display()
        {
         //   price = 1000;//Error because non static data member is accessed in a static method
            
            /*non static data member can be declared inside a static function but cannot be accessed inside 
            static method*/
            
            /*Non static data member cannot be  accessed in a static method ,
             * while Static data member can be accessed in non static method*/
        }
    }
    static class Book
    {
       // public int price;//non static data member cant be declared within a static class
        public static int data;
      //  public Book() //Same Error(Creating Non static constructor)
       // {
        //    price = 0;
        //}
        static Book()
        {
            data = 2100;
        }
        public static void Display()
        {
            Console.WriteLine(data);
        }
    }
    class Static_Properties
    {
        static void Main(string[] args)
        {
            Console.WriteLine(StaticConcept.statvar);//First time the static constructor is called
            /*A static constructor is called only once , 
             * whereas a non static constructor is called everytime an object is created
             * Static constructor does not have any access specifier*/

            /*
             * For nonstatvar every object has its own copy.
             * For statvar there is only one copy for all the objects. 
             */

          //  Book b1= new Book(); //cant instantiate a static class
            StaticConcept obj1 = new StaticConcept();

            StaticConcept obj2 = new StaticConcept();

            StaticConcept obj3 = new StaticConcept();


            obj1.Increment();
            obj2.Increment();
            obj3.Increment();

            StaticConcept obj4 = new StaticConcept();
            obj4.Increment();


        }
    }
}
/*It is always better to intialise a static datamember inside a static constructor,so that every single time
 * we instantiate an object, the static data member does not get reinitialized inside a non static constructor.
 It will not be so if we initialise the static data member inside static Constructor because static constructor is
 called only once(i.e at the beginning) and not each and every time an object of the class is created, So here
 the problem of reinitialization of data member is resolved.*/