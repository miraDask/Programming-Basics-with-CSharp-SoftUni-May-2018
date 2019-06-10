using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05p.TriangleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstTriangleSide = int.Parse(Console.ReadLine());
            int secondTriangleSide = int.Parse(Console.ReadLine());

            int area = firstTriangleSide * secondTriangleSide;
            Console.WriteLine(area);
        }
    }
}
