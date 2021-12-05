using System;

namespace _03.AccountBalance2
{
    class Program
    {
        static void Main(string[] args)
        {
            double transactionCount = double.Parse(Console.ReadLine());
            double counter = 1;
            double transaction = 0;
            double balance = 0;

            while (counter <= transactionCount)
            {
                transaction = double.Parse(Console.ReadLine());
                
                if (transaction < 0)
                {
                    
                    Console.WriteLine("Invalid operation!");
                    break;
                   
                }
                Console.WriteLine($"Increase: {transaction:F2}");
                balance += transaction;
                counter++;

            }
           
            Console.WriteLine($"Total: {balance:F2}");
            
        }
    }
}
