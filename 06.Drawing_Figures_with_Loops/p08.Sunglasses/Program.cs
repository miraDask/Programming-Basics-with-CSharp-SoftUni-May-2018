using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p08.Sunglasses
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            

            for (int row = 1; row <= n; row++)
            {
                
                if (row == 1 || row == n)
                {
                   string  line = new string('*', 2 * n) + new string(' ', n) + new string('*', 2 * n);
                    Console.WriteLine(line);
                }
                else if (row == (n + 1) / 2)
                {
                    string line ='*' +  new string('/', 2 * n - 2 ) + '*' + new string('|', n) + '*' + new string('/', 2 * n - 2) + '*';
                    Console.WriteLine(line);
                }
                else
                {
                     string line = '*' + new string('/', 2 * n - 2) + '*' + new string(' ', n) + '*' + new string('/', 2 * n - 2) + '*';
                    Console.WriteLine(line);
                }

                
            }
        }
    }
}
