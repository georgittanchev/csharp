using System;
namespace _04.MaxNumber
{
    class MaxNumber
    {
        static void Main()
        {
            //            Напишете програма, която чете n-на брой цели числа(n > 0), въведени от потребителя, и намира най -
            //голямото измежду тях. Първо се въвежда броят числа n, а след това самите n числа, по едно на ред. 

            int numberCounter = int.Parse(Console.ReadLine());
            int numbers = 0;
            int max = int.MinValue;

            while (numbers < numberCounter)
            {
                int number = int.Parse(Console.ReadLine());
                numbers++;

                if (number > max)
                {
                    
                }
            }
        
            
            
        }
    }
}