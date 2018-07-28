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
