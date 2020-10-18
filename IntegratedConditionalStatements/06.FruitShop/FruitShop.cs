using System;

namespace _06.FruitShop
{
    class FruitShop
    {
        static void Main(string[] args)
        {
            string fruit = Console.ReadLine();
            string dayOfWeek = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());

            if (dayOfWeek == "Monday" || dayOfWeek == "Tuesday" || dayOfWeek == "Wednesday" || dayOfWeek == "Thursday" 
                || dayOfWeek == "Friday")
            {
                if (fruit == "banana")
                {

                    Console.WriteLine($"{quantity *= 2.50:F2}");
                }
                if (fruit == "apple")
                {
                    Console.WriteLine($"{quantity *= 1.20:F2}");
                }
                if (fruit == "orange")
                {
                    Console.WriteLine($"{quantity *= 0.85:F2}");
                }
                if (fruit == "grapefruit")
                {
                    Console.WriteLine($"{quantity *= 1.45:F2}");
                }
                if (fruit == "kiwi")
                {
                    Console.WriteLine($"{quantity *= 2.70:F2}");
                }
                if (fruit == "pineapple")
                {
                    Console.WriteLine($"{quantity *= 5.50:F2}");
                }
                if (fruit == "grapes")
                {
                    Console.WriteLine($"{quantity *= 3.85:F2}");
                }
                else if (!(fruit == "grapes" || fruit == "pineapple" || fruit == "kiwi" || fruit == "grapefruit" || fruit == "orange"
                    || fruit == "banana" || fruit == "apple"))
                {
                    Console.WriteLine("error");
                }
            }
            else if (dayOfWeek == "Saturday" || dayOfWeek == "Sunday")
            {
                if (fruit == "banana")
                {
                    Console.WriteLine($"{quantity *= 2.70:F2}");
                }
                if (fruit == "apple")
                {
                    Console.WriteLine($"{quantity *= 1.25:F2}");
                }
                if (fruit == "orange")
                {
                    Console.WriteLine($"{quantity *= 0.90:F2}");
                }
                if (fruit == "grapefruit")
                {
                    Console.WriteLine($"{quantity *= 1.60:F2}");
                }
                if (fruit == "kiwi")
                {
                    Console.WriteLine($"{quantity *= 3.00:F2}");
                }
                if (fruit == "pineapple")
                {
                    Console.WriteLine($"{quantity *= 5.60:F2}");
                }
                if (fruit == "grapes")
                {
                    Console.WriteLine($"{quantity *= 4.20:F2}");
                    
                }
                else if (!(fruit == "grapes" || fruit == "pineapple" || fruit == "kiwi" || fruit == "grapefruit" || fruit == "orange"
                    || fruit == "banana" || fruit == "apple"))
                {
                    Console.WriteLine("error");
                }
            }
            else if (!(dayOfWeek == "Monday" || dayOfWeek == "Tuesday" || dayOfWeek == "Wednesday" || dayOfWeek == "Thursday"
                || dayOfWeek == "Friday" || dayOfWeek == "Saturday" || dayOfWeek == "Sunday"))
            {
                Console.WriteLine("error");
            }
        }
    }
}
