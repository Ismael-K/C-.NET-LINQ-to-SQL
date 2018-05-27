using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;


namespace FirstProject
{
    class ThreadTest
    {
        static void Test1()
        {
            for(int i=1; i<50; i++)
            {
                Console.WriteLine("Test1: " + i);
            }
            Console.WriteLine("Thread1 is exiting.");
        }
        static void Test2()
        {
            for (int i = 1; i < 50;  i++)
            {
                Console.WriteLine("Test2: " + i);
                if(i == 50)
                {
                    Console.WriteLine("Thread2 is going to sleep.");
                    Thread.Sleep(5000);
                    Console.WriteLine("Thread2 woke up");
                }
            }
            Console.WriteLine("Thread2 is exiting.");
        }
        static void Test3()
        {
            for (int i = 1; i < 50; i++)
            {
                Console.WriteLine("Test3: " + i);
            }
            Console.WriteLine("Thread3 is exiting.");
        }
        
        static void Main()
        {
            Thread T1 = new Thread(Test1);
            Thread T2 = new Thread(Test2);
            Thread T3 = new Thread(Test3);  //Total 4 Threads including Main Thread
            T1.Start();
            T2.Start();
            T3.Start();
            Console.WriteLine("ThreadMain is exiting.");
            Console.ReadLine();
        }
    }
}
