using System;

namespace _001.IntegerOperations

{
    class IntegerOperations
    {
        static void Main(string[] args)
        {

            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int thirdNumber = int.Parse(Console.ReadLine());
            int fourNumber = int.Parse(Console.ReadLine());

            int finalSum = 0;

            finalSum = ((firstNumber + secondNumber) / thirdNumber) * fourNumber;

            Console.WriteLine(finalSum);






            //Read four integer numbers. Add first to the second, 
            //divide(integer) the sum by the third number and multiply the result by the fourth number. Print the result.
        }
    }
}
