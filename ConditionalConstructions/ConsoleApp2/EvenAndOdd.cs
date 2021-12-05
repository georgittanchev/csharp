using System;
namespace EvenAndOdd
{
    class EvenAndOdd
    {
        static void Main()
        {
            double number = double.Parse(Console.ReadLine());
            if (number %2 ==0)
            {
                Console.WriteLine("Even");
            }
            else
            {
                Console.WriteLine("Odd");
            }
        }
    }
}

//4. Четно или нечетно
//Да се напише програма, която чете цяло число въведено от потребителя и отпечатва на конзолата, дали е
//четно или нечетно.