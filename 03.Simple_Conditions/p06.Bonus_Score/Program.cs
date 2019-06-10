using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p06.Bonus_Score
{
    class Program
    {
        static void Main(string[] args)
        {

            int poolVolume = int.Parse(Console.ReadLine());
            int firstPipeDebit = int.Parse(Console.ReadLine());
            int secondPipeDebit = int.Parse(Console.ReadLine());
            double hours = double.Parse(Console.ReadLine());

            double bothPipes = (firstPipeDebit + secondPipeDebit) * hours;

            if (bothPipes > poolVolume)
            {
                Console.WriteLine($"For {hours} hours the pool overflows with {(bothPipes - poolVolume):F1} liters.");
            }
            else
            {
                double firstPipePercentige = Math.Floor((firstPipeDebit * hours) * 100 / bothPipes);
                double secondPipePercentige =Math.Floor((secondPipeDebit * hours) * 100 / bothPipes);
                double bothPipesPercentige =Math.Floor((bothPipes * 100) / poolVolume);
                Console.WriteLine($"The pool is {bothPipesPercentige}% full. Pipe 1: {firstPipePercentige}%. Pipe 2: {secondPipePercentige}%.");
                
            }
          
        }
    }
}
