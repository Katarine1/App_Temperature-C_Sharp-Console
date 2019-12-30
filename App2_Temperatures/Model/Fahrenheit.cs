using App2_Temperatures.Impl;

namespace App2_Temperatures.Model
{
    public class Fahrenheit : IFahrenheit
    {
        private double F { get; set; }

        public Fahrenheit() { }

        public Fahrenheit(double f)
        {
           F = f;
        }

        public string FahrenheitToCelsius()
        {
            return "\t\tCelsius = " + ((F - 32) / 1.8).ToString("F2");
        }

        public string FahrenheitToKelvin()
        {
            return "\t\tKelvin = " + ((F + 459.67) / 1.8).ToString("F2");
        }
    }   
}
