/*~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~Constructor~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
 * A special Type of method(member function),invoked when instance of a class is created.
 * Used to initialise the members of a class
 * Name of constructor is the same as the class name.
 * Constructors can be modified to accept parameters also called as parameterised constructors
*/

/*~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~Destructor~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
 * Destructor deallocates memory .Destructs objects of classes.
 * It works opposite to Constructor and used to release instance of class from memory.
 * It is defined only once in a class
 * Destructors cant be inherited or overloaded.
 * Like constructors ,it is invoked automatically when scope of object ends
 * Destructor is used to remove other components used(unmanaged resources) which are not part of .Net.
 * Garbage collector automatically deallocates memory of the components which are part of .NET
 * There is no Garbage Collector in C++ so there we explicitly use Destructor for deallocation of Memory
 

/*Destructor vs Garbage Collector
 * Garbage Collection=>Process of automatically freeing up th memory of objects that are no more in use.
 * Decision to invoke destructor is made by C#'s garbage collector.

*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Project
{
    class Product
    {
        string Title;//datamembers
        /*If any access specifier is not mentioned in Data Members, it is by default private*/
        public int Price;
        //If we want any piece of code to be run during time of object creation then we use Constructors

        


        /* If we dont have any constructor then by default a parameterless constructor is created,
         but if we  do make a parameterised constructor then no parameterless constructor is created by default*/

        /*Parameterless/Instance Constructor
         * Constructor called when instance of a class is created.
         * Used to initialise the data members of the class*/

         /*Static Constructor
          * Used to initialise the static variables in a class.
          */
        public Product()
        {
            Title = "";
            Price = 0;
        }
        ~Product()
        {
            Console.WriteLine("Destructor is Called");
        }
        /*Parameterised Constructor=>A Constructor which has parameters is called parameterized constructor.It is used
         to provide different values to distinct objects*/
        public Product(string title, int price)
        {
            Title = title;
            Price = price;
        }
        public void GetDetails() //methods
        {
            Console.WriteLine("Enter Title:");
            Title = Console.ReadLine();
            Console.WriteLine("Enter Price:");
            Price = Convert.ToInt32(Console.ReadLine());
        }
        public void DisplayDetails()
        {
            Console.WriteLine("The Title is :{0}", Title);
            Console.WriteLine("The Price is :{0}", Price);
        }
    }
    class Constructor
    {
        static void Main(String[] args)
        {
            //int,char,float,double,long,short,bool,uint,ushort,ulong; //Primitive Data Type
            //Memory allocation done by stack=>Value Type(Eg. Struct,Ennumerations,Primitive DT)
            //Memory Allocation done by heap=>Reference type(E.g. Class,Interface ,Delegate)
            

            //If we want any code to be run during the time of object creation, then we use constructor
            Product product = new Product();
            product.GetDetails();
            product.DisplayDetails();

            Product product2 = new Product();
            product2.GetDetails();
            product2.Price = 3000;
            //product2.Title = "C#"; Cant access because Title is private
            product2.DisplayDetails();
            Product product3 = new Product("MVC", 300);
            product3.DisplayDetails();
        }
    }
}
