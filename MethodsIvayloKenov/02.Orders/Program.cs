using System;

namespace _02.Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            int count = int.Parse(Console.ReadLine());
            CalculateFinalPrice(product, count);
        }

        static double CalculateFinalPrice(string product, int count)
        {
            double price = 0.00;
            double result = 0.00;
            if (product == "coffee")
            {
                price = 1.50;
                result = price * count;
                Console.WriteLine($"{result:F2}");
            }
            else if (product == "water")
            {
                price = 1.00;
                result = price * count;
                Console.WriteLine($"{result:F2}");
            }
            else if (product == "coke")
            {
                price = 1.40;
                result = price * count;
                Console.WriteLine($"{result:F2}");
            }
            else if (product == "snacks")
            {
                price = 2.00;
                result = price * count;
                Console.WriteLine($"{result:F2}");
            }

            return result;
        }


    }
}
