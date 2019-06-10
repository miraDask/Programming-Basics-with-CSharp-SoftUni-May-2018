using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p16.Number_0_to_100_To_Text
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            string[] from0to19 = {"zero", "one", "two","three", "four", "five" , "six" , "seven" , "eight" ,
                "nine" , "ten" , "eleven" , "twelve", "thirteen", "fourteen", "fifteen", "sixteen",
                "seventeen", "eighteen", "nineteen" };

            string[] from20To99 = {"","","twenty", "thirty", "forty", "fifty", "sixty",
                "seventy", "eighty", "ninety", "one hundred"};


            if (num < 0 || num > 100)
            {
                Console.WriteLine("invalid number");
            }

            if (num>=0 && num <= 19)
            {
                Console.WriteLine(from0to19[num]);
            }
            else if (num > 19 && num <= 100)
            {
                int firstNum = num / 10;
                int secondNum = num % 10;

                if (secondNum == 0)
                {
                    Console.WriteLine($"{from20To99[firstNum]}");
                }
                else
                {
                    Console.WriteLine($"{from20To99[firstNum]} {from0to19[secondNum]}");
                }
                
            }
          
        }
    }
}
