using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6a
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstStart = int.Parse(Console.ReadLine());
            char secondStart = char.Parse(Console.ReadLine());
            char thirdStart = char.Parse(Console.ReadLine());
            char fourthStart = char.Parse(Console.ReadLine());
            int fifthStart = int.Parse(Console.ReadLine());
            int stop = int.Parse(Console.ReadLine());

            int count = 0;

            for (int first = firstStart; first <= 99; first++)
            {
                for (char second = secondStart; second <= 'Z'; second++)
                {
                    for (char third = thirdStart; third <= 'z'; third++)
                    {
                        for (char fourth = fourthStart; fourth <= 'Z'; fourth++)
                        {
                            for (int fifth = fifthStart; fifth >= 10; fifth--)
                            {
                                if (first % 10 == 2 && fifth % 10 == 5)
                                {
                                    count++;
                                    if (count == stop)
                                    {
                                        Console.WriteLine($"{first}{second}{third}{fourth}{fifth}");
                                        break;
                                    }

                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
