/*Errors
 * Syntax Errors
 * Runtime Errors
 * Logical Error
 
 */
 /*Exception
  * System Exception=>base class of all Exception classes(CLR generated errors).
  * Application Exception=>base class of non-fatal errors(error raised on business rule violation)
  * 
  */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Project
{
    class Exception_Handling
    {
        public void CheckAge(int age)
        {
           
            if(age<20 || age>60)
            {
                CustomException obj = new CustomException()
                {
                    Description = "Age is Invalid",
                    ErrorValue=age,
                    Source="Check Age Function"

                };
                throw obj;   
            }
            else
            {
                Console.WriteLine("Age is : {0}", age);
            }
        }
        static void Main(string[] args)
        {
            //ApplicationException
            int ages;
            Console.WriteLine("Enter the Age");
            ages = Convert.ToInt32(Console.ReadLine());
            
            try
            {
                
                Console.WriteLine("Age Is:{0}", ages);
                //Application Exception
                Exception_Handling obe = new Exception_Handling();
                try
                {
                    obe.CheckAge(ages);
                }
                catch (CustomException e)
                {
                    Console.WriteLine(e.ErrorDetails());
                    Console.WriteLine("");
                }
                int[] ary = new int[10];
                //ary[10] = 100;
                int x = 10;
                int y = 0;
                int z = x / y;

            }
            catch(FormatException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("----------");
                Console.WriteLine(ex.StackTrace);
            }
            catch(IndexOutOfRangeException fx)
            {
                Console.WriteLine(fx.Message);
            }
            catch(Exception eex)//Parent of all exception classes
            {
                string type=eex.GetType().ToString();
                Console.WriteLine(type);
                Console.WriteLine(eex.Message);
            }
            finally
            {
                Console.WriteLine("----------------------");
                Console.WriteLine(DateTime.Now+"\n");
            }
        }
    }
}
