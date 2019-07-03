using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorDP
{
    abstract class Beverage
    {
        public abstract int cost();

        public string Desc = "Beverage";
        public virtual string Description()
        {
            return Desc;
        }

    }
}
