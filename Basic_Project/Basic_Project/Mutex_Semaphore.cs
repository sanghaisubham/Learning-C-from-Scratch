using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
//Mutex is mutually exclusive lock
//lock obj is made private , 
namespace Basic_Project
{
    class Mutex_Semaphore
    {
        Thread thread;
        string Name;
        public static Mutex mutex;
        static Mutex_Semaphore()
        {
            mutex = new Mutex(false);
        }
        public Mutex_Semaphore(string name)
        {
            //mutex = new Mutex(false);
            thread = new Thread(Run);
            Name = name;
            thread.Name =Name;
            thread.Start();
        }
        public void Run()
        {
            Console.WriteLine("{0} Waiting..", Name);
            mutex.WaitOne();//Waiting for the lock to accquire
            Console.WriteLine("{0} Working..", Name);
            for (int i = 10; i <= 15; i++)
                Console.WriteLine(i);
           
            Console.WriteLine("{0} Relaesing Mutex..", Name);
            mutex.ReleaseMutex();

            //Console.WriteLine("Mutex Released..");

        }
    }
    class Mainclass
    {
        static void Main(string[] args)
        {
            Mutex_Semaphore ex = new Mutex_Semaphore("Child");
            Console.WriteLine("Main Thread Waiting");
            Mutex_Semaphore.mutex.WaitOne();
            Console.WriteLine("Main Thread Working..");
            for (int i = 100; i <= 105; i++)
                Console.WriteLine(i);
            Console.WriteLine("Main Releasing Mutex");
            Mutex_Semaphore.mutex.ReleaseMutex();


        }
    }
}
