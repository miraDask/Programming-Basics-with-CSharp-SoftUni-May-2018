using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04
{
    class Program
    {
        static void Main(string[] args)
        {
            int coursesNum = int.Parse(Console.ReadLine());
            double payment = double.Parse(Console.ReadLine()); // per km

            int coutFrance = 0;
            int coutBelgium = 0;
            int coutSweden = 0;
            int totalKm = 0;
            double finalPayment = payment;
            
            

            for (int i = 1; i <= coursesNum; i++)
            {
                string country = Console.ReadLine();

                    if (country == "France")
                    {
                        coutFrance++;
                        totalKm += 1884;
                        
                    }
                    else if (country == "Belgium")
                    {
                        coutBelgium++;
                        totalKm += 1815;
                    
                    }
                    else if (country == "Sweden")
                    {
                        coutSweden++;
                        totalKm += 1991;
                   
                    }

                if (i % 2 == 0)
                {
                    finalPayment = finalPayment * 1.2;
                  
                }
              
            }

             double salary = totalKm * finalPayment;

            Console.WriteLine($"Courses to France: {coutFrance}");
            Console.WriteLine($"Courses to Belgium: {coutBelgium}");
            Console.WriteLine($"Courses to Sweden: {coutSweden}");
            Console.WriteLine($"Total: {totalKm} km");
            Console.WriteLine($"Salary: {salary:F2} lv.");
        }
    }
}
