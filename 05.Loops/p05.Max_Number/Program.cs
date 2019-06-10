using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p05.Max_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            int maxNum = int.MinValue;

            for (int i = 0; i < num; i++)
            {
                int currentNum = int.Parse(Console.ReadLine());

                if (currentNum > maxNum)
                {
                    maxNum = currentNum;
                }
            }
            Console.WriteLine(maxNum);
        }
    }
}
