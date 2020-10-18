using System;

namespace _02.Division
{
    class Division
    {
        static void Main(string[] args)
        {

            int i = int.Parse(Console.ReadLine());
            int devisible = 0;

            

            if (i % 10 == 0)
            {
                devisible = 10;
                Console.WriteLine($"The number is divisible by {devisible}");
            }
            else if (i % 7 == 0)
            {
                devisible = 7;
                Console.WriteLine($"The number is divisible by {devisible}");
            }
            else if (i % 6 == 0)
            {
                devisible = 6;
                Console.WriteLine($"The number is divisible by {devisible}");

            }
            else if (i % 3 == 0)
            {
                devisible = 3;
                Console.WriteLine($"The number is divisible by {devisible}");
            }
            else if (i % 2 == 0)
            {
                devisible = 2;
                Console.WriteLine($"The number is divisible by {devisible}");
            }
           

            else
            {
                Console.WriteLine("Not divisible");
            }



        }
    }
}
