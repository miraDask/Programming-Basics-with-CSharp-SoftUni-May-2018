﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p11.USD_to_BGN
{
    class Program
    {
        static void Main(string[] args)
        {

            double usd = double.Parse(Console.ReadLine());

            double levs = usd * 1.79549;

            Console.WriteLine("{0:f2} BGN", levs);
        }
    }
}
