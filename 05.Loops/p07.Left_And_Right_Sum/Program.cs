using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p07.Left_And_Right_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            int leftSum = 0;
            int rightSum = 0;

            for (int i = 1; i <= 2 * num; i++)
            {
                int currentNum = int.Parse(Console.ReadLine());

                if (i <= num)
                {
                    leftSum += currentNum;
                }
                if (i > num)
                {
                    rightSum += currentNum;
                }

            }

            int diff = Math.Abs(leftSum - rightSum);

            if (diff > 0)
            {
                Console.WriteLine($"No, diff = {diff}");
            }
            else
            {
                Console.WriteLine($"Yes, sum = {leftSum}");
            }
        }
    }
}
