using System;

namespace _03.Vacation
{
    class Program
    {
        static void Main(string[] args)
        {

            int peopleCount = int.Parse(Console.ReadLine());
            string groupType = Console.ReadLine();
            string day = Console.ReadLine();
            decimal price = 0;
            decimal totalPrice = 0;

            if (groupType == "Students")
            {
                if (day == "Friday")
                {
                    price = 8.45m;
                }
                else if (day == "Saturday")
                {
                    price = 9.80m;
                }
                else if (day == "Sunday")
                {
                    price = 10.46m;
                }
            }
            else if (groupType == "Business")
            {
                if (day == "Friday")
                {
                    price = 10.90m;
                }
                else if (day == "Saturday")
                {
                    price = 15.60m;
                }
                else if (day == "Sunday")
                {
                    price = 16m;
                }
            }
            else if (groupType == "Regular")
            {
                if (day == "Friday")
                {
                    price = 15m;
                }
                else if (day == "Saturday")
                {
                    price = 20m;
                }
                else if (day == "Sunday")
                {
                    price = 22.50m;
                }
            }

            totalPrice = peopleCount * price;

            if (peopleCount >= 30 && groupType == "Students")
            {
                totalPrice *= 0.85M;
            }
            else if (groupType == "Business" && peopleCount >= 100)
            {
                totalPrice -= price * 10;
            }
            else if (groupType == "Regular" && peopleCount >= 10 && peopleCount <= 20)
            {
                totalPrice *= 0.95m;
            }

            Console.WriteLine($"Total price: {totalPrice:F2}");



        }
    }
}
