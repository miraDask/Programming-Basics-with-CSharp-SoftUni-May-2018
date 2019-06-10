using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p06.Rhombus_of_Stars
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            

            for (int row = 1; row <= n; row++)
            {

            string firstPart = new string(' ', n - row) + new string(' ', row).Replace(" ", "* ");

                Console.WriteLine(firstPart);
                

            }
            for (int row = n - 1; row >= 1; row--)
            {
                
                string firstPart = new string(' ', n - row) + new string(' ', row).Replace(" ", "* ");

                Console.WriteLine(firstPart);
                

            }

        }
    }
}
