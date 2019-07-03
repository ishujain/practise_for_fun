using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEnumerableImpl
{
    internal class Customer : IEnumerable
    {
        //EXAMPLE-2
        public string Name { get; set; }
        public string City { get; set; }
        public int Age { get; set; }
        private Customer[] CustomerArray { get; set; }
        public Customer()
        {
            Customer[] customers = new Customer[]
           {
                new Customer("Ra","Wao",21),
                new Customer("Raq","Wai",22),
                new Customer("Raw","Wau",23),
                new Customer("Rae","Way",24),
                new Customer("Rat","Wat",25)
           };
            CustomerArray = customers;
        }
        public Customer(string name, string city, int age)
        {
            Name = name;
            City = city;
            Age = age;

        }
        public IEnumerator GetEnumerator()
        {
            return CustomerArray.GetEnumerator();
        }
    }
}
