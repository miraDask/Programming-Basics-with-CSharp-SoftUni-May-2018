using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p11.Enter_Even_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;

            Console.WriteLine("Enter even number: ");
            n = int.Parse(Console.ReadLine());

            try
            {
                while (n % 2 != 0)
                {
                    Console.WriteLine("The number is not even.");
                    Console.WriteLine("Enter even number: ");
                    n = int.Parse(Console.ReadLine());
                }
                Console.WriteLine("Even number entered: " + n);
            }
            catch (Exception e)
            {
                Console.WriteLine("Invalid number!");
            }
        }
    }
}
