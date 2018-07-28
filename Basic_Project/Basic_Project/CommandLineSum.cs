using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*For passing command line value .
1)Go to Properties
2)Go to Debug
3)Enter the Command Line values in the field Command Line Arguments
4)Run the program*/
namespace Basic_Project
{
    class CommandLineSum
    {
        static void Main(string[] args)
        {
            //In .Net array is a class
            //length property is 
            int sum = 0;
            for (int i = 0; i < args.Length; i++)
            {
                sum += Convert.ToInt32(args[i]);

            }
            Console.WriteLine("The Sum is : {0}", sum);
        }
    }
}
