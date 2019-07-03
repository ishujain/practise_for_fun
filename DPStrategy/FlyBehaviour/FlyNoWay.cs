using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyDP
{
    class FlyNoWay : IFlyBehaviour
    {
        public void Fly()
        {
            Console.WriteLine("NO wings to fly.");
        }
    }
}
