using App2_Temperatures.Impl;

namespace App2_Temperatures.Model
{
    public class Kelvin : IKelvin
    {
        private double K { get; set; }

        public Kelvin() { }

        public Kelvin(double k)
        {
            K = k;
        }

        public string KelvinToCelsius()
        {
            return "\t\tCelsius = " + (K - 273.15).ToString("F2");
        }

        public string KelvinToFahrenheit()
        {
            return "\t\tFahrenheit = " + ((K * 1.8) - 459.67).ToString("F2");   
        }        
    }   
}
