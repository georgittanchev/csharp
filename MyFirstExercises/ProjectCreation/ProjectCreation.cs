using System;
class ProjectCreation
{
    static void Main()
    {
        string architectName = Console.ReadLine();
        double projectCount = double.Parse(Console.ReadLine());
        double endHours = projectCount * 3;
        Console.WriteLine("The architect {0} will need {1} hours to complete {2} project/s", architectName, endHours, projectCount);
    }
}