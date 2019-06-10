using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p13.Number_Pyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            String space = " ";
            int currentN = 0;
            for (int i = 1; i <= n; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    ++currentN;
                    Console.Write(currentN + space);

                    if (currentN == n)
                    {
                        break;
                    }
                }

                Console.WriteLine();

                if (currentN == n)
                {
                    break;
                }
            }
        }
    }
}
