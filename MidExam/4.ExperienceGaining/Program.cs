using System;

namespace _4.ExperienceGaining
{
    class Program
    {
        static void Main(string[] args)
        {

            double experienceNeeded = int.Parse(Console.ReadLine());
            double battleCount = int.Parse(Console.ReadLine());
            double gainedExp = 0;
            double bonusExp = 0;
            double finalExpAfterTheBattle = 0;

            for (int i = 1; i <= battleCount; i++)
            {
                gainedExp = double.Parse(Console.ReadLine());

                if (i % 3 == 0)
                {
                    bonusExp = gainedExp * 0.15;
                    gainedExp += bonusExp;
                }
                else if (i % 5 == 0)
                {
                    bonusExp = gainedExp * 0.10;
                    gainedExp -= bonusExp;
                }

                finalExpAfterTheBattle += gainedExp;
                if (finalExpAfterTheBattle >= experienceNeeded)
                {
                    Console.WriteLine($"Player successfully collected his needed experience for {i} battles.");
                    break;
                }
                if (finalExpAfterTheBattle < experienceNeeded && i == battleCount)
                {
                    experienceNeeded -= finalExpAfterTheBattle;
                    Console.WriteLine($"Player was not able to collect the needed experience, {experienceNeeded:F2} more needed.");
                    break;
                }
            }

        }
    }
}
