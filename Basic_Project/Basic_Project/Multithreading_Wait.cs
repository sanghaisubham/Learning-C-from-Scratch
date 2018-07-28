using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Basic_Project
{
    class Multithreading_Wait
    {
        static void Main(string[] args)
        {
            Multithreading_Wait obj = new Multithreading_Wait();
            //ThreadStart is a delegate
            ThreadStart ts = new ThreadStart(obj.Running1);

            /* Or
            ThreadStart ts1 = obj.Run1;
            */


            Thread t1 = new Thread(ts);
            Thread t2 = new Thread(obj.Running2);
            t1.Start();
            Thread.Sleep(200);

            /*Sleep() method suspends the current thread for specified miliseconds.
             * So after the first thread is called , compiler waits for 200ms before starting 
             the 2nd thread*/
            t2.Start();

          

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
            for (int i = 100; i <= 120; i++)
            {
                Console.WriteLine(i);
            }
        }

    }
}
