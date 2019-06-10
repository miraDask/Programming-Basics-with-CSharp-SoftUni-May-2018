using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06a.Coins
{
    class Program
    {
        static void Main(string[] args)
        {
            double n = double.Parse(Console.ReadLine());

            int change = (int)(n * 100);

            int first = change / 100;
            int sec = (change / 10)% 10;
            int third = change % 10;
        }
    }
}
