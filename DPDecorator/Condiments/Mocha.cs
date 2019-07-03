using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorDP
{
    class Mocha : CondimentDecorator
    {
        Beverage beverage;
        public Mocha(Beverage beverage)
        {
            this.beverage = beverage;
        }
        public override string Description()
        {
            return beverage.Description() + " Mocha ";
        }
        public override int cost()
        {
            return beverage.cost() + 20;
        }
    }
}
