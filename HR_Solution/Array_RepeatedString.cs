using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_Solution
{
    class Array_RepeatedString
    {
        static long repeatedString(string s, long n)
        {
            long aCount = 0;
            long charCount = 0;
            long totalCount = 0;
            long quot = 0;
            long remainder = 0;

            List<char> lst = new List<char>();
            foreach (var item in s.ToCharArray())
            {
                lst.Add(item);
            }
            aCount = lst.Count(c => c == 'a');
            charCount = lst.Count();
            if (aCount == 0)
            {
                totalCount = 0;
            }
            else if (charCount == 1)
            {
                totalCount = n;
            }
            else
            {
                quot = Math.DivRem(n, charCount, out remainder);

                totalCount = quot * aCount;
                for (int i = 0; i < remainder; i++)
                {
                    if (lst[i] == 'a')
                    {
                        totalCount++;
                    }
                }
            }

            return totalCount;
        }

        static void RemoveMe_Main(string[] args)
        {
            string s = Console.ReadLine();

            long n = Convert.ToInt64(Console.ReadLine());

            long result = repeatedString(s, n);
            Console.WriteLine(result);
        }

    }
}
