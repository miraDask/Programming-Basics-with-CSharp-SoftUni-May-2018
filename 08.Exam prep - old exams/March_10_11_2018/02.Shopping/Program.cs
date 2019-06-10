using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Shopping
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int chocolateBars = int.Parse(Console.ReadLine());
            double milk = double.Parse(Console.ReadLine());

            double tangerines = Math.Floor(chocolateBars - (chocolateBars * 0.35));
            double cost = (chocolateBars * 0.65) + (milk * 2.70)+ (tangerines * 0.20);
            double diff = budget - cost;

            if (cost <= budget)
            {
                Console.WriteLine($"You got this, {diff:F2} money left!");
            }
            else
            {
                Console.WriteLine($"Not enough money, you need {Math.Abs(diff):F2} more!");
            }

        }
    }
}
