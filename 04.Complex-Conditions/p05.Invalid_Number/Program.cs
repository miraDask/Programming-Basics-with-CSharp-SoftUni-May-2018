using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p05.Invalid_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            bool valid = (num >= 100 && num <= 200) || num == 0;

            if (!valid)
            {
                Console.WriteLine("invalid");
            }
        }
    }
}
