using System;
using WebApplication1;
using Xunit;

namespace TemperatureTests
{
    public class WeatherTemperatureTest
    {
        [Fact]
        public void TestCelciusToFahrenheit()
        {
            WeatherForecast weatherForecast = new WeatherForecast();
            var resp = weatherForecast.CelciusToFahrenheit(28);
            Assert.Equal(82, resp);
        }
    }
}
