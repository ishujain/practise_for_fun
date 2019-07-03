using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyDP
{
    class MuteQuack : IQuackBehaviour
    {
        public void Quack()
        {
            Console.WriteLine("No Quack, No Squeak");
        }
    }
}
