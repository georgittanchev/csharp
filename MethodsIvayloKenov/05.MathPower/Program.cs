using System;

namespace _05.MathPower
{
    class Program
    {
        static void Main(string[] args)
        {
            double numberToRaise = double.Parse(Console.ReadLine());
            double upToWhatNumberToRaiseIt = double.Parse(Console.ReadLine());
            MathPower(numberToRaise, upToWhatNumberToRaiseIt);
        }

        static double MathPower(double firstNumber, double secondNumber)
        {
            double result = 1;
            for (int i = 0; i <= secondNumber; i++)
            {

                result = Math.Pow(firstNumber, secondNumber);
            }
          
            Console.Write(result);
            return result;
        }
    }
}
