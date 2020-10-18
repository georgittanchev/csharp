using System;

namespace VendingMachine2
{
    class Program
    {
        static void Main(string[] args)
        {

            string command = Console.ReadLine();
            double coinsInserted = 0;
            double sum = 0;
            bool invalid = false;

            while (command != "Start")
            {
                coinsInserted = double.Parse(command);

                if (coinsInserted == 1.0 || coinsInserted == 2.0 || coinsInserted == 0.1 || coinsInserted == 0.2 || coinsInserted == 0.5 )
                {
                    sum += coinsInserted;
                }
                else
                {
                    Console.WriteLine($"Cannot accept {coinsInserted}");
                }

                command = Console.ReadLine();
            }

            if (command == "Start")
            {
                double productSum = 0;

                while (command != "End")
                {
                    command = Console.ReadLine();

                    if (command == "Coke")
                    {
                        productSum += 1.0;
                        if (sum >= productSum)
                        {
                            Console.WriteLine($"Purchased {command.ToLower()}");
                        }
                        else
                        {
                            Console.WriteLine("Sorry, not enough money");
                            productSum -= 1.0;
                        } 
                    }
                    else if (command == "Soda")
                    {
                        productSum += 0.8;
                        if (sum >= productSum)
                        {
                            Console.WriteLine($"Purchased {command.ToLower()}");
                        }
                        else
                        {
                            Console.WriteLine("Sorry, not enough money");
                            productSum -= 0.8;
                        }
                    }
                    else if (command == "Crisps")
                    {
                        productSum += 1.5;
                        if (sum >= productSum)
                        {
                            Console.WriteLine($"Purchased {command.ToLower()}");
                        }
                        else
                        {
                            Console.WriteLine("Sorry, not enough money");
                            productSum -= 1.5;
                        }
                    }
                    else if (command == "Water")
                    {
                        productSum += 0.7;
                        if (sum >= productSum)
                        {
                            Console.WriteLine($"Purchased {command.ToLower()}");
                        }
                        else
                        {
                            Console.WriteLine("Sorry, not enough money");
                            productSum -= 0.7;
                        }
                    }
                    else if (command == "Nuts")
                    {
                        productSum += 2.0;
                        if (sum >= productSum)
                        {
                            Console.WriteLine($"Purchased {command.ToLower()}");
                        }
                        else
                        {
                            Console.WriteLine("Sorry, not enough money");
                            productSum -= 2;
                        }
                    }

                    if (command != "Nuts" && command != "Water" && command != "Coke" && command != "Crisps" && command != "Soda" && command != "End")
                    {
                        Console.WriteLine("Invalid product");
                    }


                }
                if (command == "End")
                {
                    Console.WriteLine($"Change: {sum - productSum:F2}");
                }

            }


 //           You task is to calculate the total price of a purchase from a vending machine.Until you receive “Start” 
 //           you will be given different coins that are being inserted in the machine. You have to sum them in order 
 //               to have the total money inserted.There is a problem though.Your vending machine only works 
 //               with 0.1, 0.2, 0.5, 1, and 2 coins.If someone tries to insert some other coins you have to display
 //               “Cannot accept { money}” and not add it to the total money. On the next few lines until you receive “End” 
 //           you will be given products to purchase.Your machine has however only “Nuts”, “Water”, “Crisps”, “Soda”, “Coke”. 
 //           The prices are: 2.0, 0.7, 1.5, 0.8, 1.0 respectively.If the person tries to purchase a not existing product print 
 //               “Invalid product”. Be careful that the person may try to purchase a product they don’t have the money for. 
 //               In that case print “Sorry, not enough money”. If the person purchases a product successfully print “Purchased { product name}”.
 //After the “End” command print the money that are left formatted to the second decimal point in the format “Change: { money left}”.
        }
    }
}
