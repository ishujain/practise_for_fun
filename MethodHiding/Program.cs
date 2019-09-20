using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodHiding
{

    public class My_Family
    {

        public virtual void member()
        {
            Console.WriteLine("Total number of family members: 3");
        }
    }

    // Derived Class 
    public class My_Member : My_Family
    {

        // Reimplement the method of the base class 
        // Using new keyword 
        // It hides the method of the base class 
        public override void member()
        {
            Console.WriteLine("Name: Rakesh, Age: 40 \nName: Somya, " +
                                   "Age: 39 \nName: Rohan, Age: 20 ");
        }
    }

    // Driver Class 
    class Program
    {

        // Main method 
        static public void Main()
        {

            // Creating the object of the derived class 
            My_Member cc = new My_Member();
            My_Family pc = new My_Member();
            My_Family pp = new My_Family();

            // Access the method of derived class 
            cc.member();
            Console.WriteLine("********************************");
            pc.member();
            Console.WriteLine("********************************");
            pp.member();

        }
    }
}
