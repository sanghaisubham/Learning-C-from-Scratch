using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Value Types=>Integer,Character,FLoat,Structure
 * Refernce Types=>Classes,Delegates,Interfaces
 */
namespace Basic_Project
{
    class Pass_Value_Ref_Out
    {
        static void Main(String[] args)
        {
            int x = 20;
            Pass_Value_Ref_Out.CallByVal(x);
            Console.WriteLine("Passed By Value {0}", x);
            Pass_Value_Ref_Out.CallByRef(ref x);//Passing the reference
            Console.WriteLine("Passed By Reference {0}", x);
            Pass_Value_Ref_Out.OutputParams(out x);//Here we are giving a container to fill in a value 
            //Container intitially does not hold any value
            Console.WriteLine("Passed By Out {0}",x);

        }
        /*Call By Value=>Calling Function passes the values to the called function and those values are
         copied to the input parameters reperesented by data types of the function*/
        static void CallByVal(int x)
        {
            x = 1000;
        }
        /*Call By Ref=>Calling Function does not passes the values to the called function.Instead it passes the ref
         of variables or objects defined in its scope or class scope.
         Input parameter hold reference passed by calling func.*/
        static void CallByRef(ref int x)
        {
            x = 20000;
        }
        //The out parameter must be assigned to before control leaves the called method or function
        static void OutputParams(out int y)
        {
            y = 50000;
        }
    }
}
