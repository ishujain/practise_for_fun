using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyDP
{
    public abstract class Duck
    {
        public IFlyBehaviour flyBehaviour;
        public IQuackBehaviour quackBehaviour;
        public abstract void Display();

        public void SetFlyBehaviour(IFlyBehaviour fly)
        {
            flyBehaviour = fly;
        }

        public void SetQuackBehaviour(IQuackBehaviour quack) => quackBehaviour = quack;

        public void PerformFly()
        {
            flyBehaviour.Fly();
        }
        public void PerformQuack()
        {
            quackBehaviour.Quack();
        }
    }
}
