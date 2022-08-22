using System;

namespace WebApplication1
{
    public class WeatherForecast
    {
        public DateTime Date { get; set; }

        public int TemperatureC { get; set; }

        public double TemperatureF => 32 + (int)(TemperatureC / 0.5556);

        public string Summary { get; set; }

        public double CelciusToFahrenheit(int tempCelcius)
        {
            this.TemperatureC = tempCelcius;
            return TemperatureF;
        }


    }
}
