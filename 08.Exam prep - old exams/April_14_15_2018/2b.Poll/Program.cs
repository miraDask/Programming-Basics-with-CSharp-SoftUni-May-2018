using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2b.Poll
{
    class Program
    {
        static void Main(string[] args)
        {
            int participants = int.Parse(Console.ReadLine());
            int firstLangVoters = int.Parse(Console.ReadLine());

            double secondLangVoters = firstLangVoters * 0.80;
            double thirdLangVoters = secondLangVoters * 0.90;

            double halfOfVoted = (participants / 2);
            double voters  = (firstLangVoters + secondLangVoters + thirdLangVoters); // voted for the tree languages 
            double diff = Math.Floor(voters - halfOfVoted);
            

            if (diff >= 0)
            {
                Console.WriteLine($"First three languages have {diff} votes more");
            }
            else
            {
                Console.WriteLine($"First three languages have {Math.Abs(diff)} votes less of half votes");
            }
        }
    }
}
