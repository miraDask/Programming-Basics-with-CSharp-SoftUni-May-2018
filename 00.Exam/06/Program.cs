using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstEnd = int.Parse(Console.ReadLine());
            int secondEnd = int.Parse(Console.ReadLine());
            int thirdEnd = int.Parse(Console.ReadLine());
            int lastEnd = int.Parse(Console.ReadLine());

            int profit = 0;
            int threeEqualCount = 0;
            int fourEqualCount = 0;

            for (int first = 0; first <= firstEnd; first++)
            {
                for (int second = 0; second <= secondEnd; second++)
                {
                    for (int third = 0; third <= thirdEnd; third++)
                    {
                        for (int last = 0; last <= lastEnd; last++)
                        {
                            Console.WriteLine($"{first}{second}{third}{last}");

                            
                            if ((first == second && first == third && first!=last) || (first!=second && second == third && second == last))
                            {
                                profit += 100;
                                threeEqualCount++;
                            }
                            else  if (first == second && first == third && first == last)
                            {
                                profit += 1000;
                                fourEqualCount++;
                            }
                            else
                            {
                                profit += 20;
                               
                                
                            }
                        }
                    }
                }
            }
            Console.WriteLine($"Final sum: {profit}lv.");
            Console.WriteLine($"Car numbers with 3 equal digits: {threeEqualCount}");
            Console.WriteLine($"Car numbers with 4 equal digits: {fourEqualCount}");
        }
    }
}
