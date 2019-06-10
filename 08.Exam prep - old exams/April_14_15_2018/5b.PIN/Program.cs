using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5b.PIN
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int width = 6 * n + 10;
            int height = 2 * n + 2;
            int space = 2 * n;

            if (n > 1 && n <= 20)
            {
                Console.WriteLine("/`" + new string('P', 2 * n) + new string(' ', n) + "/`I" + new string(' ', n) + "/`N" + new string(' ', 2 * n + 1)
                                        + 'N');


                for (int row = 0; row < height - 1; row++)
                {
                    if (row == n - 1)
                    {
                        Console.WriteLine("| " + new string('P', 2 * n) + new string(' ', n) + "| I" + new string(' ', n) + "| N" + new string(' ', row)
                            + 'N' + new string(' ', space) + 'N');

                        space--;
                    }
                    else if (row == height - 2)
                    {
                        
                            Console.WriteLine("\\_" + new string('P', n / 2) + new string(' ', 2 * n - n / 2 + n) + "\\_I" + new string(' ', n) + "\\_N" + new string(' ', row)
                            + 'N' + new string(' ', space) + 'N');
                        
                    }
                    else if (row > n - 1)
                    {
                        
                            Console.WriteLine("| " + new string('P', n / 2) + new string(' ', 2 * n - n / 2 + n) + "| I" + new string(' ', n) + "| N" + new string(' ', row)
                            + 'N' + new string(' ', space) + 'N');
                            space--;

                        

                    }
                    else
                    {
                        Console.WriteLine("| P" + new string(' ', 2 * n - 2) + 'P' + new string(' ', n) + "| I" + new string(' ', n) + "| N" + new string(' ', row)
                                                + 'N' + new string(' ', space) + 'N');
                        space--;
                    }
                }
            }

            
        }
    }
}
