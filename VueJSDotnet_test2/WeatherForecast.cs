using System;

namespace VueJSDotnet_test2
{
    public class WeatherForecast
    {
        public DateTime Date { get; set; }

        public int TemperatureC { get; set; }

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

        public int TemperatureT => TemperatureC - 273;

        public string Summary { get; set; }
    }
}
