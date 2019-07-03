using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyDP
{
    class DecoyDuck : Duck
    {
        public override void Display()
        {
            Console.WriteLine("This is ManMade DUCK.");
        }
    }
}
