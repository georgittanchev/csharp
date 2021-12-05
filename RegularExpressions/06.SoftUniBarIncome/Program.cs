using System;
using System.Text.RegularExpressions;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace _06.SoftUniBarIncome
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"^%(?<name>[A-Z]{1}[a-z]+)%[^|$%\.]*<(?<product>\w+)>[^|$%\.]*\|(?<quantity>[\d]+)\|[^|$%\.]*?(?<price>\d+\.?\d*)\$$";
            string input = string.Empty;
            decimal totalPrice = 0;
            decimal income = 0;

            while ((input = Console.ReadLine()) != "end of shift")
            {
                Match match = Regex.Match(input, pattern);
                if (match.Success)
                {
                    string customerName = match.Groups["name"].Value;
                    string product = match.Groups["product"].Value;
                    long quantity = long.Parse(match.Groups["quantity"].Value);
                    decimal price = decimal.Parse(match.Groups["price"].Value);
                    if (quantity != 0)
                    {
                        totalPrice = price * quantity;
                        Console.WriteLine($"{customerName}: {product} - {totalPrice:F2}");
                        income += totalPrice;
                    }
                }
            }
            Console.WriteLine($"Total income: {income:F2}");
        }
    }
}
