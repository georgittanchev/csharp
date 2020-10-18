using System;
using System.Linq;

namespace AllInOne
{
    class Program
    {
        static void Main(string[] args)
        {

            int howManyNumbers = int.Parse(Console.ReadLine());
            int[] numbers = new int[howManyNumbers];
          
            for (int i = 0; i < howManyNumbers; i++)
            {
                int number = int.Parse(Console.ReadLine());
                numbers[i] = number;
            }

            for (int k = numbers.Length; k >= 0; k--)
            {
                Console.Write(numbers[k-1] + " ");
            }
            

            //Read n numbers and print them in reverse order. 
        }
    }
}
