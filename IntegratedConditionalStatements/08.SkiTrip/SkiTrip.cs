using System;

namespace _08.SkiTrip
{
    class SkiTrip
    {
        static void Main(string[] args)
        {
            int roomNights = int.Parse(Console.ReadLine());
            string roomType = Console.ReadLine();
            string evaluation = Console.ReadLine();
            double price = 0;
            roomNights -= 1;

            if (roomType == "room for one person")
            {
                price = 18 * roomNights;

            }
            else if (roomType == "apartment")
            {
                if (roomNights < 10)
                {
                    price = (25 * roomNights) * 0.7;
                    
                }
                else if (roomNights >= 10 && roomNights <=15)
                {
                    price = (25 * roomNights) * 0.65;
                }
                else if (roomNights > 15)
                {
                    price = (25 * roomNights) * 0.5;
                }
            }
            else if (roomType == "president apartment")
            {
                if (roomNights < 10)
                {
                    price = (35 * roomNights) * 0.9;
                }
                else if (roomNights >= 10 && roomNights <= 15)
                {
                    price = (35 * roomNights) * 0.85;
                }
                else if (roomNights > 15)
                {
                    price = (35 * roomNights) * 0.8;
                }
            }
            

            if (evaluation == "positive")
            {
                Console.WriteLine($"{price +=(price* 0.25):F2}");
            }
            else if (evaluation == "negative")
            {
                Console.WriteLine($"{price -= (price * 0.1):F2}");
            }

        }
    }
}
