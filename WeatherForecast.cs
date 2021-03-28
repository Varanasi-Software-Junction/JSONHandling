using System;
using System.Collections.Generic;
using System.Text;

namespace JSONHandling
{
    public class WeatherForecast
    {
        public DateTimeOffset Date { get; set; }
        public int TemperatureCelsius { get; set; }
        public string Summary { get; set; }
    }
}
