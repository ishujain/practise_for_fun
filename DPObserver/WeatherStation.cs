using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverDP
{
    class WeatherStation
    {
        static void Main(string[] args)
        {
            //Weather Station
            WeatherData weatherData = new WeatherData();
            var display1 = new CurrentDisplay(weatherData);
            var display2 = new CurrentMeasurements(weatherData);
            var display3 = new ThirdPartyDisplay(weatherData);
            weatherData.SetMeasurements("low", "high");
            weatherData.SetMeasurements("very low", "very high");
            display2.RemoveObserver();
            weatherData.SetMeasurements("very high", "very high");
            display3.RemoveObserver();
            weatherData.SetMeasurements("MODERATE", "very high");

        }
    }
}
