using System;

namespace _04.RepeatAString
{
    class Program
    {
        static void Main(string[] args)
        {
            string stringToBeRepeated = Console.ReadLine();
            int numberOfTimesToRepeatIt = int.Parse(Console.ReadLine());
            RepeatAStringNumberOfTime(stringToBeRepeated, numberOfTimesToRepeatIt);
        }

        static string RepeatAStringNumberOfTime(string SomethingToRepeat, int TimesToRepeatIt)
        {
            for (int i = 0; i < TimesToRepeatIt; i++)
            {
                Console.Write(SomethingToRepeat);
            }
            return SomethingToRepeat;
        }
    }
}
