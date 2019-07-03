using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverDP
{
    class ThirdPartyDisplay : Observer
    {
        Subject Subject;
        public ThirdPartyDisplay(Subject subject)
        {
            Subject = subject;
            Subject.RegisterObserver(this);
        }

        public void Update(string Humidity, string Temp)
        {
            Console.WriteLine("Update...ThirdPartyDisplay: " + Humidity + " Temp: " + Temp);
            //do something        }
        }
        public void RemoveObserver()
        {
            Subject.RemoveObserver(this);
        }
    }
}
