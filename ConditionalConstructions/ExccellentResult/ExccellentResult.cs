using System;
class ExccellentResult
{
    static void Main()
    {
        double grade = double.Parse(Console.ReadLine());
        if (grade >= 5.50)
        {
            Console.WriteLine("Exccellent");
        }
        else
        {
            Console.WriteLine("Bad, bad girl");
        }
    }
}