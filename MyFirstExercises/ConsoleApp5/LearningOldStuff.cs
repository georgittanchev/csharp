using System;
class LearningOldStuff
{
    static void Main()
    {
        Console.WriteLine("Въведете число, което желаете да конвертирате в инчове.");
        double cm = double.Parse(Console.ReadLine());
        double inch = cm * 2.54;
        Console.WriteLine("Инчове: {0:f2}", inch);
    }
}