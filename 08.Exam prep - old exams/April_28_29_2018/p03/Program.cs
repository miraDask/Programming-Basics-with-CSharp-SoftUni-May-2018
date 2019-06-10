using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p03
{
    class Program
    {
        static void Main(string[] args)
        {
            int onlineCount = 0;
            int onsiteCount = 0;
            int placesLeft = 600;

            for (int i = 0; i < 3; i++)
            {
                string course = Console.ReadLine();
                int students = int.Parse(Console.ReadLine());

                if (course == "online")
                {
                    onlineCount += students;
                }
                else if (course == "onsite")
                {

                    if (students <= placesLeft)
                    {
                        placesLeft -= students;
                        onsiteCount += students;
                    }
                    else
                    {
                        onlineCount += students - placesLeft;
                        placesLeft -= placesLeft;
                        onsiteCount = 600;
                    }
                }
            }

            Console.WriteLine($"Online students: {onlineCount}");
            Console.WriteLine($"Onsite students: {onsiteCount}");
            Console.WriteLine($"Total students: {onlineCount + onsiteCount}");
        }
    }
}
