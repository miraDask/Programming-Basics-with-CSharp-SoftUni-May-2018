using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04p.TriangleOf55Stars
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 10; i++)
            {
                for (int y = 0; y < i; y++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();

            }
        }
    }
}
