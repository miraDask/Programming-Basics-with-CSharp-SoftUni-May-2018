using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05a
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int width = (2 * n) + 2;
            int space = n - 2;

            for (int i = 0; i < n - 1; i++)
            {
                Console.WriteLine(new string(' ',space) + '/' + new string(' ', i) + "|  |"
                    + new string(' ', i) + '\\' + new string(' ', space));
                space--;
            }

            Console.WriteLine(new string('-', width));
           // Console.WriteLine('|' + new string(' ', width - 2) + '|');
            Console.WriteLine('|' + new string(' ', (width - (n + 5)) / 2) + '_' + new string(' ', n + 1) + '_' +
                new string(' ', (width - (n + 5)) / 2) + '|');
            Console.WriteLine('|' + new string(' ',(width - (n + 5))/2) + '@' + new string(' ', n + 1) + '@' +
                new string(' ', (width - (n + 5) )/ 2) + '|');


            for (int i = 1; i <= n / 2; i++)
            {
                Console.WriteLine('|' + new string(' ', width - 2) + '|');
            }

           
          Console.WriteLine('|' + new string(' ', (width - 4) / 2) + "OO" + new string(' ', (width - 4) / 2) + '|');
          Console.WriteLine('|' + new string(' ', (width - 6) / 2) + "/  \\" + new string(' ', (width - 6) / 2) + '|');
          Console.WriteLine('|' + new string(' ', (width - 6) / 2) + "||||" + new string(' ', (width - 6) / 2) + '|');

            for (int i = 1; i <= n + 1; i++)
            {
                Console.WriteLine(new string('\\',i) + new string('`', width - ( 2 * i)) + new string('/', i));
            }
        }
    }
}
