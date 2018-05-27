using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
// demonstrates setting thread priority.
// Highest Priority uses most CPU resources.
// Lowest Priority uses least CPU resources.  

namespace FirstProject
{
    class MultiThread6
    {
        
       
          static long Count1, Count2;
          public static void IncrementCount1()
            {
                while (true)
                    Count1 += 1;
                
            }

            public static void IncrementCount2()
            {
                while (true)
                    Count2 += 1;

            }
            
            static void Main()
            {
                Thread t1 = new Thread(IncrementCount1);  //create new threads
                Thread t2 = new Thread(IncrementCount2);

                t1.Start();  //start execution
                t2.Start();

                Console.WriteLine("MainThread going to sleep.");
                Thread.Sleep(10000);
                Console.WriteLine("MainThread woke up.");

                t1.Priority = ThreadPriority.Lowest;
                t2.Priority = ThreadPriority.Highest;


                t1.Abort();  //use abort to escape the infinite loop
                t2.Abort();

                t1.Join();  
                t2.Join();

                Console.WriteLine("Count1: " + Count1);
                Console.WriteLine("Count2: " + Count2);  

            Console.ReadLine();
            }

        

    }
}
