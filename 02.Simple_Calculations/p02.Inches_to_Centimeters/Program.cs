﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p02.Inches_to_Centimeters
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("inches = ");
            double inches = double.Parse(Console.ReadLine());

            double centimeters = inches * 2.54;

            Console.WriteLine("centimeters = " + centimeters);

        }
    }
}
