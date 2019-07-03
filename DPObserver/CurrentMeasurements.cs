using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverDP
{
    class CurrentMeasurements : Observer
    {
        Subject Subject;
        public CurrentMeasurements(Subject subject)
        {
            Subject = subject;
            Subject.RegisterObserver(this);
        }
        public void Update(string Humidity, string Temp)
        {
            Console.WriteLine("Update...CurrentMeasurements: " + Humidity + " Temp: " + Temp);
            //do something        
        }
        public void RemoveObserver()
        {
            Subject.RemoveObserver(this);
        }
    }
}