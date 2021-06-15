using System;
using System.Collections.Generic;
using System.Linq;

namespace HR_Solution
{
    class Stacks_LargestRectangle
    {
        static long largestRectangle(int[] h)
        {
            long result = 0;
            long max = 0;
            var k = h.Length;

            for (int i = 0; i <= h.Length; i++)
            {
                if (h.Min() != h.Max())
                {
                    result = Convert.ToInt64((int)k) * h.Min();
                    h = h.Where(m => m != h.Min()).ToArray();
                    if (max < result)
                    {
                        max = result;
                    }
                }
                k--;
            }
            return max;
        }


        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            int[] h = Array.ConvertAll(Console.ReadLine().Split(' '), hTemp => Convert.ToInt32(hTemp))
            ;
            long result = largestRectangle(h);

            Console.WriteLine(result);

            //textWriter.Flush();
            //textWriter.Close();
        }

    }
}