using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverDP
{
    interface Observer
    {
        void Update(string Humidity,string Temp);
    }
}
