using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03
{
    class Program
    {
        static void Main(string[] args)
        {
            string pizzaKind = Console.ReadLine();
            string pizzaSize = Console.ReadLine();
            string sauce = Console.ReadLine();
            int numOfPizzas = int.Parse(Console.ReadLine());

            double pizzaCost = 0;

            switch (pizzaKind)
            {
                case "with meat":
                    if (pizzaSize == "small")
                    {
                        pizzaCost += 7.50;
                      
                    }
                    else if (pizzaSize == "big")
                    {
                        pizzaCost += 11;
                    }
                    break;
                case "vegetarian":
                    if (pizzaSize == "small")
                    {
                        pizzaCost += 5.50;

                    }
                    else if (pizzaSize == "big")
                    {
                        pizzaCost += 7.20;
                    }
                    break;
                case "vegan":
                    if (pizzaSize == "small")
                    {
                        pizzaCost += 3.90;

                    }
                    else if (pizzaSize == "big")
                    {
                        pizzaCost += 5.45;
                    }
                    break;
                default:
                    break;
            }

            if (sauce == "tomato")
            {
                pizzaCost += 1.50;
            }
            else if (sauce == "garlic")
            {
                pizzaCost += 1.70;
            }
            else if (sauce == "special")
            {
                pizzaCost += 2.50;
            }

            double price = pizzaCost * numOfPizzas;
            Console.WriteLine($"{price:F2}lv.");
        }
    }
}
