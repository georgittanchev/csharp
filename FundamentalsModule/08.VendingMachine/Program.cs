using System;

namespace _08.VendingMachine
{
    class VendingMachine
    {
        static void Main()
        {

            string input = Console.ReadLine();
            double inputToNum = double.Parse(input);
            double sum = 0;
            double productSum = 0;
            if ((inputToNum != 0.1 && inputToNum != 0.2 && inputToNum != 0.5 && inputToNum != 1 && inputToNum != 2) && (input != "0.1" && input != "0.2"
                   && input != "0.5" && input != "1" && input != "2" && input != "Start"))
            {
                Console.WriteLine($"Cannot accept {input:F2}");
            }
            else
            {
                sum += inputToNum;
            }
            if (input != "Start")
            {
                inputToNum = double.Parse(input);
            }


            while (input != "Start")
            {

                input = Console.ReadLine();

                if (input != "Start")
                {
                    inputToNum = double.Parse(input);
                }

                if ((inputToNum != 0.1 && inputToNum != 0.2 && inputToNum != 0.5 && inputToNum != 1 && inputToNum != 2) && (input != "0.1" && input != "0.2"
                    && input != "0.5" && input != "1" && input != "2" && input != "Start"))
                {
                    Console.WriteLine($"Cannot accept {input:F2}");
                    continue;
                }
                if (input != "Start")
                {
                    inputToNum = double.Parse(input);
                    sum += inputToNum;
                }


            }

            if (input == "Start")
            {
                double Coke = 1.0;
                double Nuts = 2.0;
                double Crisps = 1.5;
                double Soda = 0.8;
                double Water = 0.7;

                productSum = 0;

                while (input != "End")
                {

                    input = Console.ReadLine();


                    if (input != "Water" && input != "Coke" && input != "Soda" && input != "Crisps" && input != "Nuts")
                    {
                        if (input == "End")
                        {
                            Console.WriteLine($"Change: {sum - productSum:F2}");
                            break;
                        }
                        Console.WriteLine("Invalid product");

                    }
                    if (productSum > sum)
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                    if (input == "Coke" && (sum > productSum))
                    {
                        productSum += 1.0;
                        if (productSum > sum)
                        {
                            Console.WriteLine("Sorry, not enough money");
                            productSum -= 1;
                        }
                        else
                        {
                            Console.WriteLine($"Purchased coke");
                        }

                    }
                    else if (input == "Nuts" && (sum > productSum))
                    {
                        productSum += 2.0;
                        if (productSum > sum)
                        {
                            Console.WriteLine("Sorry, not enough money");
                            productSum -= 2;
                        }
                        else
                        {
                            Console.WriteLine($"Purchased nuts");
                        }
                    }
                    else if (input == "Crisps" && (sum > productSum))
                    {
                        productSum += 1.5;
                        if (productSum > sum)
                        {
                            Console.WriteLine("Sorry, not enough money");
                            productSum -= 1.5;
                        }
                        else
                        {
                            Console.WriteLine($"Purchased crisps");
                        }
                    }
                    else if (input == "Soda" && (sum > productSum))
                    {
                        productSum += 0.8;
                        if (productSum > sum)
                        {
                            Console.WriteLine("Sorry, not enough money");
                            productSum -= 0.8;
                        }
                        else
                        {
                            Console.WriteLine($"Purchased soda");
                        }
                    }
                    else if (input == "Water" && (sum > productSum))
                    {
                        productSum += 0.7;
                        if (productSum > sum)
                        {
                            Console.WriteLine("Sorry, not enough money");
                            productSum -= 0.7;
                        }
                        else
                        {
                            Console.WriteLine($"Purchased water");
                        }
                    }


                }



            }

        }
    }
}
//You task is to calculate the total price of a purchase from a vending machine.Until you receive “Start” you will
//    be given different coins that are being inserted in the machine. You have to sum them in order to have the total
//    money inserted.There is a problem though.Your vending machine only works with 0.1, 0.2, 0.5, 1, and 2 coins.
//    If someone tries to insert some other coins you have to display “Cannot accept { money}” and not add it to 
//    the total money. On the next few lines until you receive “End” you will be given products to purchase.
//    Your machine has however only “Nuts”, “Water”, “Crisps”, “Soda”, “Coke”. The prices are: 2.0, 0.7, 1.5, 0.8, 
//1.0 respectively.If the person tries to purchase a not existing product print “Invalid product”. Be careful that 
//    the person may try to purchase a product they don’t have the money for. In that case print “Sorry, not enough money”.
//    If the person purchases a product successfully print “Purchased { product name}”. After the “End” 
//command print the money that are left formatted to the second decimal point in the format “Change: { money left}”.