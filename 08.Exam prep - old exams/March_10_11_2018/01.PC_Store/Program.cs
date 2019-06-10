using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.PC_Store
{
    class Program
    {
        static void Main(string[] args)
        {
            double cpuPrice = double.Parse(Console.ReadLine());
            double videoCardPrice = double.Parse(Console.ReadLine());
            double ramPrice = double.Parse(Console.ReadLine());
            int ram = int.Parse(Console.ReadLine());
            double discount = double.Parse(Console.ReadLine());

            cpuPrice *= 1.57;
            videoCardPrice *= 1.57;
            ramPrice *= 1.57;

            double cost = (ram * ramPrice) + (cpuPrice - (cpuPrice * discount)) + (videoCardPrice - (videoCardPrice * discount));

            Console.WriteLine($"Money needed - {cost:F2} leva.");
        }
    }
}
