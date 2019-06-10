using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.AluminiumJoinery
{
    class Program
    {
        static void Main(string[] args)
        {
            int quantity = int.Parse(Console.ReadLine());
            string type = Console.ReadLine();
            string delivery = Console.ReadLine();

            int price = 0;        
            int deliveryPrice = 0;
            double discount = 0;


            if (quantity >= 10)
            {



                if (type == "90X130")
                {
                    price = 110;

                    if (quantity > 30 && quantity <= 60)
                    {
                        discount = 0.05;
                    }
                    else if (quantity > 60)
                    {
                        discount = 0.08;
                    }
                }
                else if (type == "100X150")
                {
                    price = 140;

                    if (quantity > 40 && quantity <= 80)
                    {
                        discount = 0.06;
                    }
                    else if (quantity > 80)
                    {
                        discount = 0.10;
                    }

                }
                else if (type == "130X180")
                {
                    price = 190;

                    if (quantity > 20 && quantity <= 50)
                    {
                        discount = 0.07;
                    }
                    else if (quantity > 50)
                    {
                        discount = 0.12;
                    }

                }
                else if (type == "200X300")
                {

                    price = 250;

                    if (quantity > 25 && quantity <= 50)
                    {
                        discount = 0.09;
                    }
                    else if (quantity > 50)
                    {
                        discount = 0.14;
                    }

                }

                if (delivery == "With delivery")
                {
                    deliveryPrice = 60;
                }


                double totalPrice = deliveryPrice + ((price * quantity) * (1 - discount));    


                if (quantity > 99)
                {
                    totalPrice *= 0.96;
                }

                Console.WriteLine($"{totalPrice:F2} BGN");
            }
            else
            {
                Console.WriteLine("Invalid order");
            }
        }
    }
}
