using System;

namespace _0004.SumOfChars
{
    class Program
    {
        static void Main(string[] args)
        {

            int numberOfLines = int.Parse(Console.ReadLine());
            double sum = 0;
            

            for (int i = 0; i < numberOfLines; i++)
            {
                char letters = char.Parse(Console.ReadLine());

                sum += letters;

            }

            Console.WriteLine($"The sum equals: {sum}");


//            Write a program, which sums the ASCII codes of n characters and prints the sum on the console.
//Input
//•	On the first line, you will receive n – the number of lines, which will follow
//•	On the next n lines – you will receive letters from the Latin alphabet
//Output
//Print the total sum in the following format:

        }
    }
}
