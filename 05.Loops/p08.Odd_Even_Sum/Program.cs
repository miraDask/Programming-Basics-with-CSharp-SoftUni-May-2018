using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p08.Odd_Even_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            int oddSum = 0;
            int evenSum = 0;

            for (int i = 1; i <= num; i++)
            {
                int currentNum = int.Parse(Console.ReadLine());

                if (i % 2 == 0)
                {
                    evenSum += currentNum;
                }
                else
                {
                    oddSum += currentNum;
                }
            }

            int diff = Math.Abs(oddSum - evenSum);

            if (diff > 0)
            {
                Console.WriteLine($"No Diff = {diff}");
            }
            else
            {
               Console.WriteLine($"Yes Sum = {oddSum}");
            }
            
        }
    }
}
