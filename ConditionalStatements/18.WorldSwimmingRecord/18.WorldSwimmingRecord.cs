using System;
namespace _18.WorldSwimmingRecord
{
    class WorldSwimmingRecord
    {
        static void Main()
        {
            double recordInSeconds = double.Parse(Console.ReadLine());
            double distanceInMetres = double.Parse(Console.ReadLine());
            double timeInSecondsForMeter = double.Parse(Console.ReadLine());

            double endTime = distanceInMetres * timeInSecondsForMeter;

            double delayNumbers = Math.Floor(distanceInMetres / 15);
            double delayTime = delayNumbers * 12.5;

            double finalTime = endTime + delayTime;
            double difference = Math.Abs(recordInSeconds - finalTime);

            if (finalTime < recordInSeconds)
            {
                Console.WriteLine($"Yes, he succeeded! The new world record is {finalTime:F2} seconds.");
            }
            else
            {
                Console.WriteLine($"No, he failed! He was {difference:F2} seconds slower.");
            }
        }
    }
}
