using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorDP
{
    class Whip : CondimentDecorator
    {
        Beverage beverage;
        public Whip(Beverage beverage)
        {
            this.beverage = beverage;
        }
        public override string Description()
        {
            return beverage.Description() + " Whip ";
        }
        public override int cost()
        {
            return beverage.cost() + 10;
        }
    }
}
