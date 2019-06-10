using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Moon
{
    class Program
    {
        static void Main(string[] args)
        {
            double speed = double.Parse(Console.ReadLine());
            double fuel = double.Parse(Console.ReadLine());  // for 100km

            double totalTime = Math.Ceiling((384400 * 2.0) / speed) + 3;
            double fuelNeeded = (fuel * (384400 * 2)) / 100;

            Console.WriteLine(totalTime);
            Console.WriteLine(fuelNeeded);
        }
    }
}
