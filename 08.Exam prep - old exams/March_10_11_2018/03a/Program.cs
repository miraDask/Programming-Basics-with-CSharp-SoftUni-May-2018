using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03a
{
    class Program
    {
        static void Main(string[] args)
        {
            string gender = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            int experience = int.Parse(Console.ReadLine());

            int retirementAge = 0;
            int neededExp = 0;

            switch (gender)
            {
                case "female":

                    retirementAge = 61;
                    neededExp = 35;

                    if (age >= retirementAge && experience >= neededExp)
                    {
                        Console.WriteLine($"Ready to retire at {age} and {experience} years of experience!");
                    }
                    else if (age >= retirementAge && experience < neededExp)
                    {
                        Console.WriteLine($"Old enough, but haven't worked enough. Work experience left to retirement: {neededExp - experience}.");
                    }
                    else if (age < retirementAge && experience >= neededExp)
                    {
                        Console.WriteLine($"Worked enough, but not old enough. Years left to retirement: {retirementAge - age}.");
                    }
                    else if (age < retirementAge && experience < neededExp)
                    {
                        Console.WriteLine($"Too early. Years left to retirement: {retirementAge - age}. Work experience left to retirement: {neededExp - experience}.");
                    }

                    break;

                case "male":

                    retirementAge = 64;
                    neededExp = 38;

                    if (age >= retirementAge && experience >= neededExp)
                    {
                        Console.WriteLine($"Ready to retire at {age} and {experience} years of experience!");
                    }
                    else if (age >= retirementAge && experience < neededExp)
                    {
                        Console.WriteLine($"Old enough, but haven't worked enough. Work experience left to retirement: {neededExp - experience}.");
                    }
                    else if (age < retirementAge && experience >= neededExp)
                    {
                        Console.WriteLine($"Worked enough, but not old enough. Years left to retirement: {retirementAge - age}.");
                    }
                    else if (age < retirementAge && experience < neededExp)
                    {
                        Console.WriteLine($"Too early. Years left to retirement: {retirementAge - age}. Work experience left to retirement: {neededExp - experience}.");
                    }
                    break;

                default:
                    Console.WriteLine("Invalid input.");
                    break;
                  
            }

        }
    }
}
