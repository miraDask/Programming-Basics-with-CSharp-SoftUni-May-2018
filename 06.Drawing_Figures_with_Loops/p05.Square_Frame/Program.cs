using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p05.Square_Frame
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                if (i == 1 || i == n)
                {
                    Console.Write("+ ");
                    for (int j = 0; j < n - 2 ; j++)
                    {
                        Console.Write("- ");
                    }
                    Console.WriteLine("+");
                }
                else
                {
                    Console.Write("| ");
                    for (int j = 0; j < n - 2; j++)
                    {
                        Console.Write("- ");
                    }
                    Console.WriteLine("|");
                }
            }
            

            
        }
    }
}
