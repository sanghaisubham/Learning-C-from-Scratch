using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Basic_Project
{
    class Threading_Example
    {
        Thread thread;
        string Name;
        static object lockobj = new object();
        public Threading_Example(string name)
        {
            Name = name;
            thread = new Thread(Run);
            thread.Name = Name;
            thread.Start();
        }
        public void Tick(bool running)
        {
            lock (lockobj)
            {
                if (running == false)
                {
                    Monitor.Pulse(lockobj);//With Pulse we give signal to waiting thread
                    return;
                }
                Console.Write("Tick ");
                Monitor.Pulse(lockobj);//Signalling the other thread which was previously in waiting queue
                Monitor.Wait(lockobj);//Waiting 
            }
        }
        public void Tock(bool running)
        {
            lock (lockobj)
            {
                if (running == false)
                {
                    Monitor.Pulse(lockobj);
                    return;
                }
                Console.WriteLine("Tock ");
                Monitor.Pulse(lockobj);//Signalling the other thread which was previously in waiitng queue
                Monitor.Wait(lockobj);//Waiting 
            }
        }
        public void Run()
        {
            if(Name=="T1")
            {
                for (int i = 0; i < 5; i++)
                    Tick(true);
                Tick(false);
            }
            else
            {
                for (int i = 0; i < 5; i++)
                    Tock(true);
                Tock(false);
            }
        }
    }
    class Mainclass
    {
        static void Main(string[] args)
        {
            Threading_Example t1 = new Threading_Example("T1");
            Threading_Example t2 = new Threading_Example("T2");
        }
    }
}
