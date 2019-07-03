using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_Solution
{
    class Array_CountValleys
    {
        // Complete the countingValleys function below.
        static int countingValleys(int n, string s)
        {
            int level = 0;
            int valley = 0;
            foreach (var item in s.ToCharArray())
            {
                if (item=='D')
                {
                    level--;
                }
                if (item == 'U')
                {
                    level++;
                }
                if (level==0 && item=='U')
                {
                    valley++;
                }
            }
            return valley;

        }

        static void RemoveMe_Main(string[] args)
        {
            //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int n = Convert.ToInt32(Console.ReadLine());

            string s = Console.ReadLine();

            int result = countingValleys(n, s);
            Console.WriteLine(result);
            //textWriter.WriteLine(result);

            //textWriter.Flush();
            //textWriter.Close();

        }
    }
}
