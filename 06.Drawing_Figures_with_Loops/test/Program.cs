using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            // string repeated = new String('+', 3).Replace("+", "Hello, ");

            string firstRow = "+ " + new string(' ', n - 2).Replace(" ", "- ") + "+";
            string middRow = "| " + new string(' ', n - 2).Replace(" ", "- ") + "|";

            Console.WriteLine(firstRow);

            for (int row = 0; row < n - 2; row++)
            {
                Console.WriteLine(middRow);
            }

            Console.WriteLine(firstRow);

        }
    }
}
