using System;

namespace _06.Graduation
{
    class Program
    {
        static void Main(string[] args)
        {
            string studentName = Console.ReadLine();
            int counter = 1;
            double grade = 0;
            double avarageGrade = 0;
            double sum = 0;

            while (counter <= 12)
            {
                grade = double.Parse(Console.ReadLine());
          
                sum += grade;

                if (grade < 4)
                {
                    sum -= grade;
                    counter--;
                }

                counter++;
            }

            avarageGrade = sum / 12;
            Console.WriteLine($"{studentName} graduated. Average grade: {avarageGrade:F2}");
        

        }
    }
}
