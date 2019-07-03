using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyDP
{
    class Squeak : IQuackBehaviour
    {
        public void Quack()
        {
            Console.WriteLine("Squeak, Squeak !!! ");
        }
    }
}
