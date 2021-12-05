using System;
namespace _19.Scholarship
{
    class Scholarship
    {
        static void Main()
        {
            double income = double.Parse(Console.ReadLine());
            double avarageScore = double.Parse(Console.ReadLine());
            double minimumSalary = double.Parse(Console.ReadLine());

            double socialBonus = Math.Floor(minimumSalary * 0.35);
            double gradeBonus = Math.Floor(avarageScore * 25);

            if (income < minimumSalary && avarageScore >= 5.5)
            { 
                if (socialBonus > gradeBonus)
                {
                    Console.WriteLine($"You get a Social scholarship {socialBonus} BGN");
                }
                else if (gradeBonus > socialBonus)
                {
                    Console.WriteLine($"You get a scholarship for excellent results {gradeBonus} BGN");
                }
            }
            else if (income < minimumSalary && avarageScore > 4.5)
            { 
                    Console.WriteLine($"You get a Social scholarship {socialBonus} BGN");  
            }
            else if (avarageScore >= 5.5)
            {   
                    Console.WriteLine($"You get a scholarship for excellent results {gradeBonus} BGN");
            }
            else
            {
                Console.WriteLine("You cannot get a scholarship!");
            }
        }
    }
}