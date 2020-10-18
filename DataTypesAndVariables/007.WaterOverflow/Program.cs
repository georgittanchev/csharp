using System;

namespace _007.WaterOverflow
{
    class Program
    {
        static void Main(string[] args)
        {
            int waterTank = 255;
            int lines = int.Parse(Console.ReadLine());
            double litres = 0;
            double sum = 0;

            for (int i = 0; i < lines; i++)
            {
                litres = double.Parse(Console.ReadLine());
                sum += litres;

                if (sum > waterTank)
                {
                    Console.WriteLine("Insufficient capacity!");
                    sum -= litres;

                }
            }
            Console.WriteLine($"{sum}");

        }
    }
}
