﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p04.Triangle_Of_Dollars
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int rows = 1; rows <= n; rows++)
            {
                for (int col = 0; col < rows; col++)
                {
                    Console.Write("$ ");
                }
                    Console.WriteLine();

            }
        }
    }
}
