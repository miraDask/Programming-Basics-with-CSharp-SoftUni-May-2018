using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4a.Moving
{
    class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int length = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());

            int result = 0;
            int num;
            string input = "";

            while (input != "Done")
            {
                 input = Console.ReadLine();

                bool isNum = int.TryParse(input,out num);

                if (isNum)
                {
                    result += num;
                    if (((width * length * height) - result) < 0)
                    {
                        Console.WriteLine($"No more free space! You need {Math.Abs(((width * length * height) - result))} Cubic meters more.");
                        break;
                    }
                }
                else
                {
            Console.WriteLine($"{((width * length * height) - result)} Cubic meters left.");
                    break;
                }
             
                 
            }

        }
    }
}