using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverDP
{
    class CurrentDisplay : Observer
    {
        Subject subject;
        public CurrentDisplay(Subject sub)
        {
            subject = sub;
            subject.RegisterObserver(this);
        }

        public void Update(string Humidity, string temp)
        {
            Console.WriteLine("Update...CurrentDisplay: " + Humidity + " Temp: " + temp);
            //do something
        }
        public void RemoveObserver()
        {
            subject.RemoveObserver(this);
        }
    }
}
