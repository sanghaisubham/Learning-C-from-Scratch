using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Basic_Project
{
    class MultiThreading_Join
    {
        static void Main(string[] args)
        {
            MultiThreading_Join obj = new MultiThreading_Join();
            //ThreadStart is a delegate
           // ThreadStart ts = new ThreadStart();

            /* Or
            ThreadStart ts1 = obj.Run1;
            */


            Thread t1 = new Thread(obj.Running1);
            Thread t2 = new Thread(obj.Running2);
            Thread t3 = new Thread(obj.Running3);
            t1.Start();
            /*Causes calling threads to wait until current thread(joined thread) is terminated
             or completes its task*/
            t1.Join();
            t2.Start();
            t3.Start();

            

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
        public void Running3()
        {
            for (int i = 1000; i <= 1010; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
