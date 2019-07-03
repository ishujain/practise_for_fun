using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorDP
{
    class Program
    {
        static void Main(string[] args)
        {
            //Coffee ordering - Dark roast with 2 mocha  and whip
            Beverage bv1 = new DarkRoast();
            bv1 = new Mocha(bv1);
            bv1 = new Mocha(bv1);
            bv1 = new Whip(bv1);
            Console.WriteLine(bv1.cost());
            Console.WriteLine(bv1.Description());
        }
    }
}
