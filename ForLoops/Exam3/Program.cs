using System;

namespace Exam3
{
    class Program
    {
        static void Main(string[] args)
        {

            string sushiType = Console.ReadLine();
            string restraurantName = Console.ReadLine();
            int howMany = int.Parse(Console.ReadLine());
            char homeOrNot = char.Parse(Console.ReadLine());
            double price = 0;
            double discount = 0;
            double endPrice = 0;

            if (!(restraurantName == "Sushi Zone" || restraurantName == "Sushi Time" || restraurantName == "Sushi Bar" || restraurantName == "Asian Pub")) 
            {
                Console.WriteLine($"{restraurantName} is invalid restaurant!");
            }

            else if (restraurantName == "Sushi Zone")
            {
                if (sushiType == "sashimi")
                {
                    price = 4.99;
                }
                else if (sushiType == "maki")
                {
                    price = 5.29;
                }
                else if (sushiType == "uramaki")
                {
                    price = 5.99;
                }
                else if (sushiType == "temaki")
                {
                    price = 4.29;
                }
            }
            else if (restraurantName == "Sushi Time")
            {
                if (sushiType == "sashimi")
                {
                    price = 5.49;
                }
                else if (sushiType == "maki")
                {
                    price = 4.69;
                }
                else if (sushiType == "uramaki")
                {
                    price = 4.49;
                }
                else if (sushiType == "temaki")
                {
                    price = 5.19;
                }
            }
            else if (restraurantName == "Sushi Bar")
            {
                if (sushiType == "sashimi")
                {
                    price = 5.29;
                }
                else if (sushiType == "maki")
                {
                    price = 5.55;
                }
                else if (sushiType == "uramaki")
                {
                    price = 6.25;
                }
                else if (sushiType == "temaki")
                {
                    price = 4.75;
                }
            }
            else if (restraurantName == "Asian Pub")
            {
                if (sushiType == "sashimi")
                {
                    price = 4.50;
                }
                else if (sushiType == "maki")
                {
                    price = 4.80;
                }
                else if (sushiType == "uramaki")
                {
                    price = 5.50;
                }
                else if (sushiType == "temaki")
                {
                    price = 5.50;
                }
            }

            if (homeOrNot == 'Y')
            {
                discount = price * 0.2;
                price += discount;

            }

            endPrice = Math.Ceiling(price * howMany);


            if (restraurantName == "Sushi Zone" || restraurantName == "Sushi Time" || restraurantName == "Sushi Bar" || restraurantName == "Asian Pub")
            {
                Console.WriteLine($"Total price: {endPrice} lv.");
            }
            
        }
    }
}
