using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01
{
    class Program
    {
        static void Main(string[] args)
        {
            double width = double.Parse(Console.ReadLine());
            double lenght = double.Parse(Console.ReadLine());
            double sandPrice = double.Parse(Console.ReadLine()); // per kg.
            double plankPrice = double.Parse(Console.ReadLine());  //for 1 plank

            double boxArea = width * lenght;
            double sandBoxArea = (width - (2 * 0.2)) * (lenght - (2 * 0.2));
            double borderArea = boxArea - sandBoxArea;
            double sandVolume = Math.Ceiling(sandBoxArea * 20);
            double planks = Math.Ceiling(borderArea / (2.2 * 0.2));
            double totalPrice = sandVolume * sandPrice + planks * plankPrice;

            Console.WriteLine($"{totalPrice:F2}");
        }
    }
}
