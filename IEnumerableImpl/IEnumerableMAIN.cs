using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEnumerableImpl
{
    class Test : IEnumerable
    {
        //EXAMPLE-1
        Test[] Items = null;
        int freeIndex = 0;
        public String Name { get; set; }
        public string Surname { get; set; }
        public Test()
        {
            Items = new Test[10];
        }
        public void Add(Test item)
        {
            Items[freeIndex] = item;
            freeIndex++;
        }
        // IEnumerable Member  
        public IEnumerator GetEnumerator()
        {
            foreach (object o in Items)
            {
                if (o == null)
                {
                    break;
                }
                yield return o;
            }
        }
    }
    class IEnumerableMAIN
    {
        public static void Main(String[] args)
        {
            //EXAMPLE-1
            Test t1 = new Test();
            t1.Name = "Sourav";
            t1.Surname = "Kayal";
            Test t2 = new Test();
            t2.Name = "Ram";
            t2.Surname = "Das";
            Test myList = new Test();
            myList.Add(t1);
            myList.Add(t2);
            foreach (Test obj in myList)
            {
                Console.WriteLine("Name:- " + obj.Name + "Surname :- " + obj.Surname);
            }
            // EXAMPLE -2
            Customer cust = new Customer();
            foreach (Customer item in cust)
            {
                Console.WriteLine("Name:- " + item.Name + "CITY:- " + item.City + "AGE - " + item.Age);

            }
            Console.ReadLine();
        }
    }
}
