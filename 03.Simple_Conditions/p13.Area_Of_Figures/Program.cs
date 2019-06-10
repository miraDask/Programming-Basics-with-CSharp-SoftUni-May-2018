using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p13.Area_Of_Figures
{
    class Program
    {
        static void Main(string[] args)
        {
            string figure = Console.ReadLine();

            double area = 0;

            if (figure == "square")
            {
                double sideOfSquare = double.Parse(Console.ReadLine());
                area = sideOfSquare * sideOfSquare;

            }
            else if (figure == "rectangle")
            {
                double width = double.Parse(Console.ReadLine());
                double height = double.Parse(Console.ReadLine());
                area = width * height;
            }
            else if (figure == "circle")
            {
                double r = double.Parse(Console.ReadLine());
                area = Math.PI * r * r;
            }
            else if (figure == "triangle")
            {
                double widthOfTriangle = double.Parse(Console.ReadLine());
                double heightOfTriangle = double.Parse(Console.ReadLine());
                area = (widthOfTriangle * heightOfTriangle) / 2;
            }

            Console.WriteLine("{0:F3}",area);
        }
    }
}
