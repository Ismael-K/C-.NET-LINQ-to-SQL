using System;

// sort values in arr that are greater than 40  and sort in descending order

namespace LinqProject
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 12, 45, 67, 39, 8, 61, 74, 82, 97, 27, 56, 49, 58, 79, 86, 14, 3, 23, 37, 92};
            int Count = 0;
            for(int i =0; i<arr.Length;i++)
            {
                if (arr[i] > 40)
                    Count = Count + 1;

            }
            int[] brr = new int[Count];  // store values > 40 in this new array
            int index = 0;
            for(int i =0;i<arr.Length;i++)
            {
                if(arr[i]>40)
                {
                    brr[index] = arr[i];
                    index = index + 1;
                }
            }

            Array.Sort(brr);
            Array.Reverse(brr);


            foreach (int i in brr)
                Console.Write(i + " ");
            Console.ReadLine();
        }
    }
}
