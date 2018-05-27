using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject
{
    class ConstructorsDemo
    {
        static int y;
        int x;
        
        static ConstructorsDemo()
        {
            Console.WriteLine("Static constructor is called.");
        }
        public ConstructorsDemo(int x)
        {
            this.x = x;
            Console.WriteLine("Non-static constructor is called.");
        }
        static void Main()
        {
            Console.WriteLine("The Main Method is called.  ");
            ConstructorsDemo d1 = new ConstructorsDemo(10);
            ConstructorsDemo d2 = new ConstructorsDemo(20);

            Console.WriteLine(y);
            Console.WriteLine(d1.x + " " + d2.x );
            Console.ReadLine();
        }
    }
}
