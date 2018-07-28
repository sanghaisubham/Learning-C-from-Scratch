/*
 * Static functions exist even before the object is created.
 * Static functions can access only static variables.
 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Project
{
    class LeapYear_Static
    {
        static void Main(string[] args)
        {
            int year;
            bool result;
            Console.WriteLine("Enter A Year: ");
            year = Convert.ToInt32(Console.ReadLine());

            //MathClass mathObj = new MathClass();
            //result=mathObj.Leap(year);

            //Directly using access of a class(static method)

            //All the methods of header file like sqrt and all are static methods so we can directly use 
            //it without creating any object
            
            //Static Methods=>Class reference(Direct without creating any object)
            //Non Static Methods=>Object reference

            result = MathClass.Leap2(year); //For static we dont need to create any object
            if (result == true)
                Console.WriteLine("The year {0} is a Leap Year", year);
            else
                Console.WriteLine("The Year {0}  is a Non Leap Year", year);
        }
    }
    class MathClass
    {
        public bool Leap(int year)
        {
            if (year % 4 == 0)
            {
                if ((year % 100 != 0) || (year % 400 == 0))
                    return true;
                else
                    return false;
            }
            else
            {
                return false;
            }
        }

        public static bool Leap2(int year)
        {
            if (year % 4 == 0)
            {
                if ((year % 100 != 0) || (year % 400 == 0))
                    return true;
                else
                    return false;
            }
            else
            {
                return false;
            }
        }
    }
    
}
