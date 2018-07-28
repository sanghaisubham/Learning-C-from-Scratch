/*
 * When Sharable Resource is accessed ny Multiple Thread then Synchronization is required
 * We use Locking to enforce Synchronization
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
            Thread.Sleep(500);//Time in miliseconds
                /*Main Thread Sleeps for 500ms and gives 1st thread to run before starting of 2nd Thread*/
            t2.Start();


        }
        public void Run1()
        {
            //lock (lockobj)
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
