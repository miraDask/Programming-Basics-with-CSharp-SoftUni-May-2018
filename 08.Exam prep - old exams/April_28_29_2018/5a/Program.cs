using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5a
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());

            int width = 2 * n + 6;

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(new string('-', (width - 2) / 2) + "**" + new string('-', (width - 2) / 2));
            }
            for (int i = 0; i < n - 3; i++)
            {
                Console.WriteLine(new string('-', (width - 4) / 2) + "****" + new string('-', (width - 4) / 2));
            }
            Console.WriteLine(new string('-', (width - 6) / 2) + "******" + new string('-', (width - 6) / 2));

            for (int i = 0; i < n - 4; i++)
            {
                Console.WriteLine(new string('-', (width - 6) / 2) + "**--**" + new string('-', (width - 6) / 2));

            }
            for (int i = 0; i < n - 3; i++)
            {
                Console.WriteLine(new string('-', (width - 8) / 2) + "**----**" + new string('-', (width - 8) / 2));

            }
            Console.WriteLine(new string('-', (width - 10) / 2) + "**********" + new string('-', (width - 10) / 2));

                int leftRight = (width - 12) / 2;
                int inner = 8;

            for (int i = 0; i < n - 3; i++)
            {
                
                Console.WriteLine(new string('-', leftRight) + "**" + new string('-',inner) +"**" + new string('-',leftRight));
                leftRight--;
                inner+= 2;

            }

            Console.WriteLine( "***" + new string('-',width - 6) + "***");
        }
    }
}
