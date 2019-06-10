using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p14.Time_plus_15_Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());

            int allInMinutes = (hours * 60) + minutes + 15;

            int newHours = allInMinutes / 60;
            int newMinutes = allInMinutes % 60;

            if (newHours > 23)
            {
                newHours = 0;
            }
            if (newMinutes < 10)
            {
                Console.WriteLine($"{newHours}:0{newMinutes}");
            }
            

            else
            {
                Console.WriteLine($"{newHours}:{newMinutes}");
            }
        }
    }
}
