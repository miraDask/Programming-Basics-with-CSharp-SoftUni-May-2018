using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02a
{
    class Program
    {
        static void Main(string[] args)
        {
            int holeWidth = int.Parse(Console.ReadLine());
            int holeLenght = int.Parse(Console.ReadLine());
            int pictureSide = int.Parse(Console.ReadLine());
            int pictureNum = int.Parse(Console.ReadLine());

            int holeArea = holeLenght * holeWidth;
            int picturesArea = (pictureSide * pictureSide) * pictureNum;

            if (holeArea >= picturesArea)
            {
                Console.WriteLine($"The pictures fit in the hole. Hole area is {holeArea - picturesArea} bigger than pictures area.");
            }
            else
            {
                Console.WriteLine($"The pictures don't fit in the hole. Picture area is {picturesArea - holeArea} bigger than hole area.");
            }
        }
    }
}
