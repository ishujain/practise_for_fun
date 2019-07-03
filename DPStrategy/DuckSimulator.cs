using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyDP
{
    class DuckSimulator
    {
        //Mini DUCK Simulator
        static void Main(string[] args)
        {
            //BOTH ways, we implement STRATEGY DP
            //set the fly behaviour in mallard ctor
            Duck duck = new MallardDuck();
            duck.PerformFly();
            duck.PerformQuack();

            Console.WriteLine("##########################################");

            //set the fly behaviour dynamically with setter method
            Duck duck2 = new DecoyDuck();
            duck2.SetFlyBehaviour(new FlyWithWings());
            duck2.PerformFly();
            duck2.SetFlyBehaviour(new FlyWithRocket());
            duck2.PerformFly();
            duck2.SetQuackBehaviour(new Quack());
            duck2.PerformQuack();


        }
    }
}
