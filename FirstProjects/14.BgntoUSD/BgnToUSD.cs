using System;
namespace _14.BgntoUSD
{
    class BgntoUSD
    {
        static void Main()
        {
            double usd = double.Parse(Console.ReadLine());
            double bgn = Math.Round(usd * 1.79549, 2);

            Console.WriteLine(bgn);
        }
    }
}