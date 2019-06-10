using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {

            
                Console.Write("Enter score: ");
                double score = double.Parse(Console.ReadLine());
                double bonus = 0;

                if (score <= 100)
                {
                    bonus += 5;
                }
                else if (score > 1000)
                {
                    bonus += (score * (1.0 / 10));
                }
                else
                {
                    bonus = (score * (2.0 / 10));
                }

                if (score % 2 == 0)
                {
                    bonus += 1;
                }
                if (score % 10 == 5)
                {
                    bonus += 2;
                }

                Console.WriteLine("Bonus score: " + bonus);
                Console.WriteLine("Total score: " + (score + bonus));
            }
        }
    }

    

