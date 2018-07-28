using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~Interface~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
 * Interface define properties,methods,events.
 * Used when standard structure of method is to be followed by classes.
 * Seperates definition of objects from implementation 
 * Only methods,functions and properties can be interface but not variables
 * Interface declare methods implemented by classes.
 * A class can inherit from single class but can implement from multiple interfaces.
 * Class/Structure implementing interfaces also implements base interfaces of inherited interface
     */
namespace Basic_Project
{
    //Interface is also used to declare the guidelines
    //Stimulating the behaviour of multiple inheritance can be done by interface because class can implement multiple Interfaces
    //It also helps in Standarization in implementing classes 
    interface IMath
    {
        // int a;
        //interface cant declare fields or data members
        double PI { get; }
        double SquareRoot(int n);
        double XPowerY(double x, double y);
    }

    //It is compulsory for a class implementing Interface to declare or implementing all the function of a interface
    //All functions of a interface must be astract that is no body should be present in any one also


    //One interface can inherit another interface
    //interface IDate
    interface IDate : IMath
    {
        string GetDate(string format);
        string GetTime(string format);
    }
    //class cant inherit interface because interface is not a part of the same family
    class ImplementationClass : IDate
    {
        public double PI
        {
            get { return 22 / 7.0; }
        }
        public string GetDate(string format)
        {
            return DateTime.Now.ToString(format);
        }

        public string GetTime(string format)
        {
            return DateTime.Now.ToString(format);
        }

        public double SquareRoot(int n)
        {
            return Math.Sqrt(n);
        }

        public double XPowerY(double x, double y)
        {
            return Math.Pow(x, y);
        }
    }
    class Interface
    {
        static void Main(string[] args)
        {
            ImplementationClass obj = new ImplementationClass();
            string date = obj.GetDate("dd/MM/yyyy");
            Console.WriteLine(date);
            string time = obj.GetTime("hh:mm:ss");
            Console.WriteLine(time);
            Console.WriteLine(obj.PI);
        }
    }
}
