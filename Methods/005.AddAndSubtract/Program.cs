using System;
using System.Linq;

namespace _005.AddAndSubtract
{

    class AddAndSubtract
    {
        static void Main()
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int thirdNumber = int.Parse(Console.ReadLine());

            Subtract(firstNumber, secondNumber, thirdNumber);

        }

        static int SumOfNumbers(int firstNumber, int secondNumber)
        {

            int sum = firstNumber + secondNumber;
            return sum;
        }

        static void Subtract(int firstNumber, int secondNumber, int thirdNumber)
        {

            int result = SumOfNumbers(firstNumber, secondNumber) - thirdNumber;

            Console.WriteLine(result);
        }




    }
}