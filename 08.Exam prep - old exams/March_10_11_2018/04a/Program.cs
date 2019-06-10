using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04a
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            int totalPoints = 0;
            int red = 0;
            int orange = 0;
            int yellow = 0;
            int white = 0;
            int other = 0;
            int black = 0;


            for (int i = 0; i < num; i++)
            {
                string color = Console.ReadLine();

                switch (color)
                {
                    case "red":
                        totalPoints += 5;
                        red++;
                        break;
                    case "orange":
                        totalPoints += 10;
                        orange++;
                        break;
                    case "yellow":
                        totalPoints += 15;
                        yellow++;
                        break;
                    case "white":
                        totalPoints += 20;
                        white++;
                        break;
                    case "black":
                        totalPoints /= 2;
                        black++;
                        break;


                    default:
                        other++;
                        break;
                }

            }

            Console.WriteLine($"Total points: {totalPoints}");
            Console.WriteLine($"Points from red balls: {red}");
            Console.WriteLine($"Points from orange balls: {orange}");
            Console.WriteLine($"Points from yellow balls: {yellow}");
            Console.WriteLine($"Points from white balls: {white}");
            Console.WriteLine($"Other colors picked: {other}");
            Console.WriteLine($"Divides from black balls: {black}");
        }
    }
}
