using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6b.Bitcoin_Code_Generator
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstInput = int.Parse(Console.ReadLine());
            int secondInput = int.Parse(Console.ReadLine());
            int maxNum = int.Parse(Console.ReadLine());


            int firstDigit = 33;
            int secondDigit = 58;
            int thirdDigit = 1;
            int fourthDigit = 1;

            int count = 0;



            for (thirdDigit = 1; thirdDigit <= firstInput; thirdDigit++)
            {

                for (fourthDigit = 1; fourthDigit <= secondInput; fourthDigit++)
                {
                    count++;
                    if (firstDigit > 47)
                    {
                        firstDigit = 33;
                    }

                    if (secondDigit > 64)
                    {
                        secondDigit = 58;
                    }

                    if (count >= maxNum)
                    {
                        Console.Write($"{(char)firstDigit}{(char)secondDigit}{thirdDigit}{fourthDigit}{(char)secondDigit}{(char)firstDigit}|");
                        goto END;
                    }
                    else
                    {
                        Console.Write($"{(char)firstDigit}{(char)secondDigit}{thirdDigit}{fourthDigit}{(char)secondDigit}{(char)firstDigit}|");

                        firstDigit++;
                        secondDigit++;
                    }



                }

            }

            END:;
        }
    }
}
