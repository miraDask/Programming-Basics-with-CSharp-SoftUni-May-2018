using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4a
{
    class Program
    {
        static void Main(string[] args)
        {
            int daysToRun = int.Parse(Console.ReadLine());

            double totalDistance = 0; // km
            double totalTime = 0;         // min
            


            for (int i = 0; i < daysToRun; i++)
            {
                int minPerDay = int.Parse(Console.ReadLine());
                double distance = double.Parse(Console.ReadLine());
                string measurement = Console.ReadLine();

                totalTime += minPerDay;

                if (measurement == "m")
                {
                    totalDistance += distance / 1000.0;
                }
                else if (measurement == "km")
                {
                    totalDistance += distance;
                }

                
            }
             double calories = (totalTime / 20.0) * 400;
            Console.WriteLine($"He ran {totalDistance:F2}km for {totalTime} minutes and burned {calories} calories.");
        }
    }
}
