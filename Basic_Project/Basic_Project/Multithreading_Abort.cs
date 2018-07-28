using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Basic_Project
{
    class Multithreading_Abort
    {
        static void Main(string[] args)
        {
            Multithreading_Abort obj = new Multithreading_Abort();
            //ThreadStart is a delegate
            ThreadStart ts = new ThreadStart(obj.Running1);

            /* Or
            ThreadStart ts1 = obj.Run1;
            */


            Thread t1 = new Thread(ts);
            Thread t2 = new Thread(obj.Running2);
            t1.Start();
           
            t2.Start();

            try
            {
                t1.Abort();
                /*Abort() Method is used to terminate the thread.Output is unpredictable 
                 because thread may be in running state */
            }
            catch (ThreadAbortException tae)
            {
                Console.WriteLine(tae.ToString());
            }
            Console.WriteLine("END MAIN");

        }
        public void Running1()
        {
            for (int i = 10; i <= 20; i++)
            {
                Console.WriteLine(i);
            }
        }
        public void Running2()
        {
            for (int i = 100; i <= 110; i++)
            {
                Console.WriteLine(i);
            }
        }
        
    }
}
