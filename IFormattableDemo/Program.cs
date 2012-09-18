using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;

namespace IFormattableDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Use composite formatting with format string in the format item.
            Temperature temp1 = new Temperature(10);
            Console.WriteLine("{0:M}", temp1);
            Console.ReadKey();
            //Console.WriteLine("{0:C} (Celsius) = {0:K} (Kelvin) = {0:F} (Fahrenheit)\n", temp1);

            // Use composite formatting with a format provider.
            temp1 = new Temperature(-40);
            //Console.WriteLine(String.Format(CultureInfo.CurrentCulture, "{0:C} (Celsius) = {0:K} (Kelvin) = {0:F} (Fahrenheit)", temp1));
            //Console.WriteLine(String.Format(new CultureInfo("fr-FR"), "{0:C} (Celsius) = {0:K} (Kelvin) = {0:F} (Fahrenheit)\n", temp1));
        }
    }
}
