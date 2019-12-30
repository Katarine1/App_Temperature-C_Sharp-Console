using System;
using System.Globalization;
using App2_Temperatures.Model;

namespace App2_Temperatures
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine();
                Console.WriteLine("\t\t# --- Temperatures --- #\n");
                Console.Write("\t\tEnter Quantity: ");
                int n = int.Parse(Console.ReadLine());
                Console.WriteLine();
                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine("\t\tNumber " + (i + 1) + "\n");
                    Console.WriteLine("\t\tSelect a Temperature:\n");
                    Console.WriteLine("\t\tC - Celsius");
                    Console.WriteLine("\t\tF - Fahrenheit");
                    Console.WriteLine("\t\tK - Kelvin\n");
                    Console.Write("\t\tEnter Letter: ");
                    char letter = char.Parse(Console.ReadLine());
                    Console.WriteLine();
                    if (letter == 'C' || letter == 'c')
                    {
                        Console.WriteLine("\t\t1 - Celsius To Kelvin");
                        Console.WriteLine("\t\t2 - Celsius To Fahrenheit");
                        Console.WriteLine();
                        Console.Write("\t\tEnter Number: ");
                        int number = int.Parse(Console.ReadLine());
                        Console.WriteLine();
                        if (number == 1)
                        {
                            Console.Write("\t\tEnter Value Celsius: ");
                            double c = int.Parse(Console.ReadLine());
                            Celsius cel = new Celsius(c);
                            string k = cel.CelsiusToKelvin();
                            Console.WriteLine();
                            Console.WriteLine(k);
                            Console.WriteLine("\n\t\t----------------------------\n\n");
                        }
                        else if (number == 2)
                        {
                            Console.Write("\t\tEnter Value Celsius: ");
                            double c = int.Parse(Console.ReadLine());
                            Celsius cel = new Celsius(c);
                            Console.WriteLine();
                            string f = cel.CelsiusToFahrenheit();
                            Console.WriteLine(f);
                            Console.WriteLine("\n\t\t----------------------------\n\n");
                        }
                        else
                        {
                            Console.WriteLine("\n\n\t\tinvalid Number.\n\n");
                        }
                    }
                    else if (letter == 'F' || letter == 'f')
                    {
                        Console.WriteLine("\t\t1 - Fahrenheit To Celsius");
                        Console.WriteLine("\t\t2 - Fahrenheit To Kelvin");
                        Console.WriteLine();
                        Console.Write("\t\tEnter Number: ");
                        int number = int.Parse(Console.ReadLine());
                        Console.WriteLine();
                        if (number == 1)
                        {
                            Console.Write("\t\tEnter Value Fahrenheit: ");
                            double f = int.Parse(Console.ReadLine());
                            Fahrenheit fah = new Fahrenheit(f);
                            Console.WriteLine();
                            string c = fah.FahrenheitToCelsius();
                            Console.WriteLine(c);
                            Console.WriteLine("\n\t\t----------------------------\n\n");
                        }
                        else if (number == 2)
                        {
                            Console.Write("\t\tEnter Value Fahrenheit: ");
                            double f = int.Parse(Console.ReadLine());
                            Fahrenheit fah = new Fahrenheit(f);
                            Console.WriteLine();
                            string k = fah.FahrenheitToKelvin();
                            Console.WriteLine(k);
                            Console.WriteLine("\n\t\t----------------------------\n\n");
                        }
                        else
                        {
                            Console.WriteLine("\n\n\t\tinvalid Number.\n\n");
                        }
                    }
                    else if (letter == 'K' || letter == 'k')
                    {
                        Console.WriteLine("\t\t1 - Kelvin To Celsius");
                        Console.WriteLine("\t\t2 - Kelvin To Fahrenheit");
                        Console.WriteLine();
                        Console.Write("\t\tEnter Number: ");
                        int number = int.Parse(Console.ReadLine());
                        Console.WriteLine();
                        if (number == 1)
                        {
                            Console.Write("\t\tEnter Value Kelvin: ");
                            double k = int.Parse(Console.ReadLine());
                            Kelvin kel = new Kelvin(k);
                            Console.WriteLine();
                            string c = kel.KelvinToCelsius();
                            Console.WriteLine(c);
                            Console.WriteLine("\n\t\t----------------------------\n\n");
                        }
                        else if (number == 2)
                        {
                            Console.Write("\t\tEnter Value Kelvin: ");
                            double k = int.Parse(Console.ReadLine());
                            Kelvin kel = new Kelvin(k);
                            Console.WriteLine();
                            string f = kel.KelvinToFahrenheit();
                            Console.WriteLine(f);
                            Console.WriteLine("\n\t\t----------------------------\n\n");
                        }
                        else
                        {
                            Console.WriteLine("\n\n\t\tinvalid Number.\n\n");
                        }
                    }
                    else
                    {
                        Console.WriteLine("\n\n\t\tinvalid letter.\n\n");
                    }
                }
            }
            catch(Exception e)
            {
                Console.WriteLine("\n\n\t\tError : "+ e.Message + "\n\n");
            }                        
        }
    }
}
