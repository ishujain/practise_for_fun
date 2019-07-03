using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_Solution
{
    class Array_ArrayDS
    {
        static int[] reverseArray(int[] a)
        {
            //Array.Reverse(a);

            int[] newArray = new int[a.Count()];
            for (int i = 0; i < a.Count(); i++)
            {
                newArray[i] = a[a.Count() - i - 1];

            }
            return newArray;
        }

        static void RemoveMe_Main(string[] args)
        {

            int arrCount = Convert.ToInt32(Console.ReadLine());

            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp))
            ;
            int[] res = reverseArray(arr);

            Console.WriteLine(string.Join(" ", res));

        }
    }
}
