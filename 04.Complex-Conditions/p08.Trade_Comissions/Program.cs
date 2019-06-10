using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p08.Trade_Comissions
{
    class Program
    {
        static void Main(string[] args)
        {
            string town = Console.ReadLine().ToLower();

            double salesVolume = double.Parse(Console.ReadLine());

            double commission = 0;
            switch (town)
            {
                case "sofia":    //Sofia	5%	7%	8%	12%

                    if (salesVolume >= 0 && salesVolume <= 500)
                    {
                        commission = 0.05;
                    }
                    else if (salesVolume > 500 && salesVolume <= 1000)
                    {
                        commission = 0.07;
                    }
                    else if (salesVolume > 1000 && salesVolume <= 10000)
                    {
                        commission = 0.08;
                    }
                    else if (salesVolume > 10000)
                    {
                        commission = 0.12;
                    }

                    break;
                case "varna":      //Varna	4.5%	7.5%	10%	13%

                    if (salesVolume >= 0 && salesVolume <= 500)
                    {
                        commission = 0.045;
                    }
                    else if (salesVolume > 500 && salesVolume <= 1000)
                    {
                        commission = 0.075;
                    }
                    else if (salesVolume > 1000 && salesVolume <= 10000)
                    {
                        commission = 0.10;
                    }
                    else if (salesVolume > 10000)
                    {
                        commission = 0.13;
                    }

                    break;

                case "plovdiv":      //Plovdiv	5.5%	8%	12%	14.5%

                    if (salesVolume >= 0 && salesVolume <= 500)
                    {
                        commission = 0.055;
                    }
                    else if (salesVolume > 500 && salesVolume <= 1000)
                    {
                        commission = 0.08;
                    }
                    else if (salesVolume > 1000 && salesVolume <= 10000)
                    {
                        commission = 0.12;
                    }
                    else if (salesVolume > 10000)
                    {
                        commission = 0.145;
                    }

                    break;
                
            }

            if (commission == 0)
            {
                Console.WriteLine("error");
            }
            else
            {
                Console.WriteLine($"{(salesVolume * commission):F2}");
            }
        }
    }
}
