using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p02
{
    class Program
    {
        static void Main(string[] args)
        {
            char gender = char.Parse(Console.ReadLine());
            double weight = double.Parse(Console.ReadLine());  //kg
            double height = double.Parse(Console.ReadLine());  //m      - transfer it in cm
            int age = int.Parse(Console.ReadLine());
            string lifestyle = Console.ReadLine();

            double blm = 0;
            double coeff = 0;
            

            switch (gender)
            {
                case 'm':
                    blm = 66 + (13.7 * weight) + (5 * (height * 100)) - (6.8 * age);
                    break;
                case 'f':
                    blm = 655 + (9.6 * weight) + (1.8 * (height * 100)) - (4.7 * age);

                    break;
               
            }

            switch (lifestyle)
            {
                case "sedentary":
                    coeff = 1.2;
                    break;

                case "lightly active":
                    coeff = 1.375;
                    break;

                case "moderately active":
                    coeff = 1.55;
                    break;
                case "very active":
                    coeff = 1.725;
                    break;

            }

            double callories = blm * coeff;

            Console.WriteLine($"To maintain your current weight you will need {Math.Ceiling(callories)} calories per day.");


        }
    }
}
