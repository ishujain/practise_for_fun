using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyDP
{
    class MallardDuck : Duck
    {
        public MallardDuck()
        {
            flyBehaviour = new FlyWithWings();
            quackBehaviour = new Quack();

        }
        public override void Display()
        {
            Console.WriteLine("I am Mallard Duck, I do Quack");
        }
    }
}
