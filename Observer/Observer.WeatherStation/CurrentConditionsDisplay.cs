using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer.WeatherStation
{
    public class CurrentConditionsDisplay : IObserver, IDisplayElement
    {
        private WeatherData _weatherData;
        private float _humidity;
        private float _temperature;

        public CurrentConditionsDisplay(WeatherData weatherData)
        {
            _weatherData = weatherData;
            _weatherData.RegisterObserver(this);
        }

        public void Display()
        {
            Console.WriteLine($"Current conditions: {_temperature} F " +
                $"degrees and {_humidity} % humidity");
        }

        public void Update()
        {
            _temperature = _weatherData.getTemperature();
            _humidity = _weatherData.getHumidity();
            Display();
            
        }
    }
}
