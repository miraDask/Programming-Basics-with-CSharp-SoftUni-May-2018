using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p07.Christmas_Tree
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

         //   string firstLine = new string(' ', n + 1) + '|';

         //   Console.WriteLine(firstLine);

            for (int row = 0; row <= n; row++)
            {
                string middLines = new string(' ', n - row) + new string('*', row) + " | " + new string('*', row)  ;
                Console.WriteLine(middLines);
            }
        }
    }
}
