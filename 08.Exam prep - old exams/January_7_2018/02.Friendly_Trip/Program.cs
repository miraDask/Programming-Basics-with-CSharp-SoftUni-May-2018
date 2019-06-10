using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Friendly_Trip
{
    class Program
    {
        static void Main(string[] args)
        {
            double distance = double.Parse(Console.ReadLine());
            double fuelCost = double.Parse(Console.ReadLine());  // per 100km
            double fuelPrice = double.Parse(Console.ReadLine());
            double budget = double.Parse(Console.ReadLine());

            double totalPrice = (distance * (fuelCost / 100)) * fuelPrice;

            if (budget >= totalPrice)
            {
                Console.WriteLine($"You can take a trip. {(budget - totalPrice):F2} money left.");
            }
            else
            {
                Console.WriteLine($"Sorry, you cannot take a trip. Each will receive {(budget / 5.0):F2} money.");
            }
        }
    }
}
