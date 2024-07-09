using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace threads
{
    public delegate void LongRunningTask();

    
    internal class Program
    {
        public static void DoLongRunningWork()
        {
           
            Thread.Sleep(2000);
            Console.WriteLine("Long running task completed!");
        }
        static void Main(string[] args)
        {
            LongRunningTask task = DoLongRunningWork; // Assign method to delegate

            Thread thread = new Thread(new ThreadStart(task)); // Thread uses the delegate
            thread.Start(); 

            Console.WriteLine("Main thread continues...");

            
        }
    }
   /* public  class tasks
    {
        public static void task1()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(i+"  "+Thread.CurrentThread.Name);
            }
        }
        public static void task2()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(i+"  "+Thread.CurrentThread.Name);
            }
        }
    }*/
   /* internal class Program
    {
        
        static void Main(string[] args)
        {
            Thread t1 = new Thread(new ThreadStart(tasks.task1));
            Thread t2 = new Thread (new ThreadStart(tasks.task2));

            //set thread name
            t1.Name = "first thread";
            t2.Name = "second thread";

            // PRIORITY
            t1.Priority = ThreadPriority.Lowest;
            t2.Priority = ThreadPriority.Highest;

            t1.Start();
            t2.Start();

            
            
        }
    }*/
}
