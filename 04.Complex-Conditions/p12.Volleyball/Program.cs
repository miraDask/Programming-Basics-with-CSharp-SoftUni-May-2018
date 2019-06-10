using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p12.Volleyball
{
    class Program
    {
        static void Main(string[] args)
        {
            string year = Console.ReadLine(); // leap or normal
            double p = double.Parse(Console.ReadLine()); // number of holidays in the year
            double h = double.Parse(Console.ReadLine()); // number of weekends outside Sofia

            double weekendsInSofia = (48 - h) * 3.0 / 4; // number of saturdays he played
            double allWeekendsPlay = weekendsInSofia + h;
            double holidaysPlay = p * 2.0 / 3;
            double allDaysPlay = allWeekendsPlay + holidaysPlay;

            if (year == "normal")
            {
                Console.WriteLine("{0}", Math.Floor(allDaysPlay));
            }
            else if (year == "leap")
            {
                double allDaysPlay2 = Math.Floor(allDaysPlay + (allDaysPlay * 0.15));
                Console.WriteLine("{0}", allDaysPlay2);
            }
        }
    }
}
