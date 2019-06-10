using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2a
{
    class Program
    {
        static void Main(string[] args)
        {
            int experience = int.Parse(Console.ReadLine());
            string fieldOfDevelopment = Console.ReadLine();

            double selary = 0;

            
                if (fieldOfDevelopment == "C# Developer")
                {
                    selary = 5400;
                }
                else if (fieldOfDevelopment == "Java Developer")
                {
                    selary = 5700;
                }
                else if (fieldOfDevelopment == "Front-End Web Developer")
                {
                    selary = 4100;
                }
                else if (fieldOfDevelopment == "UX / UI Designer")
                {
                    selary = 3100;
                }
                else if (fieldOfDevelopment == "Game Designer")
                {
                    selary = 3600;
                }

            if (experience > 5 )
            {
                Console.WriteLine($"Total earned money: {(selary * 12):F2} BGN");
            }
            else
            {
                selary = selary - (selary * 0.658);
                Console.WriteLine($"Total earned money: {(selary * 12):F2} BGN");
            }
            
        }
    }
}
