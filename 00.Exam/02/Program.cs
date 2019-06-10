using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02
{
    class Program
    {
        static void Main(string[] args)
        {
            double pocketMoney = double.Parse(Console.ReadLine());
            double salesMoney = double.Parse(Console.ReadLine());
            double costs = double.Parse(Console.ReadLine());
            double presentCost = double.Parse(Console.ReadLine());

            double totoalIncone = (5 * (pocketMoney + salesMoney)) - costs ;

            if (totoalIncone >= presentCost)
            {
                Console.WriteLine($"Profit: {totoalIncone:F2} BGN, the gift has been purchased.");
            }
            else
            {
                Console.WriteLine($"Insufficient money: {(presentCost - totoalIncone):F2} BGN.");
            }
        }
    }
}
