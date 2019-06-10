using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Cake
{
    class Program
    {
        static void Main(string[] args)
        {
            int cakeWidth = int.Parse(Console.ReadLine());
            int cakeLenght = int.Parse(Console.ReadLine());

            int piecesLeft = cakeLenght * cakeWidth;
            bool noMoreCake = false;
            

            while (true)
            {
                string current = Console.ReadLine();
                if (current == "STOP")
                {                   
                    break;
                }
                else
                {
                    int pieces = int.Parse(current);
                    piecesLeft -= pieces;

                    if (piecesLeft < 0)
                    {
                        noMoreCake = true;

                        Console.WriteLine($"No more cake left! You need {Math.Abs(piecesLeft)} pieces more.");
                        break;
                    }
                }

               
            }

            if (noMoreCake == false)
            {
                Console.WriteLine($"{piecesLeft} pieces are left.");
            }
        }
    }
}
