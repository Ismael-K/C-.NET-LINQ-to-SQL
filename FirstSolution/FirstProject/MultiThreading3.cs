using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace FirstProject
{
    
    class MultiThreading3
    {
        static void Test()
        {
            for (int i = 1; i < 100; i++)
            {
                Console.WriteLine("Test: " + i);

            }
        }

        static void Test(object max)
        {
            int num = Convert.ToInt32(max);
            for(int i = 1; i < num; i++)
            {
                Console.WriteLine("Test: " + i);
            }
        }

        static void Main()
        {
            //ThreadStart obj = new ThreadStart(Test);
            //ThreadStart obj = Test;
            //ThreadStart obj = delegate () { Test(); };
            //ThreadStart obj = () => Test();

            ParameterizedThreadStart obj = new ParameterizedThreadStart(Test);

            Thread t = new Thread(obj);
            t.Start("Hello");
            Console.ReadLine();
        }
    }
}
