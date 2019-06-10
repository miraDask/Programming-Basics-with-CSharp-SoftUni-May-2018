using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p01
{
    class Program
    {
        static void Main(string[] args)
        {
            double pagePrice = double.Parse(Console.ReadLine());
            double coverPrice = double.Parse(Console.ReadLine());   // one cover
            int discount = int.Parse(Console.ReadLine());     //percentige
            double disignPrice = double.Parse(Console.ReadLine());
            int paidFromTeem = int.Parse(Console.ReadLine());  //percentige

            double priceOfBook = (pagePrice * 899) + (coverPrice * 2);
            double discountedPrice = priceOfBook * (1 - (double)discount / 100);
            double finalePrice = (discountedPrice + disignPrice) * (1 - (double)paidFromTeem / 100);

            Console.WriteLine($"Avtonom should pay {finalePrice:F2} BGN.");

        }
    }
}
