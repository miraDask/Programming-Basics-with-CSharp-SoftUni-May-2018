using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06a
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstEnd = int.Parse(Console.ReadLine());
            int secondEnd = int.Parse(Console.ReadLine());
            int thirdEnd = int.Parse(Console.ReadLine());


            for (int first = 2; first <= firstEnd; first++)
            {
                for (int second = 2; second <= secondEnd; second++)
                {
                    for (int third = 2; third <= thirdEnd; third++)
                    {
                        if(first % 2 == 0 && third % 2 == 0)
                        {
                            if (second == 2 || second == 3 || second == 5 || second == 7)
                            {
                                Console.WriteLine($"{first} {second} {third}");
                            }
                        }
                    }
                }
            }
        }
    }
}
