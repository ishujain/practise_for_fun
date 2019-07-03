using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverDP
{
    class WeatherData : Subject
    {
        List<Observer> lstObserver = new List<Observer>();
        public string Humidity { get; set; }
        public string Temperature { get; set; }

        public void NotifyObserver()
        {
            Console.WriteLine("Notifying Observer");
            foreach (var item in lstObserver)
            {
                item.Update(Humidity, Temperature);
            }
        }

        public void RegisterObserver(Observer observer)
        {
            Console.WriteLine("Registering Observer");
            lstObserver.Add(observer);
        }

        public void RemoveObserver(Observer observer)
        {
            Console.WriteLine("Removing Observer");
            lstObserver.Remove(observer);
        }
        public void SetMeasurements(string humidity, string temp)
        {
            Console.WriteLine("Setting the measurements");
            this.Humidity = humidity;
            this.Temperature = temp;
            NotifyObserver();
        }
    }
}
