using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p04.Fruit_Or_Vegetable
{
    class Program
    {
        static void Main(string[] args)
        {
            string productName = Console.ReadLine();

            bool fruit = productName == "banana" || productName =="apple"|| productName == "kiwi"
                    || productName =="cherry" || productName == "lemon" || productName == "grapes";

            bool vegetable = productName =="tomato" || productName == "cucumber" || productName == "pepper" || productName == "carrot";
            if (fruit)
            {
                Console.WriteLine("fruit");
            }
            else if (vegetable)
            {
                Console.WriteLine("vegetable");

            }
            else
            {
                Console.WriteLine("unknown");
            }
        }
    }
}
