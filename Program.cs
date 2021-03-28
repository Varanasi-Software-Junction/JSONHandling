using System;
using System.Text.Json;
using System.Text.Json.Serialization;
namespace JSONHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            WeatherForecast weatherForecast = new WeatherForecast();
            weatherForecast.Date = DateTimeOffset.Now;
            weatherForecast.TemperatureCelsius = 45;
            weatherForecast.Summary = "Hello";
            WeatherForecast[] weatherForecasts = {weatherForecast,weatherForecast };

            var json =@"{""Date"":""2020-09-06T11:31:01.923395"",""TemperatureC"":-1,""Summary"":""Cold""} ";
            Console.WriteLine($"Input JSON: {json}"); ;
            var forecast = JsonSerializer.Deserialize<WeatherForecast>(json);

            Console.WriteLine(forecast);
            Console.WriteLine(forecast.Summary);
            string jsonString = JsonSerializer.Serialize(weatherForecast);
            Console.WriteLine(jsonString);
            jsonString = JsonSerializer.Serialize(weatherForecasts);
            Console.WriteLine(jsonString);
            var jsons = @"[{""Date"":""2020-09-06T11:31:01.923395"",""TemperatureC"":-1,""Summary"":""Cold""},{""Date"":""2020-09-06T11:31:01.923395"",""TemperatureC"":-1,""Summary"":""Cold""}] ";
            var forecasts = JsonSerializer.Deserialize<WeatherForecast[]>(jsons);
            Console.WriteLine(forecasts[0]);
        }
    }
}
