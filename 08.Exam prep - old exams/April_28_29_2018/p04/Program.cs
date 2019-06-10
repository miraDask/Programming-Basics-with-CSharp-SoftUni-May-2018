using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p04
{
    class Program
    {
        static void Main(string[] args)
        {
            int cources = int.Parse(Console.ReadLine());
            int grade; int credits;
            double gradeCount = 0;
            double creditsSum = 0;

            for (int i = 0; i < cources; i++)
            {
                int summery = int.Parse(Console.ReadLine());

                grade = summery % 10;
                credits = summery / 10;

                gradeCount += grade;

                switch (grade)
                {
                    case 2:
                        creditsSum += 0.0 / 100 * credits;
                        break;
                    case 3:
                        creditsSum += 50.0 / 100 * credits;
                        break;
                    case 4:
                        creditsSum += 70.0 / 100 * credits;
                        break;
                    case 5:
                        creditsSum += 85.0 / 100 * credits;
                        break;
                    case 6:
                        creditsSum +=  credits;
                        break;
                }

            }
            Console.WriteLine($"{creditsSum:F2}");
            Console.WriteLine($"{(gradeCount / cources):F2}");
        }
    }
}
