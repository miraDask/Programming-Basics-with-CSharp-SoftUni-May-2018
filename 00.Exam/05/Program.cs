using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int width = (4 * n) + 11;

            int leftRight = (width - (2 * n + 3)) / 2;

            Console.WriteLine(new string('.', (width - (2 * n + 3))/2)+ new string('_',n) + "/|\\" + new string('_', n) + new string('.', (width - (2 * n + 3)) / 2));

            for (int i = 1; i <= 5; i++)
            {
                if (i == 1)
                {
                    Console.WriteLine(new string('.',leftRight) + '/' + new string('-',width - (2 * leftRight + 2)) + '\\' + new string('.', leftRight));
                }
                else if (i == 5)
                {
                    Console.WriteLine(new string('.', leftRight) + '/' + new string('_', width - (2 * leftRight + 2)) + '\\' + new string('.', leftRight));
                }
                else
                {
                    Console.WriteLine(new string('.', leftRight) + '/' + new string('.', width - (2 * leftRight + 2)) + '\\' + new string('.', leftRight));
                }
                
                leftRight--;
            }

            for (int i = 1; i <= n; i++)
            {
                if (i == n  || i == n - 1 )
                {
                    Console.WriteLine(new string('.', leftRight) + '/' + new string('_', width - (2 * leftRight + 2)) + '\\' + new string('.', leftRight));
                }
                else
                {
                    Console.WriteLine(new string('.', leftRight) + '/' + new string('.', width - (2 * leftRight + 2)) + '\\' + new string('.', leftRight));
                }
                leftRight--;
            }

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(new string('.', (width - 3)/2) + "|$|" + new string('.', (width - 3) / 2));
            }

            Console.WriteLine("...." + new string('_',(width - 11) / 2) + "|$|" + new string('_', (width - 11) / 2) + "....");
            Console.WriteLine(".../" + new string('_',(width - 8)) + "\\...");
        }
    }
}
