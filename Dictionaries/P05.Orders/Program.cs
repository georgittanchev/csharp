using System;
using System.Linq;
using System.Collections.Generic;

namespace P05.Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, double> nameAndPrice = new Dictionary<string, double>();
            Dictionary<string, int> nameAndQuantity = new Dictionary<string, int>();
            string command = string.Empty;
            while ((command = Console.ReadLine()) != "buy")  
            {

                string[] input = command.Split().ToArray();
                string name = input[0];
                double price = double.Parse(input[1]);
                int quantity = int.Parse(input[2]);

                if (!nameAndPrice.ContainsKey(name))
                {
                    nameAndPrice.Add(name, 0);
                    nameAndQuantity.Add(name, 0);
                }

                nameAndQuantity[name] += quantity;
                nameAndPrice[name] = price * nameAndQuantity[name];

            }

            
            foreach (var item in nameAndPrice)
            {
                Console.WriteLine($"{item.Key} -> {item.Value:F2}");
            }

        }
    }
}
