using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Slot_Machine
{
    class Program
    {
        static void Main(string[] args)
        {
            char firstSymbol = char.Parse(Console.ReadLine());
            int firstNum = int.Parse(Console.ReadLine());
            char secondSymbol = char.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            char thirdSymbol = char.Parse(Console.ReadLine());
            int thirdNum = int.Parse(Console.ReadLine());


            int first = (int)firstSymbol + firstNum;
            int second = (int)secondSymbol + secondNum;
            int third = (int)thirdSymbol + thirdNum;

            if (first == 64 && second == 64 && third == 64)
            {
                Console.WriteLine($"{(char)first}{(char)second}{(char)third}");
                Console.WriteLine($"!!! YOU LOSE EVERYTHING !!!");
            }
            else if (first == 55 && second == 55 && third == 55)
            {
                Console.WriteLine($"{(char)first}{(char)second}{(char)third}");
                Console.WriteLine($"*** JACKPOT ***");
            }
            else
            {
                Console.WriteLine($"{(char)first}{(char)second}{(char)third}");
            }

        }
    }
}
