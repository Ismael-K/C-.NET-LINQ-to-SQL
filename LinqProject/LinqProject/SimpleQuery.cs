using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

/// <summary>
///  Only one line is required to sort array as opposed to complex logic in Program.cs
/// </summary>

namespace LinqProject
{
    class SimpleQuery
    {
        static void Main(string[] args)
        {
            int[] arr = { 12, 45, 67, 39, 8, 61, 74, 82, 97, 27, 56, 49, 58, 79, 86, 14, 3, 23, 37, 92 };
            var brr = from i in arr where i > 40 orderby i descending select i;

            foreach (int i in brr)
                Console.Write(i + " ");

            Console.ReadLine();


        }

    }
}
