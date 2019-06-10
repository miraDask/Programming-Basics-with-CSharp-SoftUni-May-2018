using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p07.Fruit_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            string fruit = Console.ReadLine().ToLower();
            string dayOfWeek = Console.ReadLine().ToLower();
            double quantity = double.Parse(Console.ReadLine());

            double price = 0;

            switch (fruit)
            {
                case ("banana"):
                    if (dayOfWeek == "monday" || dayOfWeek == "tuesday" || dayOfWeek == "wednesday" || dayOfWeek == "thursday" || dayOfWeek == "friday")
                    {
                        price = 2.50;
                      
                    }
                    else if (dayOfWeek == "saturday" || dayOfWeek == "sunday")
                    {
                        price = 2.70;
                       
                    }
                    
                    break;

                case ("apple"):
                    if (dayOfWeek == "monday" || dayOfWeek == "tuesday" || dayOfWeek == "wednesday" || dayOfWeek == "thursday" || dayOfWeek == "friday")
                    {
                        price = 1.20;
                      
                    }
                    else if (dayOfWeek == "saturday" || dayOfWeek == "sunday")
                    {
                        price = 1.25;
                        
                    }
                    
                    break;

                case ("orange"):
                    if (dayOfWeek == "monday" || dayOfWeek == "tuesday" || dayOfWeek == "wednesday" || dayOfWeek == "thursday" || dayOfWeek == "friday")
                    {
                        price = 0.85;
                        
                    }
                    else if (dayOfWeek == "saturday" || dayOfWeek == "sunday")
                    {
                        price = 0.90;
                       
                    }
                   
                    break;

                case ("grapefruit"):
                    if (dayOfWeek == "monday" || dayOfWeek == "tuesday" || dayOfWeek == "wednesday" || dayOfWeek == "thursday" || dayOfWeek == "friday")
                    {
                        price = 1.45;
                        
                    }
                    else if (dayOfWeek == "saturday" || dayOfWeek == "sunday")
                    {
                        price = 1.60;
                        
                    }
                    
                    break;

                case ("kiwi"):
                    if (dayOfWeek == "monday" || dayOfWeek == "tuesday" || dayOfWeek == "wednesday" || dayOfWeek == "thursday" || dayOfWeek == "friday")
                    {
                        price = 2.70;
                        
                    }
                    else if (dayOfWeek == "saturday" || dayOfWeek == "sunday")
                    {
                        price = 3.00;
                        
                    }
                    break;

                case ("pineapple"):
                    if (dayOfWeek == "monday" || dayOfWeek == "tuesday" || dayOfWeek == "wednesday" || dayOfWeek == "thursday" || dayOfWeek == "friday")
                    {
                        price = 5.50;
                       
                    }
                    else if (dayOfWeek == "saturday" || dayOfWeek == "sunday")
                    {
                        price = 5.60;
                        
                    }
                    break;

                case ("grapes"):
                    if (dayOfWeek == "monday" || dayOfWeek == "tuesday" || dayOfWeek == "wednesday" || dayOfWeek == "thursday" || dayOfWeek == "friday")
                    {
                        price = 3.85;
                       
                    }
                    else if (dayOfWeek == "saturday" || dayOfWeek == "sunday")
                    {
                        price = 4.20;
                        
                    }
                   
                    break;

            }
            if (price == 0)
            {
               Console.WriteLine("error");
            }
            else
            {
               Console.WriteLine("{0:F2}", price * quantity);
            }
            
        }
    }
}
