using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p10.Diamond
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int stars = 0;

            if (n % 2 != 0)
            {
                stars = 1;
            }
            else
            {
                stars = 2;
            }

            int leftRightPart = (n - stars) / 2;

           // int midPart = n - (2 * leftRightPart + 2);

            for (int row = 1; row <= (n + 1) / 2; row++)
            {
                if (row == 1)
                {
                    string line = new string('-', leftRightPart) + new string('*',stars) +  new string('-', leftRightPart);
                    Console.WriteLine(line);
                    leftRightPart--;
                }
                else
                {
                    string line = new string('-', leftRightPart) + '*' + new string('-',n - (2 * leftRightPart + 2) ) + '*' + new string('-', leftRightPart);

                    Console.WriteLine(line);
                    leftRightPart--;
                }
            }

            leftRightPart = 0;

            for (int row = 1; row <= (n - 1) / 2; row++)
            {

                leftRightPart++;

                if (row == (n - 1) / 2)
                {
                    string line = new string('-', leftRightPart) + new string('*', stars) + new string('-', leftRightPart);
                    Console.WriteLine(line);
                }
                else
                {
                    string line = new string('-', leftRightPart) + '*' + new string('-', n - (2 * leftRightPart + 2)) + '*' + new string('-', leftRightPart);

                    Console.WriteLine(line);
                }
            }

        }
    }
}
