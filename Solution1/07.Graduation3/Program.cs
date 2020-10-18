using System;
namespace _07.Graduation3
{
    class Program
    {
        static void Main()
        {

            string name = Console.ReadLine();
            int counter = 1;
            double grade = 0;
            double sum = 0;
            double avarageScore = 0;
            int howCut = 0;

            while (counter <= 12 && howCut < 2)
            {
                grade = double.Parse(Console.ReadLine());
                if (!(grade < 4))
                {
                    sum += grade;
                    counter++;
                }
                else
                {
                    howCut++;
                }

                if (howCut == 2)
                {
                    Console.WriteLine($"{name} has been excluded at {counter} grade");
                    

                }


                if (counter == 13)
                {
                    avarageScore = sum / 12;

                    Console.WriteLine($"{name} graduated. Average grade: {avarageScore:F2}");
                }

            }

            

        }
    }
}