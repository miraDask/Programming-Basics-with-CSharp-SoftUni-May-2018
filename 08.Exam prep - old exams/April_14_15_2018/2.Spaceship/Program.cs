using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Spaceship
{
    class Program
    {
        static void Main(string[] args)
        {
            double widthOfSpaceship = double.Parse(Console.ReadLine());
            double lengthOfSpaceship = double.Parse(Console.ReadLine());
            double heightOfSpaceship = double.Parse(Console.ReadLine());
            double heightOfAstronauts = double.Parse(Console.ReadLine());

            double spaceshipVolume = widthOfSpaceship * lengthOfSpaceship * heightOfSpaceship;
            double roomVolume = (heightOfAstronauts + 0.40) * 2 * 2;

            double astronoutsNum = Math.Floor(spaceshipVolume / roomVolume);
            if (astronoutsNum < 3)
            {
                Console.WriteLine("The spacecraft is too small.");
            }
            else if ( astronoutsNum <= 10)
            {
                Console.WriteLine($"The spacecraft holds {astronoutsNum} astronauts.");
            }
            else
            {
                Console.WriteLine("The spacecraft is too big.");
            }
        }
    }
}
