using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p11.Odd_Or_Even_Position
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            double oddSum = 0;
            double evenSum = 0;

            double oddMin = double.MaxValue;
            double oddMax = double.MinValue;

            double evenMin = double.MaxValue;
            double evenMax = double.MinValue;

            for (int i = 1; i <= num; i++)
            {
                double currentNum = double.Parse(Console.ReadLine());

                if (i % 2 != 0)
                {
                    oddSum += currentNum;
                    if (currentNum > oddMax)
                    {
                        oddMax = currentNum;
                    }
                    if (currentNum < oddMin) 
                    {
                        oddMin = currentNum;
                    }
                }

                else
                {
                    evenSum += currentNum;
                    if (currentNum > evenMax)
                    {
                        evenMax = currentNum;
                    }
                    if (currentNum < evenMin)
                    {
                        evenMin = currentNum;
                    }
                }

            }

            Console.WriteLine($"OddSum={oddSum},");
            if (num >= 1)
            {
                Console.WriteLine($"OddMin={oddMin},");
                Console.WriteLine($"OddMax={oddMax},");
            }
            else if (num < 1)
            {
                Console.WriteLine($"OddMin=No,");
                Console.WriteLine($"OddMax=No,");
            }

            Console.WriteLine($"EvenSum={evenSum},");

            if (num > 1)
            {
                Console.WriteLine($"EvenMin={evenMin},");
                Console.WriteLine($"EvenMax={evenMax}");
            }
            else if (num <= 1)
            {
                Console.WriteLine($"EvenMin=No,");
                Console.WriteLine($"EvenMax=No");
            }
        }
    }
}
