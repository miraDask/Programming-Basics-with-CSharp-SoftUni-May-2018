using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p08.Metric_Converter
{
    class Program
    {
        static void Main(string[] args)
        {
            double distance = double.Parse(Console.ReadLine());
            string income = Console.ReadLine();
            string outcome = Console.ReadLine();

            if (income == "mm")
            {
                distance /=  1000;
            }
            else if (income == "cm")
            {
                distance /= 100;
            }
            else if (income == "mi")
            {
                distance /= 0.000621371192;
            }
            else if (income == "in")
            {
                distance /= 39.3700787;
            }
            else if (income == "km")
            {
                distance *= 1000;
            }
            else if (income == "ft")
            {
                distance /= 3.2808399;
            }
            else if (income == "yd")
            {
                distance /= 1.0936133;
            }

            if (outcome == "mm")
            {
                distance *= 1000;
            }
            else if (outcome == "cm")
            {
                distance *= 100;
            }
            else if (outcome == "mi")
            {
                distance *= 0.000621371192;
            }
            else if (outcome == "in")
            {
                distance *= 39.3700787;
            }
            else if (outcome == "km")
            {
                distance /= 1000;
            }
            else if (outcome == "ft")
            {
                distance *= 3.2808399;
            }
            else if (outcome == "yd")
            {
                distance *= 1.0936133;
            }
            Console.WriteLine($"{distance:F8}");
        }
    }
}
