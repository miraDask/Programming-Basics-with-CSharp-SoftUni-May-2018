using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Arrow
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int width = n + 5;

            int leftRight = (width - 1) / 2;

            Console.WriteLine(new string('_',leftRight) + '^' + new string('_', leftRight));
            Console.WriteLine(new string('_',leftRight - 1) + "/|\\" + new string('_', leftRight - 1));

            for (int i = 0; i < n / 2; i++)
            {
                Console.WriteLine(new string('_', leftRight - 2) + '/' + new string('.',i) + "|||" + new string('.', i) + '\\' + new string('_', leftRight - 2));

                leftRight -= 1;
            }

            Console.WriteLine(new string('_',(width - 9) / 2) + "/..|||..\\"  +  new string('_', (width - 9) / 2) );
            Console.WriteLine(new string('_',(width - 7) / 2) + "/.|||.\\"  +  new string('_', (width - 7) / 2) );

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(new string('_',(width - 3)/2) + "|||" + new string('_', (width - 3) / 2));
            }

            Console.WriteLine(new string('_', (width - 3) / 2) + "~~~" + new string('_', (width - 3) / 2));

            for (int i = 0; i < n / 2; i++)
            {
                Console.WriteLine(new string('_', (width - (5 + 2 * i)) / 2) + "//" + new string('.', i) + '!' +
                    new string('.', i) + "\\\\"+ new string('_', (width - (5 + 2 * i)) / 2));
            }
        }
    }
}
