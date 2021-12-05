using System;
namespace _10.ExamPreparation
{
    class ExamPreparation
    {
        static void Main()
        {
            int badGrades = int.Parse(Console.ReadLine());
            int badGradesCounter = 0;
            string taskName = "";
            int grade = 0;
            double sum = 0;
            int gradeCounter = 0;
            double avarageScore = 0;
            string lastProblem = "";

            while (badGradesCounter < badGrades)
            {
                lastProblem = taskName;
                taskName = Console.ReadLine();
                
                if (taskName == "Enough")
                {
                    Console.WriteLine($"Average score: {avarageScore:f2}");
                    Console.WriteLine($"Number of problems: {gradeCounter}");
                    Console.WriteLine($"Last problem: {lastProblem}");
                    break;
                }

                grade = int.Parse(Console.ReadLine());

                if (grade <= 4)
                {
                    badGradesCounter++;
                }

                sum += grade;
                gradeCounter++;

                avarageScore = sum / gradeCounter;
              
            }
            if (badGradesCounter == badGrades)
            {
               Console.WriteLine($"You need a break, {badGradesCounter} poor grades.");
            }

        }
    }
}