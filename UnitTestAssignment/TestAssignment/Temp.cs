using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TempService
{
    public class Temp
    {
        public double CelsiusToFahrenheit(double celsius)
        {
            double fahrenheit = (celsius * 9) / 5 + 32;
            Console.WriteLine("Fahrenheit: " + fahrenheit);
            return fahrenheit;

        }
        public double FahrenheitToCelsius(double fahrenheit)
        {
            double celsius = (fahrenheit - 32) * 5 / 9;
            Console.WriteLine("Celsius: " + celsius);
            return celsius;

        }


    }
}
