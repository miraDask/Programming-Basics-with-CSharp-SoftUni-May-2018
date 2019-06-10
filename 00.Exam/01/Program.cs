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
            int eggPrice = int.Parse(Console.ReadLine());
            int firstMonthNum = int.Parse(Console.ReadLine());
            int secondMonthNum = int.Parse(Console.ReadLine());
            int thirdMonthNum = int.Parse(Console.ReadLine());

            int firstMonthEggs = firstMonthNum * 20;
            int secondMonthEggs = (firstMonthNum + secondMonthNum) * 20;
            int thirdMonthEggs = (firstMonthNum + secondMonthNum + thirdMonthNum) * 20;
            double totalEggs = (firstMonthEggs + secondMonthEggs + thirdMonthEggs) * 0.96;
            double profit = Math.Floor(totalEggs * (eggPrice / 100.0));

            Console.WriteLine($"Profit: {profit} Lv.");
        }
    }
}
