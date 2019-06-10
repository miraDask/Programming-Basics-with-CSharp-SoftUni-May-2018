using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Letters_Combinations
{
    class Program
    {
        static void Main(string[] args)
        {
            char start = char.Parse(Console.ReadLine());
            char stop = char.Parse(Console.ReadLine());
            char exeption = char.Parse(Console.ReadLine());

            int count = 0;

            for (char first = start; first <= stop; first++)
            {
                for (char second = start; second <= stop; second++)
                {
                    for (char third = start; third <= stop; third++)
                    {
                        if (first != exeption && second != exeption && third != exeption)
                        {
                            Console.Write($"{first}{second}{third} ");
                            count++;
                        }
                    }
                }
            }

            Console.WriteLine(count);
        }
    }
}
