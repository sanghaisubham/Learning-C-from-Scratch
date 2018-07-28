using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Project
{
    class LeapYear
    {
        static void Main(string[] args)
        {
            int year;
            bool result;
            Console.WriteLine("Enter A Year: ");
            year = Convert.ToInt32(Console.ReadLine());

            MathClass mathObj = new MathClass();
            result = mathObj.Leap(year);
            if (result == true)
                Console.WriteLine("The year is a LeapYear");
            else
                Console.WriteLine("The Year is a Non Leap Year");
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


    }
}
