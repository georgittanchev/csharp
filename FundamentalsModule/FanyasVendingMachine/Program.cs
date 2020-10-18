using System;

namespace _07.VendingMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();

            double sumCoins = 0.0;
            bool isValid = true;

            while (command != "Start")
            {
                double insertCoins = double.Parse(command);

                if (insertCoins == 0.1 || insertCoins == 0.2 || insertCoins == 0.5 || insertCoins == 1 || insertCoins == 2)
                {
                    sumCoins += insertCoins;
                }
                else
                {
                    Console.WriteLine($"Cannot accept {insertCoins}");
                }

                command = Console.ReadLine();
            }
            if (command == "Start")
            {
                command = Console.ReadLine();

                while (command != "End")
                {
                    string product = command;
                    double productPrice = 0;

                    if (product == "Nuts")
                    {
                        productPrice = 2.0;
                    }
                    else if (product == "Water")
                    {
                        productPrice = 0.7;
                    }
                    else if (product == "Crisps")
                    {
                        productPrice = 1.5;
                    }
                    else if (product == "Soda")
                    {
                        productPrice = 0.8;
                    }
                    else if (product == "Coke")
                    {
                        productPrice = 1.0;
                    }
                    else
                    {
                        Console.WriteLine("Invalid product");
                        isValid = false;
                    }
                    if (productPrice > sumCoins)
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                    else if (isValid == true)
                    {
                        sumCoins -= productPrice;
                        Console.WriteLine($"Purchased {product.ToLower()}");
                    }

                    command = Console.ReadLine();
                }
                if (command == "End")
                {
                    Console.WriteLine($"Change: {sumCoins:F2}");
                }
            }
        }
    }
}
