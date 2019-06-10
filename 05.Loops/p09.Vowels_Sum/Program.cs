using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p09.Vowels_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            
            int vowelsSum = 0;

            for (int i = 0; i < word.Length; i++)
            {
                char currentChar = word[i];

                switch (currentChar)
                {
                    case 'a':
                        vowelsSum += 1;
                        break;
                    case 'e':
                        vowelsSum += 2;
                        break;
                    case 'i':
                        vowelsSum += 3;
                        break;
                    case 'o':
                        vowelsSum += 4;
                        break;
                    case 'u':
                        vowelsSum += 5;
                        break;
                 
                }
            }
            Console.WriteLine(vowelsSum);
        }
    }
}
