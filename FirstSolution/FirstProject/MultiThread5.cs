using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

// Demonstrate thread locking if many threads try to access same resource.
// Only one thread can access the resource at one time.  Then the control goes 
// to next thread.  

namespace FirstProject
{
    class MultiThread5
    {
        public void Display()
        {
            lock (this)
            {
                Console.Write("[CSharp is an ");
                Thread.Sleep(5000);
                Console.WriteLine("Object-Oriented Language]");
            }
        }

        static void Main()
        {
            MultiThread5 obj = new MultiThread5();
            //obj.Display();
            //obj.Display();
            //obj.Display();

            Thread t1 = new Thread(obj.Display);
            Thread t2 = new Thread(obj.Display);
            Thread t3 = new Thread(obj.Display);
            t1.Start();
            t2.Start();
            t3.Start();
            Console.ReadLine();
        }
        
    }
}
