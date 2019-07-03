using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_Solution
{
    class Array_DynamicArray
    {
        static List<int> dynamicArray(int n, List<List<int>> queries)
        {
            List<int> result = new List<int>();
            List<List<int>> seq = new List<List<int>>();
            for (int i = 0; i < n; i++)
            {
                seq.Add(new List<int>());
            }
            int lastAnswer = 0;
            var flag = false;
            for (int i = 0; i < queries.Count(); i++)
            {
                var q = queries[i][0];
                var seqNumber = (queries[i][1] ^ lastAnswer) % n;
                var lastSeq = seq[seqNumber];
                if (q == 1)
                {
                    lastSeq.Add(queries[i][2]);
                }
                else if (q == 2)
                {
                    var temp = queries[i][2] % lastSeq.Count();
                    lastAnswer = lastSeq[temp];
                    flag = true;
                }
                if (lastAnswer != 0 && flag)
                {
                    result.Add(lastAnswer);
                    flag = false;
                }
            }

            return result;
        }

        static void RemoveMe_Main(string[] args)
        {

            string[] nq = Console.ReadLine().TrimEnd().Split(' ');

            int n = Convert.ToInt32(nq[0]);

            int q = Convert.ToInt32(nq[1]);

            List<List<int>> queries = new List<List<int>>();

            for (int i = 0; i < q; i++)
            {
                queries.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(queriesTemp => Convert.ToInt32(queriesTemp)).ToList());
            }

            List<int> result = dynamicArray(n, queries);

            Console.WriteLine(string.Join("\n", result));
        }
    }
}
