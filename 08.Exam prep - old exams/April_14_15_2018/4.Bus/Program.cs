using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Bus
{
    class Program
    {
        static void Main(string[] args)
        {
            int passengers = int.Parse(Console.ReadLine());
            int stops = int.Parse(Console.ReadLine());

            int count = passengers;

            for (int i = 1; i <= stops; i++)
            {
                count -= int.Parse(Console.ReadLine());
                count += int.Parse(Console.ReadLine());

                if (i % 2 != 0)
                {
                    count += 2;
                }
                else
                {
                    count -= 2;
                }
            }

            Console.WriteLine($"The final number of passengers is : {count}");
        }
    }
}
