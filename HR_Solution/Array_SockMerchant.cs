using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Solution
{

    // Complete the sockMerchant function below.
    static int sockMerchant(int n, int[] ar)
    {
        int count = 0;
        //List<int>
        for (int i = 0; i < (n - (count * 2)); i++)
        {
            for (int j = 0; j < (n - (count * 2)); j++)
            {
                if (i != j)
                {
                    if (ar[i] == ar[j])
                    {
                        count += 1;
                        var numRemove = ar[i];
                        var index = Array.IndexOf(ar, numRemove);
                        ar = ar.Where((val, idx) => idx != index).ToArray();
                        var index2 = Array.IndexOf(ar, numRemove);
                        ar = ar.Where((val, idx) => idx != index2).ToArray();
                        i = 0;
                        break;
                    }
                }
            }
        }

        return count;
    }

    static void RemoveMe_Main(string[] args)
    {
        //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine());
        //n=100
        //string input = "50 49 38 49 78 36 25 96 10 67 78 58 98 8 53 1 4 7 29 6 59 93 74 3 67 47 12 85 84 40 81 85 89 70 33 66 6 9 13 67 75 42 24 73 49 28 25 5 86 53 10 44 45 35 47 11 81 10 47 16 49 79 52 89 100 36 6 57 96 18 23 71 11 99 95 12 78 19 16 64 23 77 7 19 11 5 81 43 14 27 11 63 57 62 3 56 50 9 13 45";

        int[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt32(arTemp));
        //int[] ar = Array.ConvertAll(input.Split(' '), arTemp => Convert.ToInt32(arTemp));

        int result = sockMerchant(n, ar);
        Console.WriteLine(result);
        //textWriter.WriteLine(result);

        //textWriter.Flush();
        //textWriter.Close();
    }
}
