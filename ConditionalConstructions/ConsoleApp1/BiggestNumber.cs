using System;
class BiggestNumber
{
    static void Main()
    {
        int firstNumber = int.Parse(Console.ReadLine());
        int secondNumber = int.Parse(Console.ReadLine());
        Console.WriteLine("The greater number is:");
        if (firstNumber >secondNumber)
        {
            Console.WriteLine(firstNumber);
        }
       else if (secondNumber > firstNumber)
        {
            Console.WriteLine(secondNumber);
        }

        

    }
}