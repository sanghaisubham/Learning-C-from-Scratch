//using keyword is used for including the namespaces in the program.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// A namespace is a collection of classes.
//Namespace is a wrapper which groups classes together, namespace within namespace can  exist.
namespace Basic_Project
{
    //Classes generally contain multiple methods. Methods define the behavior of the class. 
    class SquareRoot
    {
        static void Main(string[] args)
        {
            int number;
            double root;
            //Console.WriteLine prints in a new Line
            //Console.Write prints without adding a new line at the end

            Console.WriteLine("Enter a Number :");
            //WriteLine is a method of the Console class defined in the System namespace.
            //This statement causes the message  to be displayed on the screen.

            number = Convert.ToInt32(Console.ReadLine());//Console.ReadLine() always takes a string as input
            root = Math.Sqrt(number);
            root = Math.Round(root, 3);
            Console.WriteLine("The Root of {0} is {1}", number, root);
            Console.WriteLine("The Root of " + number + " is: " + root);

        }
    }
}
