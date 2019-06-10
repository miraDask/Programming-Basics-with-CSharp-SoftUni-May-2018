using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p13.Point_In_The_Figure
{
    class Program
    {
        static void Main(string[] args)
        {
            int h = int.Parse(Console.ReadLine());
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());

            int x1 = h;
            int x2 = 2 * h;
            int x3 = 0;
            int x4 = 3 * h;
            int y1 = h;
            int y2 = 4 * h;
            int y3 = 0;
            int y4 = h;

            bool inside = (x > x1 && x < x2 && y > y1 && y < y2) || (x > x3 && x < x4 && y > y3 && y < y4)
                    || (x > x1 && x < x2 && y == y4);
            bool border = (x == x1 && y >= y1 && y <= y2) || (y == y2 && x >= x1 && x <= x2)
                    || (x == x2 && y >= y1 && y <= y2) || (y == y4 && x >= x2 && x <= x4)
                    || (x == x4 && y >= y3 && y <= y4) || (y == y3 && x >= x3 && x <= x4)
                    || (x == x3 && y >= y3 && y <= y4) || (y == y4 && x >= x3 && x <= x1);
            if (inside)
            {
                Console.WriteLine("inside");
            }
            else if (border)
            {
                Console.WriteLine("border");
            }
            else
            {
                Console.WriteLine("outside");
            }
        }
    }
}
