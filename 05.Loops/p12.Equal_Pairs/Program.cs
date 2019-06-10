using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p12.Equal_Pairs
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            int maxDiff = 0;
            int firstSum = 0;
            int lastSum = 0;
            int diff = 0;

            for (int i = 0; i < num * 2; i+=2)
            {
                int firstNum = int.Parse(Console.ReadLine());
                int secondtNum = int.Parse(Console.ReadLine());
                if (i <= 1)
                {
                    firstSum = firstNum + secondtNum;
                }
                else
                {


                    lastSum = firstNum + secondtNum;

                    diff = Math.Abs(firstSum - lastSum);

                    if (diff > maxDiff)
                    {
                        maxDiff = diff;
                    }

                    firstSum = lastSum;
                }
            }

            if (num == 1)
            {
                Console.WriteLine($"Yes, value={firstSum}");
            }
            else if(maxDiff == 0)
            {
                Console.WriteLine($"Yes, value={lastSum}");
            }
            else
            {
                Console.WriteLine($"No, maxdiff={maxDiff}");   
            }
        }
    }
}
