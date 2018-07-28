/*~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~MultiThreading~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
 * MultiThreading is a process in which multiple threads works simultaneously to achieve multitasking.
 * System.Threading namespace contains classes and interfaces to provide facility of 
   multithreaded programming.
 * Life Cycle of a thread starts when instance of System.Threading.Thread class is created.The
   states in the life cycle of a Thread includes:

   a)Unstarted=>Instance of Thread class is created.
   b)Runnable =>when start() method on thread is called.
   c)Running  =>Time of execution.
   d)Not Runnable=>sleep()/wait() is called on a thread.
   e)Dead/Terminated=>After task completion.
 
 
 */

 /*~~~~~~~~~~~~~~~~~~~~~~~~~~~~~   Process Vs Thread   ~~~~~~~~~~~~~~~~~~~~~~~~
  * Process represents an application.
    Thread represents a module of application.

  * Process is heavyweight.
    Thread  is lighrweight.

  * Thread is executed within a process.
  
  * A seperate memory area is occupied in case of a process.
    Threads share a common memory area
  
  */

//Thread is dispatchable unit of executable code


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Basic_Project
{
    class MultiThreading
    {
        static void Main(string[] args)
        {
            MultiThreading obj = new MultiThreading();
            //ThreadStart is a delegate
            ThreadStart ts = new ThreadStart(obj.Run1);

            /* Or
            ThreadStart ts1 = obj.Run1;
            */

            
            Thread t1 = new Thread(ts);
            Thread t2 = new Thread(obj.Run2);
            t1.Start();
           
            t2.Start();

           

        }
        public void Run1()
        {
            for(int i=10;i<=20;i++)
            {
                Console.WriteLine(i);
            }
        }
        public void Run2()
        {
            for(int i=100;i<=120;i++)
            {
                Console.WriteLine(i);
            }
        }

    }
}
