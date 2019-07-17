using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_Solution
{
    class Stacks_EqualStacks
    {

        static int equalStacks(int[] h1, int[] h2, int[] h3)
        {
            var total1 = 0;
            var total2 = 0;
            var total3 = 0;
            Stack<int> s1 = new Stack<int>();
            Stack<int> s2 = new Stack<int>();
            Stack<int> s3 = new Stack<int>();

            foreach (var item in h1.Reverse())
            {
                total1 += item;
                s1.Push(item);
            }
            foreach (var item in h2.Reverse())
            {
                total2 += item;
                s2.Push(item);
            }
            foreach (var item in h3.Reverse())
            {
                total3 += item;
                s3.Push(item);
            }
            while (true)
            {
                if (total1 == 0 || total2 == 0 || total3 == 0)
                {
                    total1 = 0;
                    break;
                }
                if (total1 == total2 && total2 == total3 && total1 == total3)
                {
                    break;
                }
                if (total1 > total2)
                {
                    total1 -= s1.Pop();
                }
                if (total1 > total3)
                {
                    total1 -= s1.Pop();
                }
                if (total2 > total3)
                {
                    total2 -= s2.Pop();
                }
                if (total2 > total1)
                {
                    total2 -= s2.Pop();
                }
                if (total3 > total2)
                {
                    total3 -= s3.Pop();
                }
                if (total3 > total1)
                {
                    total3 -= s3.Pop();
                }

            }
            return total1;
        }

        static void RemoveMe_Main(string[] args)
        {

            string[] n1N2N3 = Console.ReadLine().Split(' ');

            int n1 = Convert.ToInt32(n1N2N3[0]);

            int n2 = Convert.ToInt32(n1N2N3[1]);

            int n3 = Convert.ToInt32(n1N2N3[2]);
            int[] h1 = Array.ConvertAll(Console.ReadLine().Split(' '), h1Temp => Convert.ToInt32(h1Temp))
            ;
            int[] h2 = Array.ConvertAll(Console.ReadLine().Split(' '), h2Temp => Convert.ToInt32(h2Temp))
            ;

            int[] h3 = Array.ConvertAll(Console.ReadLine().Split(' '), h3Temp => Convert.ToInt32(h3Temp))
            ;
            int result = equalStacks(h1, h2, h3);

            //textWriter.WriteLine(result);
        }
    }
}
