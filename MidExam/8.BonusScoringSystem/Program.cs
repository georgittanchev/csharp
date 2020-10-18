using System;
using System.Linq;
using System.Collections.Generic;

namespace _8.BonusScoringSystem
{
    class BonusScoringSystem
    {
        static void Main()
        {

            double studentsCount = int.Parse(Console.ReadLine());
            double countOfTheLecture = int.Parse(Console.ReadLine());
            double additionalBonus = int.Parse(Console.ReadLine());
            double countOfTheAttendance = 0;
            double totalBonus = 0;
            double max = 0;
            double maxLectures = 0;

            for (int i = 0; i < studentsCount; i++)
            {
                countOfTheAttendance = double.Parse(Console.ReadLine());

                totalBonus = countOfTheAttendance / countOfTheLecture * (5 + additionalBonus);
                if (totalBonus > max)
                {
                    max = Math.Ceiling(totalBonus);
                    
                }
                if (countOfTheAttendance > maxLectures)
                {
                    maxLectures = countOfTheAttendance;
                }
            }

            Console.WriteLine($"Max Bonus: {max}.");
            Console.WriteLine($"The student has attended {maxLectures} lectures.");

            //{ total bonus} = { student attendances} / { course lectures}
            //*(5 + { additional bonus})

        }
    }
}