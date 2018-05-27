using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace FirstProject
{
    class ThreadDemo
    {
        static void Test1()
        {
            for (int i = 1; i < 100; i++)
                Console.WriteLine("Test1: " + i);
        }
        static void Test2()
        {
            for (int i = 1; i < 100; i++)
            {
                Console.WriteLine("Test2: " + i);
                if (i == 50)
                {
                    Console.WriteLine("Main Thread going to sleep");
                    Thread.Sleep(5000);
                    Console.WriteLine("Main Thread woke up");

                }
                   
            }
                
            
        }
        static void Test3()
        {
            for (int i = 1; i < 100; i++)
                Console.WriteLine("Test3: " + i);
        }
        static void Main()
        {
            Test1();
            Test2();
            Test3();

            Console.ReadLine();
        }

        

    }
}
