using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p08.Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            int factorial = 1;

            while (num >= 1)
            {
                factorial *= num;
                num--;
            }
            Console.WriteLine(factorial);
        }
    }
}
