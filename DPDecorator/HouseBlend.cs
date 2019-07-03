using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorDP
{
    class HouseBlend : Beverage
    {
        public override int cost()
        {
            return 60;
        }

       public string Desc = "HouseBlend";
    }
}
