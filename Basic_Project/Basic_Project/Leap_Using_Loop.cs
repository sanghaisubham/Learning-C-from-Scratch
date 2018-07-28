using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Project
{
    class Leap_Using_Loop
    {
        static void Main(string[] args)
        {
            char choice = 'y';
            int year;
            bool result;
            while (choice == 'y')
            {
                Console.WriteLine("Enter A Year: ");
                year = Convert.ToInt32(Console.ReadLine());

                MathClass mathObj = new MathClass();
                result = mathObj.Leap(year);
                if (result == true)
                    Console.WriteLine("The year {0} is a Leap Year", year);
                else
                    Console.WriteLine("The Year {0}  is a Non Leap Year", year);

                Console.WriteLine("Want to Continue ? (press (q) to quit and any key to continue)");
                choice = Convert.ToChar(Console.ReadLine());
                if (choice == 'q')
                    break;
                choice = 'y';
            }
            Console.WriteLine("End of Program");
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