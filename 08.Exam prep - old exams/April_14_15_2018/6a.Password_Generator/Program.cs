using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6a.Password_Generator
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstInput = int.Parse(Console.ReadLine());
            char secondInput = char.Parse(Console.ReadLine());
            char thirdInput = char.Parse(Console.ReadLine());
            int fourthInput = int.Parse(Console.ReadLine());
            int fifthInput = int.Parse(Console.ReadLine());
            int sixthInput = int.Parse(Console.ReadLine());
            int seventhInput = int.Parse(Console.ReadLine());

            secondInput = Char.ToUpper(secondInput);
            thirdInput = Char.ToLower(thirdInput);
            int count = 0;
            string combination = " ";

            for (int firstDigit = 1; firstDigit <= firstInput; firstDigit++)
            {
             

                for (char secondDigit = 'A'; secondDigit <= secondInput; secondDigit++)
                {
                 

                    for (char thirdDigit = 'a'; thirdDigit <= thirdInput; thirdDigit++)
                    {
                     

                        for (int fourthDigit = 1; fourthDigit <= fourthInput; fourthDigit++)
                        {
                          

                            for (int fifthDigit = 1; fifthDigit <= fifthInput; fifthDigit++)
                            {
                             
                                for (int sixthDigit = 1; sixthDigit <= sixthInput; sixthDigit++)
                                {
                                    count++;

                                    if (seventhInput == count)
                                    {
                                        Console.WriteLine($"{firstDigit}{secondDigit}{thirdDigit}{fourthDigit}{fifthDigit}{sixthDigit}");
                                        goto END;
                                    }
                                    
                                }
                            }
                        }
                    }

                }
            }

             Console.WriteLine($"No password on this position");

            END:;
            
        }
    }
}
