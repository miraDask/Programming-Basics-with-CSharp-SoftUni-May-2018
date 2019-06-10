using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p10.Half_Sum_Element
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            int tempSum = 0;

            int maxNum = int.MinValue;

            for (int i = 0; i < num; i++)
            {
                int currentNum = int.Parse(Console.ReadLine());

                tempSum += currentNum;

                if (currentNum > maxNum)
                {
                    maxNum = currentNum;
                }
            }

            int sum = tempSum - maxNum;

            int diff = Math.Abs(sum - maxNum);

            if (diff > 0)
            {
                Console.WriteLine($"No Diff = {diff}");
            }
            else
            {
                Console.WriteLine($"Yes Sum = {sum}");
            }
        }
    }
}
