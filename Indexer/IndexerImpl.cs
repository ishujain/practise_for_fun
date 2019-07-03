using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexer
{
    class Employee
    {
        public string Name { get; set; }
        public int[] Salary { get; set; }
        string[] Dept = new string[5];
        public string this[int i]
        {
            get
            {
                return Dept[i];
            }
            set
            {
                Dept[i] = value;
            }
        }
        public string this[float i]
        {
            get
            {
                return Dept[1];
            }
            set
            {
                Dept[1] = value;
            }
        }

        //RETURN TYPE based OVERLOADING not possible in c#
        //public int this[int i]
        //{
        //    get
        //    {
        //        return Salary[1];
        //    }
        //    set
        //    {
        //        Salary[1] = value;
        //    }
        //}
    }
    class IndexerImpl
    {
        static void Main(string[] args)
        {
            var emp = new Employee();
            emp[0] = "Finance";
            emp[1] = "IT";
            emp[2] = "Stock";
            emp[3] = "Management";
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Department names - " + emp[i]);
            }
        }
    }
}
