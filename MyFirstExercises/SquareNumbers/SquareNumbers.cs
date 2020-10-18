using System;

class SquareNumbers
{
    static void Main()
    {
        double number = double.Parse(Console.ReadLine());
        double square = Math.Sqrt(number);
        Console.WriteLine("{0:f0}", square);
    

    }
}