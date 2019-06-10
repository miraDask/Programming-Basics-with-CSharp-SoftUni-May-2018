using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Skyscraper
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n - 2; i++)
            {
                if (i == n - 2)
                {
                    Console.WriteLine(new string(' ', n - 1) + "_|_");
                }
                else
                {
                    Console.WriteLine(new string(' ', n) + '|');
                }
            }
            for (int i = 1; i <= n - 2; i++)
            {
                if (i == n - 2)
                {
                    Console.WriteLine(new string(' ', n - 2) + "_|-|_");
                }
                else
                {
                    Console.WriteLine(new string(' ', n - 1) + "|-|");
                }
            }

            for (int i = 1; i <= n - 2; i++)
            {
                if (i == n - 2)
                {
                    Console.WriteLine(' ' + new string('_', n - 3) + "|***|" + new string('_', n - 3));
                }
                else
                {
                    Console.WriteLine(new string(' ', n - 2) + "|***|");
                }
            }

            for (int i = 1; i <= 4 * n; i++)
            {
                if (i == 4 * n)
                {
                    Console.WriteLine('_' + new string('|', n - 2) + "---" + new string('|', n - 2) + '_');
                }
                else
                {
                    Console.WriteLine(' ' + new string('|', n - 2) + "---" + new string('|', n - 2));
                }
            }

            for (int i = 1; i <= n - 2; i++)
            {
                Console.WriteLine(new string('|',2 * n + 1));
            }
        }
    }
}
