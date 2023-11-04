using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    internal class TemperatureConverter
    {
        private double farenheit = 0;
        private double celsius = 0;
        public void Start()
        {
            ShowMenu();
        }
        private void ShowMenu()
        {
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("\tTEMPERATURE CONVERTER\t");
            Console.WriteLine($"\t       MAIN MENU\t");

            Console.WriteLine("-------------------------------------------");
            Console.WriteLine();

            Console.WriteLine($"     Celsius to Fahrenheit    : 1");
            Console.WriteLine($"     Fahrenheit to Celsius    : 2");
            Console.WriteLine($"     Exit                     : 0");

            Console.WriteLine("-------------------------------------------\n");
            Console.Write("Your choice: ");
            int answer = int.Parse(Console.ReadLine());

            bool exitLoop = false;

            if (answer == 1)
            {
                ShowTableCelsiusToFahrenheit();
            }
            else if (answer == 2)
            {
                ShowTableFahrenheitToCelsius();
            }
            else if (answer == 0)
            {
                exitLoop = true;
                Console.WriteLine("Have a nice day!");
            }
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine($"\t       MAIN MENU\t");
            Console.WriteLine("-------------------------------------------");

        }

        private double CelsiusToFarenheit(double celsius)
        {
            const int max = 100;
           
            for (int i = 0; i <= max; i+=4)
            {
                farenheit = (i * 9.0/5.0) + 32;
                Console.WriteLine("{0:0.00} C =    {1:0.00} F", i, farenheit);
            }
            return farenheit;
        }
        private double FarenheitToCelsius(double farenheit)
        {
            const int max = 212;

            for (int i = 0; i <= max; i+=10)
             {
                 celsius = (i - 32) * (5.0 / 9.0);
                 Console.Write("{0:0.00} F =    {1:0.00} C", i, celsius);
            }
            return celsius;
        }

        private void ShowTableCelsiusToFahrenheit()
        {
            CelsiusToFarenheit(celsius);
        }
        private void ShowTableFahrenheitToCelsius()
        {
            FarenheitToCelsius(farenheit);
        }
    }
}
