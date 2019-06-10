using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p05.Trapeziod_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            double sideA = double.Parse(Console.ReadLine());
            double sideB = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());

            double area = (sideA + sideB) * height / 2;

            Console.WriteLine($"Trapezoid area = {area}");
        }
    }
}
