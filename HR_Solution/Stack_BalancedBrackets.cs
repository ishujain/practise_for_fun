using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_Solution
{
    class Stack_BalancedBrackets
    {
        static string isBalanced(string s)
        {
            string yesStr = "YES";
            string noStr = "NO";
            var charArr = s.ToCharArray();
            Stack<string> leftBracket = new Stack<string>();
            Stack<string> rightBracket = new Stack<string>();
            if (charArr.Length % 2 != 0)
            {
                return noStr;
            }
            for (int i = 0; i < charArr.Length; i++)
            {
                if (charArr[i] == '(' || charArr[i] == '{' || charArr[i] == '[')
                {
                    leftBracket.Push(charArr[i].ToString());
                }
                if (charArr[i] == ')' || charArr[i] == '}' || charArr[i] == ']')
                {
                    if (leftBracket.Count() != 0)
                    {
                        var left = leftBracket.Pop();
                        var right = charArr[i].ToString();
                        if (left == "(" && right == ")")
                        {
                            continue;
                        }
                        if (left == "{" && right == "}")
                        {
                            continue;
                        }
                        if (left == "[" && right == "]")
                        {
                            continue;
                        }
                        else
                        {
                            return noStr;
                        }
                    }
                    else
                    {
                        return noStr;
                    }
                }
            }
            if (leftBracket.Count > 0)
            {
                return noStr;
            }
            else
                return yesStr;

        }

        static void _Main(string[] args)
        {
            int t = Convert.ToInt32(Console.ReadLine());

            for (int tItr = 0; tItr < t; tItr++)
            {
                string s = Console.ReadLine();

                string result = isBalanced(s);

                Console.WriteLine(result);
            }

        }
    }
}
