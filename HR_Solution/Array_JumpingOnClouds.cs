using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_Solution
{
    class Array_JumpingOnClouds
    {
        static int jumpingOnClouds(int[] c)
        {
            int jumpCount = 0;
            for (int i = 0; i < c.Count() - 1; jumpCount++)
            {
                if (i < c.Count() - 2 && c[i] == c[i + 2] && c[i + 2] == 0)
                {
                    i = i + 2;
                }
                else if (c[i] == c[i + 1] && c[i + 1] == 0)
                {
                    i = i + 1;
                }
            }
            return jumpCount;
        }

        static void RemoveMe_Main(string[] args)
        {

            int n = Convert.ToInt32(Console.ReadLine());

            int[] c = Array.ConvertAll(Console.ReadLine().Split(' '), cTemp => Convert.ToInt32(cTemp));
            int result = jumpingOnClouds(c);
            Console.WriteLine(result);
        }

    }
}
