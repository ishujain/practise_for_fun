using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorDP
{
    class Milk : CondimentDecorator
    {
        Beverage beverage;
        public Milk(Beverage beverage)
        {
            this.beverage = beverage;
        }
        public override string Description()
        {
            return beverage.Description() + " Milk ";
        }
        public override int cost()
        {
            return beverage.cost() + 10;
        }
    }
}
