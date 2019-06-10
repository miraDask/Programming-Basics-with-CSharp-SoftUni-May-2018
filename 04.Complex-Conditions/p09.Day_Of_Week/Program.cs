using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p09.Day_Of_Week
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            string[] dayOfWeek = { "Error", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
            if (num < 1 || num > 7)
            {
                Console.WriteLine("Error");
            }
            else
            {
                Console.WriteLine(dayOfWeek[num]);
            }
            
        }
    }
}
