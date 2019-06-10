using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p01.SquareArea
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("a = ");
            int sideOfSquare =int.Parse(Console.ReadLine()) ;

            int area = sideOfSquare * sideOfSquare;
            Console.WriteLine("Square = " + area);
        }
    }
}
