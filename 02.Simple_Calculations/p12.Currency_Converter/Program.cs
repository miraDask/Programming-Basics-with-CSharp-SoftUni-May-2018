using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p12.Currency_Converter
{
    class Program
    {
        static void Main(string[] args)
        {
            double sum = double.Parse(Console.ReadLine());
            string inputCurrency = Console.ReadLine();
            string outputCurrency = Console.ReadLine();

            double currencyOut = 0;

            switch (inputCurrency)
            {
                case "BGN":
                    if (outputCurrency == "USD")
                    {
                        currencyOut = sum / 1.79549;
                    }
                    else if (outputCurrency == "EUR")
                    {
                        currencyOut = sum / 1.95583;
                    }
                    else if (outputCurrency == "GBP")
                    {
                        currencyOut = sum / 2.53405;
                    }

                    break;
                case "USD":
                    if (outputCurrency == "BGN")
                    {
                        currencyOut = sum * 1.79549;
                    }
                    else if (outputCurrency == "EUR")
                    {
                        currencyOut = (sum * 1.79549) / 1.95583;
                    }
                    else if (outputCurrency == "GBP")
                    {
                        currencyOut = (sum * 1.79549) / 2.53405;
                    }

                    break;
                case "EUR":
                    if (outputCurrency == "BGN")
                    {
                        currencyOut = sum * 1.95583;
                    }
                    else if (outputCurrency == "USD")
                    {
                        currencyOut = (sum * 1.95583) / 1.79549;
                    }
                    else if (outputCurrency == "GBP")
                    {
                        currencyOut = (sum * 1.95583) / 2.53405;
                    }

                    break;
                case "GBP":
                    if (outputCurrency == "BGN")
                    {
                        currencyOut = sum * 2.53405;
                    }
                    else if (outputCurrency == "USD")
                    {
                        currencyOut = (sum * 2.53405) / 1.79549;
                    }
                    else if (outputCurrency == "EUR")
                    {
                        currencyOut = (sum * 2.53405) / 1.95583;
                    }

                    break;
            }


            Console.WriteLine($"{currencyOut:f2} {outputCurrency}");
        }
    }
}
