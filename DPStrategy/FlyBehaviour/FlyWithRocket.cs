using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyDP
{
    class FlyWithRocket : IFlyBehaviour
    {
        public void Fly()
        {
            Console.WriteLine("Fly with Rocket !!! ");
        }
    }
}
