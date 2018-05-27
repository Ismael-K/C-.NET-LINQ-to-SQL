using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

/*
 * We will not allow MainThread to exit until all threads complete their tasks.
 * This is done by using Join().  This will prevent calling thread from exiting until
 * all other threads have completed their tasks.   
 */
namespace FirstProject
{
    class MultiThreading4
    {
        static void Test1()
        {
            Console.WriteLine("Thread1 is starting");
            for (int i = 1; i <= 50; i++)
                Console.WriteLine("Test1: " + i);
            Thread.Sleep(5000);
            Console.WriteLine("Thread1 is exiting");
        }

        static void Test2()
        {
            Console.WriteLine("Thread2 is starting");
            for (int i = 1; i <= 50; i++)
                Console.WriteLine("Test2: " + i);

            Console.WriteLine("Thread2 is exiting");
        }

        static void Test3()
        {
            Console.WriteLine("Thread3 is starting");
            for (int i = 1; i <= 50; i++)
                Console.WriteLine("Test3: " + i);

            Console.WriteLine("Thread3 is exiting");
        }

        static void Main()
        {
            Console.WriteLine("MainThread Started");
            Thread t1 = new Thread(Test1);  //By Passing Test1, ThreadStart delegate is created internally 
            Thread t2 = new Thread(Test2);
            Thread t3 = new Thread(Test3);
            t1.Start();
            t2.Start();
            t3.Start();

            t1.Join(3000);  //wait for 3000 ms for t1 to finish.    
            t2.Join();
            t3.Join();      //MainThread will not exit until all threads complete tasks

            Console.WriteLine("MainThread Exiting");
            Console.ReadLine();

        }

    }
}
