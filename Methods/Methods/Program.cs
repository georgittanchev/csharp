using System;
using System.Linq;
namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {

            int numbers = 0;

            SmallestOfThree(numbers);




            //Write a method to print the smallest of three integer numbers.Use appropriate name for the method.
        }

        static int SmallestOfThree(int smallest)
        {
            int numberOne = int.Parse(Console.ReadLine());
            int numberTwo = int.Parse(Console.ReadLine());
            int numberThree = int.Parse(Console.ReadLine());

            int theSmallest = Math.Min(numberOne, (Math.Min(numberTwo, numberThree)));

            Console.WriteLine(theSmallest);

            return theSmallest;

        }
    }
}
