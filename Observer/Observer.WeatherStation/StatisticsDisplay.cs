using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer.WeatherStation
{
    public class StatisticsDisplay : IObserver, IDisplayElement
    {
        private WeatherData _weatherData;
        private float _maxTemp = 0.0f;
        private float _minTemp = 200;
        private float _tempSum = 0.0f;
        private int _numReadings;

        public StatisticsDisplay(WeatherData weatherData)
        {
            _weatherData = weatherData;
            _weatherData.RegisterObserver(this);
        }

        public void Display()
        {
            Console.WriteLine("Avg/Max/Min temperature = " + 
                (_tempSum / _numReadings)
             + "/" + _maxTemp + "/" + _minTemp);
        }

        public void Update()
        {
            float temp = _weatherData.getTemperature();
            _tempSum += temp;
            _numReadings++;

            if (temp > _maxTemp)
            {
                _maxTemp = temp;
            }

            if (temp < _minTemp)
            {
                _minTemp = temp;
            }

            Display();

        }
    }
}
