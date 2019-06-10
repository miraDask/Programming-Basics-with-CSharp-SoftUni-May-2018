using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2a.AND_Processors
{
    class Program
    {
        static void Main(string[] args)
        {
            int processors = int.Parse(Console.ReadLine());
            int workers = int.Parse(Console.ReadLine());
            int workDays = int.Parse(Console.ReadLine());

            int workHours = workers * workDays * 8;
            double production = Math.Floor(workHours / 3.0);

            double diff = Math.Abs(production - processors);

            if (production < processors)
            {
                Console.WriteLine("Losses: -> {0:F2} BGN",diff * 110.10);
            }
            else
            {
                Console.WriteLine("Profit: -> {0:F2} BGN", diff * 110.10);
            }
        }
    }
}
