/*~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~Abstract Class~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
 *Abstract Class enables us to provide partial class implementation of an interface.
 * Contains Abstract Methods,which can be implemented by derived class.
 * Cannot create instance of abstract class.
 * Cannot declare abstract method outside an abstract class.
 * Cannot be declared sealed
 
 */

/*~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~Abstract Method~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
*Abstract Methods are methods without any body.
*Implemented by derived class.
* When derived class inherits abstract method from abstract class, it must override the abstract methods.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Project
{
    //abstract class gives us the guidelines to implement
    /*override is used
     1)Virtual Function of Parent
     2)Abstract Function*/
    abstract class Area
    {
        //Array is an abstract class because we can fix the type of array
        public abstract void FindArea();//No body=>Abstract Method
        //we can create more than one abstract method in a class
        //We cant create instance of abstract class

        //public abstract void FindPeri();//Error in below line if we uncomment it and dont implement in child
        public void FindVol() { }
    }
    //A class that inherits a Abstract Class has to implement all abstract methods of Abstract Class.
    class Rectangle : Area
    {
        public override void FindArea()
        {
            int breadth, length;
            Console.WriteLine("Enter Breadth");
            breadth = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Length");
            length = Convert.ToInt32(Console.ReadLine());
            int Area;
            Area = length * breadth;
            Console.WriteLine("Area of Rect is : {0}", Area);
        }
    }
    class Triangle : Area
    {
        public override void FindArea()
        {
            int base1;
            int height;
            Console.WriteLine("Enter Base");
            base1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Height");
            height = Convert.ToInt32(Console.ReadLine());
            double Area;
            Area = (base1 * height) / 2;
            Console.WriteLine("Area of Rect is : {0}", Area);

        }
    }
    class Abstracts
    {
        static void Main(string[] args)
        {
            char choice;
            Area area = null;//Can create a variable but cant create an obj of abstract class
            while (true)
            {
                Console.WriteLine("Enter (t) for traiangle (r) for rectangle and any other key to quit");
                choice = Convert.ToChar(Console.ReadLine());
                switch (choice)
                {
                    case 't':
                        area = new Triangle();
                        break;
                    case 'r':
                        area = new Rectangle();
                        break;
                    default:
                        break;

                }
                if (choice == 'r' || choice == 't')
                    area.FindArea();
                else
                    break;

            }
        }
    }
}
/* using abstract in base class function and then overriding is almost the same as using virtual in base function 
 * and then overriding.The diff is that if we declare a function as abstarct it is necessary to override it in
 * the base class .So the comulsory or important functions in the base class which must be overriden in the child class
 * must be declared as abstract.*/
/* Inside an abstract class it is not necesaary to declare an abstract function, it also works withot any 
 * abstract function but if we have atleast one function which is abstract then the class should be abstract
 * So we can have a mixture of abstarct fuctions and non abstract(which can be virtual) functions inside a abstarct 
 * class with the important functions which should be overriden in the child class mentioned explicitly as abstract */

/*Abstarct helps to standarise a function name,i.e all the child classes will now have the same standarised function 
 * name with a set of guidelines defined within the base abstract class */
