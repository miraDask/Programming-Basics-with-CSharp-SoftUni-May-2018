using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1a.Mining_Rig
{
    class Program
    {
        static void Main(string[] args)
        {
            int videoCardPrice = int.Parse(Console.ReadLine());
            int adapterPrice = int.Parse(Console.ReadLine());
            double energyPrice = double.Parse(Console.ReadLine()); // for one videoCard per day
            double profit = double.Parse(Console.ReadLine());    // for one videoCard per day

            int totalInvestment = 1000 + (13 * videoCardPrice) + (13 * adapterPrice);

            double profitPerDay = (profit - energyPrice) * 13;

            double returnInvestmentTime = Math.Ceiling(totalInvestment / profitPerDay);

            Console.WriteLine(totalInvestment);
            Console.WriteLine(returnInvestmentTime);

        }
    }
}
