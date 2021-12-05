using System;
namespace _13.SumSeconds
{
    class SumSeconds
    {
        static void Main()
        {
            int firstRacerSeconds = int.Parse(Console.ReadLine());
            int secondRacerSeconds = int.Parse(Console.ReadLine());
            int thirdRacerSeconds = int.Parse(Console.ReadLine());

            double allRacerSeconds = firstRacerSeconds + secondRacerSeconds + thirdRacerSeconds;

            double minutes = Math.Floor(allRacerSeconds / 60);

            double seconds = Math.Floor(allRacerSeconds % 60);

            if (seconds < 10)
            {
                Console.WriteLine($"{minutes}:0{seconds}");
            }
            else
            {
                Console.WriteLine($"{minutes}:{seconds}");
            }
        }
    }
}