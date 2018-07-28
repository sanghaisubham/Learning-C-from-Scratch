using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~Inheritance~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
 * Objects of derived class possess copies of data members and member functions of base class.
 * Base Class=>Super /Parent Class
 * Derived Class=>SubClass/Child Class
 * Each instance of Derived class includes attributes of base class.
 * It ensures code Reusability
 * 
 
     */



namespace Basic_Project
{
    class Employee
    {
        protected string Name;//protected can be accessed by Child
        protected int Code;
        public int AccessOutside=50;
        public Employee()
        {
            Console.WriteLine("I am Parent");
            Name = "";
            Code = 0;
        }
        public Employee(string name, int code)
        {
            Name = name;
            Code = code;
        }
        public void GetDetails()
        {
            Console.WriteLine("Enter Code:");
            Code = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Name:");
            Name = Console.ReadLine();
        }
        public void DisplayDetails()
        {
            Console.WriteLine("Code:{0}", Code);
            Console.WriteLine("Name:{0}", Name);
        }

    }
    //Multiple inheritance is not allowed in C#
    class Manager : Employee
    {
        double Salary;
        public Manager()
        {
            Salary = 0;
        }
        public Manager(string name, int code, double salary) : base(name, code)
        {
            //Name = "gvbh";
            //Code = 12;
            Salary = salary;
        }
        public new void GetDetails() //Warning because same name is used in Base and Child Class
         //using  new keyword we can say the compiler we have intentionally kept the same name of Child & Base
        {
            
            base.GetDetails();
            //Employee emp = new Employee();
            //emp.GetDetails();
            Console.WriteLine("Enter Salary:");
            Salary = Convert.ToDouble(Console.ReadLine());
        }
        public new void DisplayDetails()
        {
            base.DisplayDetails();
            Console.WriteLine("Salary:{0}", Salary);
        }

    }
    class Inheritance
    {
        public static void Main(string[] args)
        {
            //Manager manager = new Manager();
            //manager.GetDetails();
            //manager.DisplayDetails();


            //iN PARENT child relationship first the parent constructor is invoked first (that too parameterless)
            //After program termination , object is cleared by the garbage collector

            // creating object of sub class will invoke the constructor of base class
            Manager manager1 = new Manager();

            Manager manager2 = new Manager("Amit", 100, 3400);

            Console.WriteLine(manager1.AccessOutside);//AccessOutside is data member of Base class but is accessible 
                                                      //using the object of child class becauseobject of child class
                                                      //has all data member and member functions of  parent class
            manager2.DisplayDetails();
        }
    }
}
