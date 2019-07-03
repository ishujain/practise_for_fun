using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_Solution
{
    class Array_SparseArray
    {
        //NOT able to pass all the testcases with below solution because it is brute force approach, and failing due to timeout
        //solved by prefix sum array, to reduce time  from O(nm) to O(n)

        //static long arrayManipulation(int n, int m, int[][] queries)
        //{
        //    long[] temp = new long[n];

        //    for (int i = 1; i <= m; i++)
        //    {
        //        long a = queries[i - 1][0];
        //        long b = queries[i - 1][1];
        //        long k = queries[i - 1][2];
        //        //converting them to index values
        //        a--;
        //        b--;
        //        for (long j = a; j <= b; j++)
        //        {
        //            if (j >= a && j <= b)
        //            {
        //                temp[j] += k;
        //            }

        //        }
        //    }
        //    long max = temp.Max();
        //    return max;
        //}

        //static void Main(string[] args)
        //{
        //    string[] nm = Console.ReadLine().Split(' ');

        //    int n = Convert.ToInt32(nm[0]);

        //    int m = Convert.ToInt32(nm[1]);

        //    int[][] queries = new int[m][];

        //    for (int i = 0; i < m; i++)
        //    {
        //        queries[i] = Array.ConvertAll(Console.ReadLine().Split(' '), queriesTemp => Convert.ToInt32(queriesTemp));
        //    }

        //    long result = arrayManipulation(n, m, queries);
        //    Console.WriteLine(result);
        //}

        //updated the main with full updated code with prefix array
        static void RemoveMe_Main(string[] args)
        {
            string[] nm = Console.ReadLine().Split(' ');

            int n = Convert.ToInt32(nm[0]);
            int m = Convert.ToInt32(nm[1]);

            long[] arr = new long[n + 1];
            long tempMax = 0;
            long max = 0;

            for (int i = 0; i < m; i++)
            {
                //queries[i] = Array.ConvertAll(Console.ReadLine().Split(' '), queriesTemp => Convert.ToInt32(queriesTemp));
                var opString = Console.ReadLine().Split(' ');
                long a = Convert.ToInt64(opString[0]);
                long b = Convert.ToInt64(opString[1]);
                long k = Convert.ToInt64(opString[2]);
                arr[a] += k;
                if (b + 1 <= n) arr[b + 1] -= k;
            }
            for (int i = 1; i <= n; i++)
            {
                tempMax += arr[i];
                if (tempMax > max) max = tempMax;

            }
            Console.WriteLine(max);
        }
    }

}
