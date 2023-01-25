// See https://aka.ms/new-console-template for more information

using Observer.WeatherStation;

WeatherData weatherData  = new WeatherData();
CurrentConditionsDisplay currentDisplay = 
    new CurrentConditionsDisplay(weatherData);
ForecastDisplay forecastDisplay =
    new ForecastDisplay(weatherData);
StatisticsDisplay statisticDisplay =
    new StatisticsDisplay(weatherData);
HeatIndexDisplay heatDisplay =
    new HeatIndexDisplay(weatherData);

weatherData.SetMeasurements(80, 65, 30.4f);
weatherData.SetMeasurements(82, 70, 29.2f);
weatherData.SetMeasurements(78, 90, 29.2f);

Console.ReadKey();




//Console.WriteLine("Hello, World!");
