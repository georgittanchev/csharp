using System;
using System.Text.RegularExpressions;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace _04.Furniture
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @">>(?<name>[A-Za-z][A-Za-z]+)<<(?<price>[\d]+.?[\d]+)!(?<quantity>[\d]+)";
            string input;
            List<string> furnitureNames = new List<string>();
            string name;
            decimal price;
            long quantity;
            decimal totalPrice = 0;


            while ((input = Console.ReadLine()) != "Purchase")
            {

                Match furnitures = Regex.Match(input, pattern);
              
                    if (furnitures.Success)
                    {
                        name = furnitures.Groups["name"].Value;
                        price = decimal.Parse(furnitures.Groups["price"].Value);
                        quantity = long.Parse(furnitures.Groups["quantity"].Value);
                        if (quantity > 0)
                        {
                            totalPrice += price * quantity;
                            furnitureNames.Add(name);

                        }
                    }
                
            }
            Console.WriteLine("Bought furniture:");
            foreach (var item in furnitureNames)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine($"Total money spend: {totalPrice:F2}");

        }
    }
}
