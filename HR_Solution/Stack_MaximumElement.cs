using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_Solution
{
    class Stack_MaximumElement
    {
        //class Stack
        //{
        //    int top;
        //    int[] intArr = new int[10000];
        //    public Stack()
        //    {
        //        top = -1;
        //    }
        //    public void Push(int number)
        //    {
        //        top =++top;
        //        intArr[top] = number;
        //    }
        //    public void Pop()
        //    {
        //        top = --top;
        //    }
        //    public int Peek()
        //    {
        //        return intArr[top];
        //    }
        //}

        //public static void Main()
        //{
        //    int numberN = Convert.ToInt32(Console.ReadLine());

        //   Stack stack = new Stack();
        //    for (int i = 0; i < numberN; i++)
        //    {
        //        string[] input = Console.ReadLine().Split(' ');
        //        int[] inp = Array.ConvertAll(input, s => Convert.ToInt32(s));
        //        if (inp[0] == 1)
        //        {
        //            stack.Push(inp[1]);
        //        }
        //        else if (inp[0] == 2)
        //        {
        //            stack.Pop();
        //        }
        //        else if (inp[0] == 3)
        //        {
        //            Console.WriteLine(stack.Peek());
        //        }
        //    }
        //}


        //THIS IS WITH STACK CLASS
        public static void RemoveMe_Main()
        {
            Int32 numberN = Convert.ToInt32(Console.ReadLine());
            Stack<Int32> stack = new Stack<Int32>();
            Stack<Int32> maxStack = new Stack<Int32>();
            maxStack.Push(0);
            for (long i = 0; i < numberN; i++)
            {
                string[] input = Console.ReadLine().Split(' ');
                Int32[] inp = Array.ConvertAll(input, s => Convert.ToInt32(s));
                if (inp[0] == 1)
                {
                    stack.Push(inp[1]);
                    if (stack.Peek() >= maxStack.Peek())
                    {
                        maxStack.Push(inp[1]);
                    }
                }
                else if (inp[0] == 2)
                {
                    if (stack.Peek() == maxStack.Peek())
                    {
                        maxStack.Pop();
                    }
                    stack.Pop();

                }
                else if (inp[0] == 3)
                {
                    Console.WriteLine(maxStack.Peek());
                }
            }
        }
    }
}
