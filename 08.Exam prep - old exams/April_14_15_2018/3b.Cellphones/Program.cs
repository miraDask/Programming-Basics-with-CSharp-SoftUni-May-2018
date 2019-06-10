using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3b.Cellphones
{
    class Program
    {
        static void Main(string[] args)
        {
            int budget = int.Parse(Console.ReadLine());
            int cellphones = int.Parse(Console.ReadLine());
            string brand = Console.ReadLine();

            double discount = 0;
            double price = 0;

            if (cellphones > 10 && cellphones <= 20)
            {
                discount += 2;
            }
            else if (cellphones > 20 && cellphones <=50)
            {
                discount += 5;
            }
            else if (cellphones > 50)
            {
                discount += 7;
            }

            if (brand == "Gsm4e")
            {
                discount += 1;
                price = 20.50;
            }
            else if (brand == "Mobifon4e")
            {
                discount += 2;
                price = 50.75;
            }
            else if (brand == "Telefon4e")
            {
                discount += 3;
                price = 115;
            }

            double totalPrice = (price * cellphones) * (1 - (discount/100));

            double diff = budget - totalPrice;

            if (budget > totalPrice)
            {
                Console.WriteLine($"The company bought all mobile phones. {diff:F2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money for all mobiles. Company needs {Math.Abs(diff):F2} more leva.");
            }
        }
    }
}
