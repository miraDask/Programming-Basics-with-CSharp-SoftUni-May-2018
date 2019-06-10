using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01a
{
    class Program
    {
        static void Main(string[] args)
        {
            int time = int.Parse(Console.ReadLine());
            double cardsPrice = double.Parse(Console.ReadLine());
            double adventurePrice = double.Parse(Console.ReadLine());
            double coffeePrice = double.Parse(Console.ReadLine());

            int timeLeft = time - 15;
            double moneyNeeded = (3 * cardsPrice) + (2 * adventurePrice) + coffeePrice;

            Console.WriteLine($"{moneyNeeded:F2}");
            Console.WriteLine(timeLeft);


        }
    }
}
