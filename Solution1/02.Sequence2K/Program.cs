using System;

namespace _02.Sequence2K
{
    class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            double counter = 1;

            while (counter <= number)
            {
                Console.WriteLine($"{counter}");
                counter = counter * 2 + 1;
                

            }
        }
    }
}
