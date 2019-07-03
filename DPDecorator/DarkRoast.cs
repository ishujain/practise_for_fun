using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorDP
{
    class DarkRoast : Beverage
    {
        public DarkRoast()
        {
            Desc = "DarkRoast"; 
        }
        public override int cost()
        {
            return 50;
        }

    }
}
