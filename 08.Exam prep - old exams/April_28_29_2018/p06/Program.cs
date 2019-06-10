using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p06
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int firstDigit = 1; firstDigit <= 9; firstDigit++)
            {
                for (int secondDigit = 9; secondDigit >= firstDigit; secondDigit--)
                {
                    for (int thirdDigit = 0; thirdDigit <= 9; thirdDigit++)
                    {
                        for (int lastDigit = 9; lastDigit >= thirdDigit; lastDigit--)
                        {
                            if (((firstDigit + secondDigit + thirdDigit + lastDigit) == 
                                (firstDigit * secondDigit * thirdDigit * lastDigit)) && ( n % 10 == 5))
                            {
                                Console.WriteLine($"{firstDigit}{secondDigit}{thirdDigit}{lastDigit}");
                                goto END;
                            }
                            else if (((firstDigit * secondDigit * thirdDigit * lastDigit) / (firstDigit + secondDigit + thirdDigit + lastDigit) == 3) 
                                &&( n % 3 == 0))
                            {
                                Console.WriteLine($"{lastDigit}{thirdDigit}{secondDigit}{firstDigit}");
                                goto END;
                            }
                            
                        }
                    }
                }
            }

            Console.WriteLine($"Nothing found");

            END:;
        }
    }
}
