using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p06.Min_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            int minNum = int.MaxValue;

            for (int i = 0; i < num; i++)
            {
                int currentNum = int.Parse(Console.ReadLine());

                if (currentNum < minNum)
                {
                    minNum = currentNum;
                }
            }
            Console.WriteLine(minNum);
        }
    }
}
