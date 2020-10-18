using System;

namespace CharityCampaign
{
    class Program
    {
        static void Main(string[] args)
        {

            int days = int.Parse(Console.ReadLine());
            int cakeGuys = int.Parse(Console.ReadLine());

            int cakes = int.Parse(Console.ReadLine());
            int gofreti = int.Parse(Console.ReadLine());
            int pencakes = int.Parse(Console.ReadLine());

            double wholeCakes = cakes * cakeGuys;
            double wholeGofreti = gofreti * cakeGuys;
            double wholePencakes = pencakes * cakeGuys;

            wholeCakes = wholeCakes * 45;
            wholeGofreti = wholeGofreti * 5.80;
            wholePencakes = wholePencakes * 3.20;

            double sum = (wholePencakes + wholeGofreti + wholeCakes) * days;
            double expenses = sum / 8;

            double achievedValue = sum - expenses;

            Console.WriteLine($"{achievedValue:F2}");

        }
    }
}
