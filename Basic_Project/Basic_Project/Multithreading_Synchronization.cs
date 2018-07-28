/*~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~  Synchronization  ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
 
 *  Synchronization is a technique that allows only one thread to access resource for particular time.
 *  No other thread can interrupt until assigned thread finishes task.
 *  When Sharable Resource is accessed ny Multiple Thread then Synchronization is required
 *  We use Locking to enforce Synchronization
 *  Lock is used to execute program synchronously.
 *  It is used to get lock for the current thread,execute the lock and release the lock.It ensures the 
    other thread does not interrupt the execution until the execution finish.
 *  
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Basic_Project
{
    class Multithreading_SharedResource
    {
        object lockobj = new object();
        static void Main(string[] args)
        {
            Multithreading_SharedResource obj = new Multithreading_SharedResource();
            ThreadStart ts = new ThreadStart(obj.Run1);
         
            /* Or
            ThreadStart ts1 = obj.Run1;
            */


            Thread t1 = new Thread(ts);
            Thread t2 = new Thread(obj.Run1);
            t1.Name = "T1";
            t2.Name = "T2";
            t1.Start();
            //Thread.Sleep(500);//Time in miliseconds
            /*Main Thread Sleeps for 500ms and gives 1st thread to run before starting of 2nd Thread*/
            t2.Start();


        }
        public void Run1()
        {
            //lock (lockobj)
            //There is no context switching between threads , and threads execute synchronously
            //{
                 Monitor.Enter(lockobj);
                for (int i = 10; i <= 20; i++)
                {
                   
                    Console.WriteLine("{0} {1}", Thread.CurrentThread.Name, i);
                }
                 Monitor.Exit(lockobj);
            //}
        }
       
    }
}
