using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Basic_Project
{
    class Threading_Tick_Tock_Tag
    {
        Thread thread;
        string Name;
        static object lockobj = new object();
        public Threading_Tick_Tock_Tag(string name)
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
                Console.Write("Tock ");
                Monitor.Pulse(lockobj);//Signalling the other thread which was previously in waiitng queue
                Monitor.Wait(lockobj);//Waiting 
            }
        }
        public void Tag(bool running)
        {
            lock (lockobj)
            {
                if (running == false)
                {
                    Monitor.Pulse(lockobj);
                    return;
                }
                Console.WriteLine("Tag ");
                Monitor.Pulse(lockobj);//Signalling the other thread which was previously in waiitng queue
                Monitor.Wait(lockobj);//Waiting 
            }
        }
        public void Run()
        {
            if (Name == "T1")
            {
                for (int i = 0; i < 5; i++)
                    Tick(true);
                Tick(false);
            }
            else if(Name=="T2")
            {
                for (int i = 0; i < 5; i++)
                    Tock(true);
                Tock(false);
            }
            else
            {
                for (int i = 0; i < 5; i++)
                    Tag(true);
                Tag(false);
            }
        }
    }
    class MyMainclass
    {
        static void Main(string[] args)
        {
            Threading_Tick_Tock_Tag t1 = new Threading_Tick_Tock_Tag("T1");
            Threading_Tick_Tock_Tag t2 = new Threading_Tick_Tock_Tag("T2");
            Threading_Tick_Tock_Tag t3 = new Threading_Tick_Tock_Tag("T3");
        }
    }

}
