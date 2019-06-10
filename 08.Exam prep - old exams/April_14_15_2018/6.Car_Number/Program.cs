using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.Car_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int startNum = int.Parse(Console.ReadLine());
            int stopNum = int.Parse(Console.ReadLine());

            for (int first = startNum; first <= stopNum; first++)
            {
                for (int second = startNum; second <= stopNum; second++)
                {
                    for (int third = startNum; third <= stopNum; third++)
                    {
                        for (int last = startNum; last <= stopNum; last++)
                        {
                            if (first > last)
                            {
                                if ((first % 2 == 0 && last % 2 != 0)||(first % 2 != 0 && last % 2 == 0))
                                {
                                    if ((second + third) % 2 == 0)
                                    {
                                        Console.Write($"{first}{second}{third}{last} ");
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
