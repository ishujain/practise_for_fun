using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_Solution
{
    class Array_2D_hourglass
    {
        static int hourglassSum(int[][] arr)
        {
            int totalSum = 0;
            var flag = false;
            List<int> lstTotalSum = new List<int>();
            for (int m = 0; m < 4; m++)
            {
                for (int i = 0; i < 4; i++)
                {
                    flag = true;
                    for (int j = 0; j < 3; j++)
                    {
                        totalSum += arr[i][j + m];
                        totalSum += arr[i + 2][j + m];
                        if (flag)
                        {
                            totalSum += arr[i + 1][j + m + 1];
                            flag = false;
                        }
                    }
                    lstTotalSum.Add(totalSum);
                    totalSum = 0;
                }
            }
            return lstTotalSum.Max(); ;
        }

        static void RemoveME_Main(string[] args)
        {

            int[][] arr = new int[6][];

            for (int i = 0; i < 6; i++)
            {
                arr[i] = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
            }

            int result = hourglassSum(arr);
            Console.WriteLine(result);

        }
    }
}
