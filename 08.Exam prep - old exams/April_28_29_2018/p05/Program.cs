using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p05
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int width = 2 * n;
            int stars = width - 4;

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine(new string(' ', width - 2 * i ) + new string('*', 2 * i));
            }

            Console.WriteLine(new string('*', width - 2) + "  ");

            for (int i = 1; i <= 3; i++)
            {
                Console.WriteLine(new string('*', stars) );
                stars += 2;
            }

            Console.WriteLine("  " + new string('*', width - 2));
            Console.WriteLine("    " + new string('*', width - 4));
            Console.WriteLine("  " + new string('*', width - 2));

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(new string('*', stars - 2));
                stars -= 2;
            }

        }
    }
}
