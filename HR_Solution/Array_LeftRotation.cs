using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace HR_Solution
{
    class Array_LeftRotation
    {
        static void RemoveMe_Main(string[] args)
        {
            string[] nd = Console.ReadLine().Split(' ');

            int n = Convert.ToInt32(nd[0]);

            int d = Convert.ToInt32(nd[1]);

            int[] a = Array.ConvertAll(Console.ReadLine().Split(' '), aTemp => Convert.ToInt32(aTemp));

            List<int> lst = new List<int>();
            lst = a.ToList();

            List<int> lstLeft = new List<int>();

            for (int i = 0; i < d; i++)
            {
                lstLeft.Add(lst[0]);
                lst.RemoveAt(0);
                
            }
            lst.AddRange(lstLeft);
            Console.WriteLine(string.Join(" ", lst));
        }
    }
}
