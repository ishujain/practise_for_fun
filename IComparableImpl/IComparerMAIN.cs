using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IComparableImpl
{
    class sortEmployeebyAgeAsc : IComparer<Employee>
    {

        public int Compare(Employee x, Employee y)
        {
            if (x.Age > y.Age)
            {
                return 1;
            }
            if (x.Age < y.Age)
            {
                return -1;
            }
            else
                return 0;
        }
    }
    class sortEmployeebyName : IComparer<Employee>
    {

        public int Compare(Employee x, Employee y)
        {
            return string.Compare(x.Name, y.Name);
        }
    }
    class IComparerMAIN
    {
        static void Main()
        {
            List<Employee> list = new List<Employee>
            {
                new Employee("Balram","asdg",26),
                new Employee("Aam","asdj",24),
                new Employee("Ram","asdk",23),
                new Employee("Shaym","asdh",25),
                new Employee("Abhi","asdf",27)
            };
            var sortEmpAge = new sortEmployeebyAgeAsc();
            var sortEmpName = new sortEmployeebyName();
            list.Sort(sortEmpAge);
            Console.WriteLine("By Name");
            list.Sort(sortEmpName);
            Console.ReadLine();
        }
    }
}
