using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3a.Solar_System
{
    class Program
    {
        static void Main(string[] args)
        {
            string planet = Console.ReadLine();
            int days = int.Parse(Console.ReadLine());

            double distance = 0;
           // double totalDays = 226 * distance + days;
            switch (planet)
            {
                case "Mercury":
                    if (days <= 7)
                    {
                        distance = 2 * 0.61;
                        
                    }                 
                  
                    break;

                case "Venus":
                    if (days <= 14)
                    {
                        distance = 2 * 0.28;

                    }
                    
                    break;

                case "Mars":
                    if (days <= 20)
                    {
                        distance = 2 * 0.52;

                    }
                    
                    break;

                case "Jupiter":
                    if (days <= 5)
                    {
                        distance = 2 * 4.2;

                    }
                    
                    break;

                case "Saturn":
                    if (days <= 3)
                    {
                        distance = 2 * 8.52;

                    }
                    
                    break;

                case "Uranus":
                    if (days <= 3)
                    {
                        distance = 2 * 18.21;

                    }
                    
                    break;

                case "Neptune":
                    if (days <= 2)
                    {
                        distance = 2 * 29.09;

                    }
                    
                    break;

                default:
                    Console.WriteLine("Invalid planet name!");
                     return;
                    
                    
            }

            if (distance == 0)
            {
                Console.WriteLine("Invalid number of days!");
            }
            else
            {
            Console.WriteLine($"Distance: {distance:F2}");
            Console.WriteLine("Total number of days: {0:F2}", 226 * distance + days);
            }

        }
    }
}
