using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5a.Marguerita
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int width = 8 * n + 2;
            int leftSide = 0;
            

            for (int row = 1; row <= n; row++)
            {
                if (row == 1)
                {
                    Console.WriteLine(new string('\'',row) + "&$" + new string('\'', width - 3));
                }
                else
                {
                    Console.WriteLine(new string('\'', row) + '\\' + new string('\'', width - (row + 1) ));
                }
            }

            for (int i = 0; i < width / 2 - 1 ; i++)
            {
                Console.Write("^*");
            }
            Console.WriteLine("^\'");

            for (int row = 1; row <= n; row++)
            {
                if (row == n)
                {
                    Console.WriteLine(new string('\'', leftSide) + '\\' + new string('~', width - (2 * leftSide + 3)) + '/' + new string('\'', leftSide + 1));
                    leftSide++;
                }
                else
                {
                    
                    Console.WriteLine(new string('\'', leftSide) + @"\\" + new string(' ', n) + '\\' + new string(' ', width - (2 * leftSide + n + 6)) + "//" + new string('\'', leftSide + 1));
                    leftSide++;
                    
                }
            }

            for (int row = 1; row <= n; row++)
            {
                if (row == n - 1)
                {

                    Console.WriteLine(new string('\'', leftSide) + '\\' + new string('_', width - (2 * leftSide + 3)) + '/' + new string('\'', leftSide + 1));
                    leftSide++;
                }
                else if (row == n)
                {
                    Console.WriteLine(new string('\'', leftSide) + '\\' + new string('.', width - (2 * leftSide + 3)) + '/' + new string('\'', leftSide + 1));
                    leftSide++;
                }
                else
                {
                    Console.WriteLine(new string('\'', leftSide) + '\\' + new string(' ', width - (2 * leftSide + 3)) + '/' + new string('\'', leftSide + 1));
                    leftSide++;
                }
            }

            for (int row = 1; row <= 2 * n - 1; row++)
            {
                if (row == 2 * n - 1)
                {
                    Console.WriteLine(new string('\'', leftSide) + '\\' + new string('_', width - (2 * leftSide + 3)) + '/' + new string('\'', leftSide + 1));
                    leftSide++;
                }
                else
                {
                    Console.WriteLine(new string('\'', leftSide) + '\\' + new string(' ', width - (2 * leftSide + 3)) + '/' + new string('\'', leftSide + 1));
                    leftSide++;

                }
            }

            for (int row = 0; row < 2 * n + 1; row++)
            {
                Console.WriteLine(new string('\'', leftSide) + "|||"+ new string('\'', leftSide + 1));
            }

            Console.WriteLine(new string('_',width - 1) + '\'');
            Console.WriteLine('\'' + new string('-',width - 3) + "\''");
        }
    }
}
