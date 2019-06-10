using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1a
{
    class Program
    {
        static void Main(string[] args)
        {
            double foodBudget = double.Parse(Console.ReadLine());
            double giftsBudget = double.Parse(Console.ReadLine());
            double hotelBudget = double.Parse(Console.ReadLine());

            double fuelNeeded = (420.0 / 100) * 7 ;
            double fuelCost = fuelNeeded * 1.85;
            double giftAndFoodCost = 3 * (foodBudget + giftsBudget);
            double hotelCost = (hotelBudget * 0.9) + (hotelBudget * 0.85) + (hotelBudget * 0.8);
            double totalCost = fuelCost + giftAndFoodCost + hotelCost;

                Console.WriteLine($"Money needed: {totalCost:F2}"  );
        }
    }
}
