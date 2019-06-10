using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06p.SquareOfStars
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            string firstAndLastRow = new string('*', num);
            Console.WriteLine(firstAndLastRow);

            for (int i = 0; i < num - 2; i++)
            {
                string midRows = '*' + new string(' ', num - 2) + '*';
                Console.WriteLine(midRows);
            }
            Console.WriteLine(firstAndLastRow);
        }
    }
}
