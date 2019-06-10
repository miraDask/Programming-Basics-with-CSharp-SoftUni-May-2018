using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p11.Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            string projectionType = Console.ReadLine().ToLower();

            int rows = int.Parse(Console.ReadLine());
            int colums = int.Parse(Console.ReadLine());

            double ticketPrice = 0;

            switch (projectionType)
            {
                case "normal":
                    ticketPrice = 7.50;
                    break;
                case "premiere":
                    ticketPrice = 12.00;
                    break;
                case "discount":
                    ticketPrice = 5.00;
                    break;
                
            }

            double profit = (colums * rows) * ticketPrice;

            Console.WriteLine($"{profit:F2} leva");
        }
    }
}
