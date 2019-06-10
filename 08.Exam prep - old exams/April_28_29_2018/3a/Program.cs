using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3a
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            char gender = char.Parse(Console.ReadLine());
            int age = int.Parse(Console.ReadLine());
            string sport = Console.ReadLine();

            double cost = 0;

            switch (gender)
            {
                case 'm':
                    if (sport == "Gym")
                    {
                        cost = 42;
                    }
                    else if (sport == "Boxing")
                    {
                        cost = 41;
                    }
                    else if (sport == "Yoga")
                    {
                        cost = 45;
                    }
                    else if (sport == "Zumba")
                    {
                        cost = 34;
                    }
                    else if (sport == "Dances")
                    {
                        cost = 51;
                    }
                    else if (sport == "Pilates")
                    {
                        cost = 39;
                    }

                   break;

                case 'f':
                    if (sport == "Gym")
                    {
                        cost = 35;
                    }
                    else if (sport == "Boxing")
                    {
                        cost = 37;
                    }
                    else if (sport == "Yoga")
                    {
                        cost = 42;
                    }
                    else if (sport == "Zumba")
                    {
                        cost = 31;
                    }
                    else if (sport == "Dances")
                    {
                        cost = 53;
                    }
                    else if (sport == "Pilates")
                    {
                        cost = 37;
                    }
                    break;
                
            }

            if (age <= 19)
            {
                cost = cost - (cost * 0.2);
            }

            if (budget >= cost)
            {
                Console.WriteLine($"You purchased a 1 month pass for {sport}.");
            }
            else
            {
                Console.WriteLine($"You don't have enough money! You need ${(cost - budget):F2} more.");
            }
        }
    }
}
