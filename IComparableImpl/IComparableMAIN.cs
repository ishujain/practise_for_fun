using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IComparableImpl
{
    class Employee : IComparable<Employee>
    {
        public string Name { get; set; }
        public string City { get; set; }
        public int Age { get; set; }
        public Employee(string name, string city, int age)
        {
            Name = name; City = city; Age = age;
        }

        public int CompareTo(Employee other)
        {
            if (this.Age < other.Age)
            {
                return 1;
            }
            if (this.Age > other.Age)
            {
                return -1;
            }
            else
                return 0;
        }
    }

    class IComparableMAIN
    {
        static void RemoveMe_Main(string[] args)
        {
            //BEFORE IComparable both gives exception 
            List<Employee> list = new List<Employee>
            {
                new Employee("Balram","asdg",26),
                new Employee("Aam","asdj",24),
                new Employee("Ram","asdk",23),
                new Employee("Shaym","asdh",25),
                new Employee("Abhi","asdf",27)
            };
            list.Sort();
            //Employee[] arr = new Employee[]
            //{
            //new Employee("Balram", "asdg", 26),
            //new Employee("Aam", "asdj", 24),
            //    new Employee("Ram", "asdk", 23),
            //    new Employee("Shaym", "asdh", 25),
            //    new Employee("Abhi", "asdf", 27)
            //};
            //Array.Sort(arr);
            foreach (var item in list)
            {
                Console.WriteLine("Name : {0}, Age ={1}", item.Name, item.Age);
            }
            Console.ReadLine();
        }
    }


}
