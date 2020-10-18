using System;
namespace _05.EqualNumbers
{
    class EqualNumbers
    {
        static void Main()
        {
            double firstNumber = double.Parse(Console.ReadLine());
            double secondNumber = double.Parse(Console.ReadLine());
            double thirdNumber = double.Parse(Console.ReadLine());

            if (firstNumber == secondNumber && firstNumber == thirdNumber && firstNumber % 2 ==0)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            
            }
            
        }
    }
}