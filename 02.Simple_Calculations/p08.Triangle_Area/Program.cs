using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p08.Triangle_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            double triangleSide = double.Parse(Console.ReadLine());
            double triangleHeight = double.Parse(Console.ReadLine());

            double area = (triangleSide * triangleHeight) / 2 ;

            Console.WriteLine("Triangle area = " + Math.Round(area,2));
        }
    }
}
