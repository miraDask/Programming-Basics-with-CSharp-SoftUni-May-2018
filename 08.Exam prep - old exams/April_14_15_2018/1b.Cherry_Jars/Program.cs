using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1b.Cherry_Jars
{
    class Program
    {
        static void Main(string[] args)
        {
            int compote = int.Parse(Console.ReadLine());
            int jam = int.Parse(Console.ReadLine());

            int compoteJarsNeeded = compote + 1;
            int jamJarsNeeded = jam + 1;

            double cherriesForCompote = (compoteJarsNeeded * 0.300) * 1.05;
            double cherriesForJam = (jamJarsNeeded * 0.650 ) * 1.10;

            double totalCherriesPrice = (cherriesForCompote + cherriesForJam) * 3.2;

            Console.WriteLine("{0:F2}",totalCherriesPrice);
        }
    }
}
