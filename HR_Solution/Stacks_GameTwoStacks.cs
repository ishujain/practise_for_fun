using System;
using System.Collections.Generic;
using System.Linq;

namespace HR_Solution
{
    class Stacks_GameTwoStacks
    {
        static int twoStacks(int x, int[] a, int[] b)
        {
            var count = 0;
            var result = new Stack<int>();
            var stackA = new Stack<int>();
            foreach (var item in a.Reverse())
            {
                stackA.Push(item);
            }
            var stackB = new Stack<int>();
            foreach (var item in b.Reverse())
            {
                stackB.Push(item);
            }
            while (true)
            {
                if (stackB.Count == stackA.Count && stackA.Count == 0)
                {
                    return count = 0;
                }
                bool flagA = false;
                bool flagB = false;

                //One thing is clear from other comments here, the greedy solution will NOT work.
                //None of the explanations in the comment section are good at explaining how/why the given c++ solution by vkreddy21 works. I have tried explaining it below .....
                //So far only 1 thing is clear in the solution: When elements from 2nd stack are added, and (more recently added/last) elements from 1st stack are popped off, the solution ensures that the max count does not decrease and sum <= x (given in input).

                //Graphically:
                //A much better way to understand this is to think about what the final solution to the problem will look like.
                //For example, a possible solution could look like:
                //[s1 s2 s1 s2 s2 ]
                //where s1, s2 refer to some element from stack 1 and 2 respectively. It may be noted that all s1 elements are contiguous (since problem requires us to only pick from top of stack). 
                //Same for s2 elements.Now, since these elements are summed (which should be <= x), this means *they can be arranged in any order. So you could group all s1 accesses and 
                //then s2 accesses * (could have also done vice-versa). this is obviously correct because for "+" operator (using which sum is being calculated) does not care about order of operands.

                //Hence, our previous solution can be re-arranged to look like any of the following:
                //[s2 s2 s2 s1 s1 ]
                //(OR)
                //[s1 s1 s2 s2 s2]
                //What the second case ^ suggests is that you can create a solution like:
                //[s1 s1 s1 s1 s1]
                //and then add (or replace s1 elements if sum is exceeding "x") s2 elements one by one, eventually leading to
                //[s1 s1 s2 s2 s2] = [s1 s2 s1 s2 s2 ]
                //Note that ^ this final solution is same as the ^ solution (simply created as an example for this explanation) in the earlier part of this explanation.

                if (flagA == true && flagB == true)
                {
                    break;

                }
            }
            return count;
        }



        static void RemoveMe_Main(string[] args)
        {
            int g = Convert.ToInt32(Console.ReadLine());

            for (int gItr = 0; gItr < g; gItr++)
            {
                string[] nmx = Console.ReadLine().Split(' ');

                int n = Convert.ToInt32(nmx[0]);

                int m = Convert.ToInt32(nmx[1]);

                int x = Convert.ToInt32(nmx[2]);

                int[] a = Array.ConvertAll<string, int>(Console.ReadLine().Split(' '), aTemp => Convert.ToInt32(aTemp))
                ;
                int[] b = Array.ConvertAll(Console.ReadLine().Split(' '), bTemp => Convert.ToInt32(bTemp))
                ;
                int result = twoStacks(x, a, b);

                Console.WriteLine(result);
            }
        }
    }
}
