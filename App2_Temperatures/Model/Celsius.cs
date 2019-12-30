using App2_Temperatures.Impl;

namespace App2_Temperatures.Model
{
    public class Celsius : ICelsius
    {
        private double C { get; set; }

        public Celsius() { }

        public Celsius(double c)
        {
            C = c;
        }

        public string CelsiusToKelvin()
        {
            return "\t\tKelvin = " + (C + 273).ToString("F2");
        }

        public string CelsiusToFahrenheit()
        {
            return "\t\tFahrenheit = " + (1.8 * C + 32).ToString("F2");
        }
    }   
}
